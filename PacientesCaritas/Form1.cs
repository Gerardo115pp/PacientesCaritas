﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
//using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace PacientesCaritas
{
    public partial class Form1 : Form
    {


        #region <Propertys>

        #region <FromMovement>

        private bool dragging;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        #endregion <FormMovement/>

        private Dictionary<string, string> popups_values;


        #endregion <Propertys/>

        public Form1()
        {
            InitializeComponent();
            this.dragging = false;
            this.popups_values = new Dictionary<string, string>();
            this.GenderComboBox.SelectedIndex = 0;
        }

        #region <Frontend Behavior>

        #region <Movement and controls>


        private void CloseBTN_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void MinimizeBTN_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void ControlPanel_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void ControlPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void ControlPanel_MouseUp(object sender, MouseEventArgs e)
        {
            this.dragging = false;
        }

        #endregion <Movement and controls/>

        #region <Fields handlers>
          
        private void clearBTNClickHandler(Object sender,EventArgs e)
        {
            this.clearFields();
        }

        #endregion <Fields handlers>


        #endregion <Frontend Behavior/>

        #region <Script>

        #region <Statics>

        static public string sha1(string texto)
        {
            /*
             * Convierte una cadena en un hash tambien de tipo cadena por c sharp es estupido y no
             * sabe hacerlo solo.............
             */
            SHA1 encrypter = SHA1CryptoServiceProvider.Create();
            DateTime right_now = DateTime.Now;

            Byte[] text_in_bytes = ASCIIEncoding.Default.GetBytes(texto+right_now.ToString("dd/MM/yy--hh:mm:ffff"));
            Byte[] hash = encrypter.ComputeHash(text_in_bytes);
            StringBuilder cadena = new StringBuilder();
            foreach (byte i in hash)
            {
                cadena.AppendFormat("{0:x2}", i);
            }
            return cadena.ToString();
        }
        
        #endregion <Statics/>

        private void popUpClickedHandler(Object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string content = (this.popups_values.ContainsKey(btn.Text)) ? this.popups_values[btn.Text] : "";
            PopUpInputForm Popup = new PopUpInputForm(btn.Text,content);
            Popup.ShowDialog();
            if(Popup.Content.Length > 1)
            {
                this.popups_values[btn.Text] = Popup.Content;
                btn.BackColor = System.Drawing.Color.FromArgb(255, 200, 255, 200);
            }
        }

        private Dictionary<string,string> getAllFieldValues()
        {
            Dictionary<string, string> data_to_return = new Dictionary<string, string>();
            data_to_return["nombre"] = this.NamePacientTextBox.Text;
            data_to_return["edad"] = this.AgeTextbox.Text;
            data_to_return["domicilio"] = this.AddressTextBox.Text;
            data_to_return["telephone"] = this.TelTextBox.Text;
            data_to_return["genero"] = this.GenderComboBox.SelectedItem.ToString();
            data_to_return["pulso"] = this.PulsoTextBox.Text;
            data_to_return["temp"] = this.TempTextBox.Text;
            data_to_return["T.A"] = this.TATextBox.Text;
            data_to_return["F.R"] = this.FRTextBox.Text;
            data_to_return["F.C"] = this.FCTextBox.Text;
            data_to_return["tabaquismo"] = this.TabaquismoTextBox.Text;
            data_to_return["alcoholismo"] = this.AlcoholismoTextBox.Text;
            data_to_return["adicciones"] = this.AdiccionesTextBox.Text;

            foreach(string key in this.popups_values.Keys)
            {
                data_to_return[key] = this.popups_values[key];
            }
            return data_to_return;
        }

        private void compileDatatoJson(Object sender, EventArgs e)
        {
            Dictionary<string, string> data = this.getAllFieldValues();
            string filename = Form1.sha1(data["nombre"]);
            string Datos = JsonConvert.SerializeObject(data);
            File.WriteAllText($"{filename}.json",Datos);
            this.clearFields();
        }

        private void resetBTNsColor()
        {
            this.InterrogatorioBTN.BackColor = System.Drawing.Color.FromArgb(255, 255, 255, 255);
            this.PaiasBTN.BackColor = System.Drawing.Color.FromArgb(255, 255, 255, 255);
            this.AhfBTN.BackColor = System.Drawing.Color.FromArgb(255, 255, 255, 255);
            this.AhfBTN.BackColor = System.Drawing.Color.FromArgb(255, 255, 255, 255);
            this.TrBTN.BackColor = System.Drawing.Color.FromArgb(255, 255, 255, 255);
            this.DiagnosticoBTN.BackColor = System.Drawing.Color.FromArgb(255, 255, 255, 255);
            this.NotasBTN.BackColor = System.Drawing.Color.FromArgb(255, 255, 255, 255);
            this.EstudiosBTN.BackColor = System.Drawing.Color.FromArgb(255, 255, 255, 255);
        }

        private void clearFields()
        {
            this.NamePacientTextBox.Text = "";
            this.AgeTextbox.Text = "";
            this.AddressTextBox.Text = "";
            this.TelTextBox.Text = "";
            this.GenderComboBox.SelectedIndex = 0;
            this.PulsoTextBox.Text = "";
            this.TempTextBox.Text = "";
            this.TATextBox.Text = "";
            this.FCTextBox.Text = "";
            this.FRTextBox.Text = "";
            this.TabaquismoTextBox.Text = "";
            this.AlcoholismoTextBox.Text = "";
            this.AdiccionesTextBox.Text = "";
            this.resetBTNsColor();

            this.popups_values = new Dictionary<string, string>();
        }


        #endregion <Script/>
    }
}