namespace Trabajo4_Auditoria
{
    partial class InputBD
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
            panel1 = new Panel();
            panel6 = new Panel();
            button2 = new Button();
            checkBoxAuthentication = new CheckBox();
            button1 = new Button();
            panel4 = new Panel();
            passwordInput = new TextBox();
            label3 = new Label();
            panel3 = new Panel();
            usernameInput = new TextBox();
            label2 = new Label();
            panel5 = new Panel();
            DBNameInput = new TextBox();
            label1 = new Label();
            panel2 = new Panel();
            serverNameInput = new TextBox();
            label4 = new Label();
            panel1.SuspendLayout();
            panel6.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(10);
            panel1.Size = new Size(723, 422);
            panel1.TabIndex = 0;
            // 
            // panel6
            // 
            panel6.Controls.Add(button2);
            panel6.Controls.Add(checkBoxAuthentication);
            panel6.Controls.Add(button1);
            panel6.Dock = DockStyle.Top;
            panel6.Location = new Point(10, 292);
            panel6.Name = "panel6";
            panel6.Size = new Size(703, 125);
            panel6.TabIndex = 10;
            // 
            // button2
            // 
            button2.Location = new Point(451, 73);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 4;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // checkBoxAuthentication
            // 
            checkBoxAuthentication.AutoSize = true;
            checkBoxAuthentication.Location = new Point(246, 15);
            checkBoxAuthentication.Name = "checkBoxAuthentication";
            checkBoxAuthentication.Size = new Size(203, 24);
            checkBoxAuthentication.TabIndex = 9;
            checkBoxAuthentication.Text = "SQL Server Authentication";
            checkBoxAuthentication.UseVisualStyleBackColor = true;
            checkBoxAuthentication.CheckedChanged += checkBoxAuthentication_CheckedChanged;
            // 
            // button1
            // 
            button1.Location = new Point(173, 73);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 3;
            button1.Text = "Aceptar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(passwordInput);
            panel4.Controls.Add(label3);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(10, 223);
            panel4.Margin = new Padding(0, 0, 0, 10);
            panel4.Name = "panel4";
            panel4.Size = new Size(703, 69);
            panel4.TabIndex = 8;
            // 
            // passwordInput
            // 
            passwordInput.Location = new Point(342, 26);
            passwordInput.Name = "passwordInput";
            passwordInput.Size = new Size(203, 27);
            passwordInput.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(173, 26);
            label3.Name = "label3";
            label3.Size = new Size(86, 20);
            label3.TabIndex = 1;
            label3.Text = "Contraseña:";
            // 
            // panel3
            // 
            panel3.Controls.Add(usernameInput);
            panel3.Controls.Add(label2);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(10, 154);
            panel3.Margin = new Padding(0, 0, 0, 10);
            panel3.Name = "panel3";
            panel3.Size = new Size(703, 69);
            panel3.TabIndex = 7;
            // 
            // usernameInput
            // 
            usernameInput.Location = new Point(342, 26);
            usernameInput.Name = "usernameInput";
            usernameInput.Size = new Size(203, 27);
            usernameInput.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(173, 26);
            label2.Name = "label2";
            label2.Size = new Size(142, 20);
            label2.TabIndex = 1;
            label2.Text = "Nombre de Usuario:";
            // 
            // panel5
            // 
            panel5.Controls.Add(DBNameInput);
            panel5.Controls.Add(label1);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(10, 85);
            panel5.Margin = new Padding(0, 0, 0, 10);
            panel5.Name = "panel5";
            panel5.Size = new Size(703, 69);
            panel5.TabIndex = 6;
            // 
            // DBNameInput
            // 
            DBNameInput.Location = new Point(342, 28);
            DBNameInput.Name = "DBNameInput";
            DBNameInput.Size = new Size(203, 27);
            DBNameInput.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(173, 28);
            label1.Name = "label1";
            label1.Size = new Size(128, 20);
            label1.TabIndex = 0;
            label1.Text = "Nombre de la BD:";
            // 
            // panel2
            // 
            panel2.Controls.Add(serverNameInput);
            panel2.Controls.Add(label4);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(10, 10);
            panel2.Name = "panel2";
            panel2.Size = new Size(703, 75);
            panel2.TabIndex = 5;
            // 
            // serverNameInput
            // 
            serverNameInput.Location = new Point(342, 30);
            serverNameInput.Name = "serverNameInput";
            serverNameInput.Size = new Size(203, 27);
            serverNameInput.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(173, 30);
            label4.Name = "label4";
            label4.Size = new Size(149, 20);
            label4.TabIndex = 2;
            label4.Text = "Nombre del servidor:";
            // 
            // InputBD
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(723, 422);
            Controls.Add(panel1);
            Name = "InputBD";
            Text = "Definir Servidor";
            panel1.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button2;
        private Button button1;
        private Panel panel4;
        private TextBox passwordInput;
        private Label label3;
        private Panel panel3;
        private TextBox usernameInput;
        private Label label2;
        private Panel panel5;
        private TextBox DBNameInput;
        private Label label1;
        private Panel panel2;
        private TextBox serverNameInput;
        private Label label4;
        private CheckBox checkBoxAuthentication;
        private Panel panel6;
    }
}