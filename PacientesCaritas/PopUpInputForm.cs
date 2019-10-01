using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PacientesCaritas
{
    public partial class PopUpInputForm : Form
    {
        #region <Propertys>

        #region <FromMovement>
        private bool dragging;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        #endregion <FormMovement/>

        #region <MainPropertys>

        private string content;
        
        public string Content
        {
            get { return this.content; }
        }

        #endregion <MainPropertys/>

        #endregion <Propertys/>

        public PopUpInputForm(string title_text, string content="")
        {
            InitializeComponent();
            this.TitleLBL.Text = title_text;
            this.ContentTextBox.Text = content;
            this.content = content;
            this.ContentTextBox.Focus();
        }

        #region <FrontEnd Behavior>

        #region <Movement and controls>
        private void PopUpInputForm_Load(object sender, EventArgs e)
        {

        }

        private void CloseBTN_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void ContentTextBox_TextChanged(object sender, EventArgs e)
        {
            this.content = this.ContentTextBox.Text;
        }

        private void ContentTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyData == Keys.Enter)
            {
                this.Close();
            }
        }

        #endregion <FrontEnd Behavior/>

    }
}
