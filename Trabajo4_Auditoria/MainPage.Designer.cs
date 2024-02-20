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
            dataResultsGridTable = new DataGridView();
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
            ((System.ComponentModel.ISupportInitialize)dataResultsGridTable).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dataResultsGridTable
            // 
            dataResultsGridTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataResultsGridTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataResultsGridTable.Dock = DockStyle.Bottom;
            dataResultsGridTable.Location = new Point(0, 211);
            dataResultsGridTable.Name = "dataResultsGridTable";
            dataResultsGridTable.RowHeadersWidth = 51;
            dataResultsGridTable.Size = new Size(1090, 450);
            dataResultsGridTable.TabIndex = 0;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { archivoToolStripMenuItem, verToolStripMenuItem, guardarToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1090, 28);
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
            button1.Location = new Point(153, 81);
            button1.Name = "button1";
            button1.Size = new Size(226, 51);
            button1.TabIndex = 2;
            button1.Text = "Identificar Integridad Referencial";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(471, 82);
            button2.Name = "button2";
            button2.Size = new Size(243, 50);
            button2.TabIndex = 3;
            button2.Text = "Chequear anomalías";
            button2.UseVisualStyleBackColor = true;
            button2.Click += this.button2_Click;
            // 
            // MainPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1090, 661);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataResultsGridTable);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainPage";
            Text = "Form1";
            Load += nuevaBDToolStripMenuItem_Click;
            ((System.ComponentModel.ISupportInitialize)dataResultsGridTable).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataResultsGridTable;
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
    }
}
