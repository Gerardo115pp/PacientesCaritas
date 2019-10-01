namespace PacientesCaritas
{
    partial class PopUpInputForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TitlePanel = new System.Windows.Forms.Panel();
            this.ControlsContainer = new System.Windows.Forms.Panel();
            this.MinimizeBTN = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.TitleLBL = new System.Windows.Forms.Label();
            this.ContentTextBox = new System.Windows.Forms.TextBox();
            this.TitlePanel.SuspendLayout();
            this.ControlsContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // TitlePanel
            // 
            this.TitlePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(120)))));
            this.TitlePanel.Controls.Add(this.ControlsContainer);
            this.TitlePanel.Controls.Add(this.TitleLBL);
            this.TitlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TitlePanel.Location = new System.Drawing.Point(0, 0);
            this.TitlePanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TitlePanel.Name = "TitlePanel";
            this.TitlePanel.Size = new System.Drawing.Size(1111, 75);
            this.TitlePanel.TabIndex = 1;
            this.TitlePanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ControlPanel_MouseDown);
            this.TitlePanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ControlPanel_MouseMove);
            this.TitlePanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ControlPanel_MouseUp);
            // 
            // ControlsContainer
            // 
            this.ControlsContainer.Controls.Add(this.MinimizeBTN);
            this.ControlsContainer.Controls.Add(this.button1);
            this.ControlsContainer.Dock = System.Windows.Forms.DockStyle.Right;
            this.ControlsContainer.Location = new System.Drawing.Point(853, 0);
            this.ControlsContainer.Name = "ControlsContainer";
            this.ControlsContainer.Size = new System.Drawing.Size(258, 75);
            this.ControlsContainer.TabIndex = 2;
            // 
            // MinimizeBTN
            // 
            this.MinimizeBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(120)))));
            this.MinimizeBTN.Dock = System.Windows.Forms.DockStyle.Right;
            this.MinimizeBTN.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(120)))));
            this.MinimizeBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimizeBTN.Font = new System.Drawing.Font("Trebuchet MS", 20.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimizeBTN.ForeColor = System.Drawing.Color.White;
            this.MinimizeBTN.Location = new System.Drawing.Point(24, 0);
            this.MinimizeBTN.Name = "MinimizeBTN";
            this.MinimizeBTN.Size = new System.Drawing.Size(117, 75);
            this.MinimizeBTN.TabIndex = 1;
            this.MinimizeBTN.Text = "_";
            this.MinimizeBTN.UseVisualStyleBackColor = false;
            this.MinimizeBTN.Click += new System.EventHandler(this.MinimizeBTN_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Trebuchet MS", 20.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(141, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 75);
            this.button1.TabIndex = 0;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.CloseBTN_Click);
            // 
            // TitleLBL
            // 
            this.TitleLBL.AutoSize = true;
            this.TitleLBL.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLBL.ForeColor = System.Drawing.Color.White;
            this.TitleLBL.Location = new System.Drawing.Point(12, 9);
            this.TitleLBL.Name = "TitleLBL";
            this.TitleLBL.Size = new System.Drawing.Size(149, 62);
            this.TitleLBL.TabIndex = 1;
            this.TitleLBL.Text = "Titulo";
            // 
            // ContentTextBox
            // 
            this.ContentTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ContentTextBox.Font = new System.Drawing.Font("Yu Gothic", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContentTextBox.Location = new System.Drawing.Point(19, 103);
            this.ContentTextBox.Multiline = true;
            this.ContentTextBox.Name = "ContentTextBox";
            this.ContentTextBox.Size = new System.Drawing.Size(1076, 309);
            this.ContentTextBox.TabIndex = 3;
            this.ContentTextBox.TextChanged += new System.EventHandler(this.ContentTextBox_TextChanged);
            this.ContentTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ContentTextBox_KeyDown);
            // 
            // PopUpInputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 428);
            this.Controls.Add(this.ContentTextBox);
            this.Controls.Add(this.TitlePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PopUpInputForm";
            this.Text = "PopUpInputForm";
            this.Load += new System.EventHandler(this.PopUpInputForm_Load);
            this.TitlePanel.ResumeLayout(false);
            this.TitlePanel.PerformLayout();
            this.ControlsContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel TitlePanel;
        private System.Windows.Forms.Panel ControlsContainer;
        private System.Windows.Forms.Button MinimizeBTN;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label TitleLBL;
        private System.Windows.Forms.TextBox ContentTextBox;
    }
}