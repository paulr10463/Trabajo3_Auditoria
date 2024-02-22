namespace Trabajo4_Auditoria
{
    partial class MainPage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            archivoToolStripMenuItem = new ToolStripMenuItem();
            nuevaBDToolStripMenuItem = new ToolStripMenuItem();
            cerrarBDToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            salirToolStripMenuItem = new ToolStripMenuItem();
            verToolStripMenuItem = new ToolStripMenuItem();
            guardarToolStripMenuItem = new ToolStripMenuItem();
            button1 = new Button();
            button2 = new Button();
            panel1 = new Panel();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { archivoToolStripMenuItem, verToolStripMenuItem, guardarToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1664, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            archivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { nuevaBDToolStripMenuItem, cerrarBDToolStripMenuItem, toolStripSeparator1, salirToolStripMenuItem });
            archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            archivoToolStripMenuItem.Size = new Size(73, 24);
            archivoToolStripMenuItem.Text = "Archivo";
            // 
            // nuevaBDToolStripMenuItem
            // 
            nuevaBDToolStripMenuItem.Name = "nuevaBDToolStripMenuItem";
            nuevaBDToolStripMenuItem.Size = new Size(158, 26);
            nuevaBDToolStripMenuItem.Text = "Nueva BD";
            nuevaBDToolStripMenuItem.Click += nuevaBDToolStripMenuItem_Click;
            // 
            // cerrarBDToolStripMenuItem
            // 
            cerrarBDToolStripMenuItem.Name = "cerrarBDToolStripMenuItem";
            cerrarBDToolStripMenuItem.Size = new Size(158, 26);
            cerrarBDToolStripMenuItem.Text = "Cerrar BD";
            cerrarBDToolStripMenuItem.Click += cerrarBDToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(155, 6);
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(158, 26);
            salirToolStripMenuItem.Text = "Salir";
            salirToolStripMenuItem.Click += salirToolStripMenuItem_Click;
            // 
            // verToolStripMenuItem
            // 
            verToolStripMenuItem.Name = "verToolStripMenuItem";
            verToolStripMenuItem.Size = new Size(44, 24);
            verToolStripMenuItem.Text = "Ver";
            // 
            // guardarToolStripMenuItem
            // 
            guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            guardarToolStripMenuItem.Size = new Size(76, 24);
            guardarToolStripMenuItem.Text = "Guardar";
            // 
            // button1
            // 
            button1.Location = new Point(32, 63);
            button1.Name = "button1";
            button1.Size = new Size(170, 51);
            button1.TabIndex = 2;
            button1.Text = "Identificar Integridad Referencial";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(554, 63);
            button2.Name = "button2";
            button2.Size = new Size(105, 50);
            button2.TabIndex = 3;
            button2.Text = "Chequear anomalías";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.BackColor = Color.DimGray;
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 157);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(40, 0, 40, 0);
            panel1.Size = new Size(1664, 678);
            panel1.TabIndex = 4;
            // 
            // button3
            // 
            button3.Location = new Point(665, 63);
            button3.Name = "button3";
            button3.Size = new Size(184, 48);
            button3.TabIndex = 5;
            button3.Text = "Anomalías que no dependen de los datos";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(855, 63);
            button4.Name = "button4";
            button4.Size = new Size(82, 50);
            button4.TabIndex = 6;
            button4.Text = "Primary Keys";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(1097, 81);
            button5.Name = "button5";
            button5.Size = new Size(308, 32);
            button5.TabIndex = 7;
            button5.Text = "Detectar valores nulos o repetidos";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(208, 62);
            button6.Name = "button6";
            button6.Size = new Size(340, 51);
            button6.TabIndex = 8;
            button6.Text = "Identificar si el tipo de dato de clave primaria y foránea son compatibles";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(1097, 44);
            button7.Name = "button7";
            button7.Size = new Size(308, 31);
            button7.TabIndex = 9;
            button7.Text = "Revisar nulos en foreign keys";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Location = new Point(943, 63);
            button8.Name = "button8";
            button8.Size = new Size(126, 48);
            button8.TabIndex = 10;
            button8.Text = "Valores Repetidos";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.Location = new Point(1411, 44);
            button9.Name = "button9";
            button9.Size = new Size(128, 82);
            button9.TabIndex = 11;
            button9.Text = "Revisar claves foráneas desactivadas";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // MainPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1664, 835);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(panel1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainPage";
            Text = "Auditoría de Bases de datos";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem archivoToolStripMenuItem;
        private ToolStripMenuItem nuevaBDToolStripMenuItem;
        private ToolStripMenuItem cerrarBDToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem salirToolStripMenuItem;
        private ToolStripMenuItem verToolStripMenuItem;
        private ToolStripMenuItem guardarToolStripMenuItem;
        private Button button1;
        private Button button2;
        private Panel panel1;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
    }
}
