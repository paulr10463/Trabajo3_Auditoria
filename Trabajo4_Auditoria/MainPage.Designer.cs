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
            button10 = new Button();
            button11 = new Button();
            button12 = new Button();
            panel2 = new Panel();
            menuStrip1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { archivoToolStripMenuItem, verToolStripMenuItem, guardarToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1864, 28);
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
            button1.Dock = DockStyle.Left;
            button1.Location = new Point(1218, 0);
            button1.Name = "button1";
            button1.Size = new Size(112, 131);
            button1.TabIndex = 2;
            button1.Text = "Identificar Integridad Referencial";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Dock = DockStyle.Left;
            button2.Location = new Point(743, 0);
            button2.Name = "button2";
            button2.Size = new Size(105, 131);
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
            panel1.Location = new Point(0, 202);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(40, 40, 40, 0);
            panel1.Size = new Size(1864, 633);
            panel1.TabIndex = 4;
            // 
            // button3
            // 
            button3.Dock = DockStyle.Left;
            button3.Location = new Point(507, 0);
            button3.Name = "button3";
            button3.Size = new Size(124, 131);
            button3.TabIndex = 5;
            button3.Text = "Anomalías que no dependen de los datos";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Dock = DockStyle.Left;
            button4.Location = new Point(309, 0);
            button4.Name = "button4";
            button4.Size = new Size(90, 131);
            button4.TabIndex = 6;
            button4.Text = "Primary Keys";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Dock = DockStyle.Left;
            button5.Location = new Point(196, 0);
            button5.Name = "button5";
            button5.Size = new Size(113, 131);
            button5.TabIndex = 7;
            button5.Text = "Detectar valores nulos o repetidos";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Dock = DockStyle.Left;
            button6.Location = new Point(942, 0);
            button6.Name = "button6";
            button6.Size = new Size(156, 131);
            button6.TabIndex = 8;
            button6.Text = "Identificar si el tipo de dato de clave primaria y foránea son compatibles";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Dock = DockStyle.Left;
            button7.Location = new Point(92, 0);
            button7.Name = "button7";
            button7.Size = new Size(104, 131);
            button7.TabIndex = 9;
            button7.Text = "Revisar nulos en foreign keys";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Dock = DockStyle.Left;
            button8.Location = new Point(0, 0);
            button8.Name = "button8";
            button8.Size = new Size(92, 131);
            button8.TabIndex = 10;
            button8.Text = "Valores Repetidos";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.Dock = DockStyle.Left;
            button9.Location = new Point(399, 0);
            button9.Name = "button9";
            button9.Size = new Size(108, 131);
            button9.TabIndex = 11;
            button9.Text = "Revisar claves foráneas desactivadas";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // button10
            // 
            button10.Dock = DockStyle.Left;
            button10.Location = new Point(631, 0);
            button10.Name = "button10";
            button10.Size = new Size(112, 131);
            button10.TabIndex = 12;
            button10.Text = "Verificar anomalías no detectadas por DBCC";
            button10.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            button11.Dock = DockStyle.Left;
            button11.Location = new Point(848, 0);
            button11.Name = "button11";
            button11.Size = new Size(94, 131);
            button11.TabIndex = 13;
            button11.Text = "Revisar anomalias con triggers";
            button11.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            button12.Dock = DockStyle.Left;
            button12.Location = new Point(1098, 0);
            button12.Name = "button12";
            button12.Size = new Size(120, 131);
            button12.TabIndex = 14;
            button12.Text = "Revisar integridad referencial con triggers";
            button12.UseVisualStyleBackColor = true;
            button12.Click += button12_Click;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.None;
            panel2.Controls.Add(button1);
            panel2.Controls.Add(button12);
            panel2.Controls.Add(button6);
            panel2.Controls.Add(button11);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button10);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button9);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(button5);
            panel2.Controls.Add(button7);
            panel2.Controls.Add(button8);
            panel2.Location = new Point(262, 44);
            panel2.Name = "panel2";
            panel2.Size = new Size(1333, 131);
            panel2.TabIndex = 15;
            // 
            // MainPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1864, 835);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainPage";
            Text = "Auditoría de Bases de datos";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel2.ResumeLayout(false);
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
        private Button button10;
        private Button button11;
        private Button button12;
        private Panel panel2;
    }
}
