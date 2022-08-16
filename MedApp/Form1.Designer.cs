
namespace MedApp
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pacintiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.diagnosticToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rapoarteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.graficDiagnosticeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tbMess = new System.Windows.Forms.TextBox();
            this.lvProgramari = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnCasierie = new System.Windows.Forms.Button();
            this.btnAchita = new System.Windows.Forms.Button();
            this.lbNumePacient = new System.Windows.Forms.Label();
            this.cbCostFinal = new System.Windows.Forms.ComboBox();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.ratingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.dateToolStripMenuItem,
            this.rapoarteToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1028, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.printToolStripMenuItem,
            this.openToolStripMenuItem,
            this.ratingToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(54, 29);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.printToolStripMenuItem.Text = "Print";
            this.printToolStripMenuItem.Click += new System.EventHandler(this.printToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // dateToolStripMenuItem
            // 
            this.dateToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pacintiToolStripMenuItem,
            this.diagnosticToolStripMenuItem});
            this.dateToolStripMenuItem.Name = "dateToolStripMenuItem";
            this.dateToolStripMenuItem.Size = new System.Drawing.Size(65, 32);
            this.dateToolStripMenuItem.Text = "Date";
            // 
            // pacintiToolStripMenuItem
            // 
            this.pacintiToolStripMenuItem.Name = "pacintiToolStripMenuItem";
            this.pacintiToolStripMenuItem.Size = new System.Drawing.Size(198, 34);
            this.pacintiToolStripMenuItem.Text = "Pacienti";
            this.pacintiToolStripMenuItem.Click += new System.EventHandler(this.pacientiToolStripMenuItem_Click);
            // 
            // diagnosticToolStripMenuItem
            // 
            this.diagnosticToolStripMenuItem.Name = "diagnosticToolStripMenuItem";
            this.diagnosticToolStripMenuItem.Size = new System.Drawing.Size(198, 34);
            this.diagnosticToolStripMenuItem.Text = "Diagnostic";
            this.diagnosticToolStripMenuItem.Click += new System.EventHandler(this.diagnosticToolStripMenuItem_Click);
            // 
            // rapoarteToolStripMenuItem
            // 
            this.rapoarteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.graficDiagnosticeToolStripMenuItem});
            this.rapoarteToolStripMenuItem.Name = "rapoarteToolStripMenuItem";
            this.rapoarteToolStripMenuItem.Size = new System.Drawing.Size(100, 32);
            this.rapoarteToolStripMenuItem.Text = "Rapoarte";
            // 
            // graficDiagnosticeToolStripMenuItem
            // 
            this.graficDiagnosticeToolStripMenuItem.Name = "graficDiagnosticeToolStripMenuItem";
            this.graficDiagnosticeToolStripMenuItem.Size = new System.Drawing.Size(255, 34);
            this.graficDiagnosticeToolStripMenuItem.Text = "Grafic diagnostice";
            this.graficDiagnosticeToolStripMenuItem.Click += new System.EventHandler(this.graficDiagnosticeToolStripMenuItem_Click);
            // 
            // tbMess
            // 
            this.tbMess.BackColor = System.Drawing.Color.Teal;
            this.tbMess.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tbMess.Location = new System.Drawing.Point(0, 378);
            this.tbMess.Multiline = true;
            this.tbMess.Name = "tbMess";
            this.tbMess.ReadOnly = true;
            this.tbMess.Size = new System.Drawing.Size(1028, 181);
            this.tbMess.TabIndex = 1;
            // 
            // lvProgramari
            // 
            this.lvProgramari.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvProgramari.GridLines = true;
            this.lvProgramari.HideSelection = false;
            this.lvProgramari.Location = new System.Drawing.Point(580, 58);
            this.lvProgramari.Name = "lvProgramari";
            this.lvProgramari.Size = new System.Drawing.Size(436, 301);
            this.lvProgramari.TabIndex = 2;
            this.lvProgramari.UseCompatibleStateImageBehavior = false;
            this.lvProgramari.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Data Programarii";
            this.columnHeader1.Width = 134;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nume Pacient";
            this.columnHeader2.Width = 112;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Cost Serviciu";
            this.columnHeader3.Width = 111;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Facturat";
            this.columnHeader4.Width = 74;
            // 
            // btnCasierie
            // 
            this.btnCasierie.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnCasierie.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCasierie.Location = new System.Drawing.Point(12, 315);
            this.btnCasierie.Name = "btnCasierie";
            this.btnCasierie.Size = new System.Drawing.Size(118, 44);
            this.btnCasierie.TabIndex = 3;
            this.btnCasierie.Text = "Casierie";
            this.btnCasierie.UseVisualStyleBackColor = false;
            this.btnCasierie.Click += new System.EventHandler(this.btnCasierie_Click);
            // 
            // btnAchita
            // 
            this.btnAchita.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnAchita.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAchita.Location = new System.Drawing.Point(358, 314);
            this.btnAchita.Name = "btnAchita";
            this.btnAchita.Size = new System.Drawing.Size(128, 45);
            this.btnAchita.TabIndex = 4;
            this.btnAchita.Text = "Achita";
            this.btnAchita.UseVisualStyleBackColor = false;
            this.btnAchita.Visible = false;
            this.btnAchita.Click += new System.EventHandler(this.btnAchita_Click);
            // 
            // lbNumePacient
            // 
            this.lbNumePacient.AutoSize = true;
            this.lbNumePacient.Location = new System.Drawing.Point(136, 301);
            this.lbNumePacient.Name = "lbNumePacient";
            this.lbNumePacient.Size = new System.Drawing.Size(108, 20);
            this.lbNumePacient.TabIndex = 5;
            this.lbNumePacient.Text = "Nume Pacient";
            this.lbNumePacient.Visible = false;
            // 
            // cbCostFinal
            // 
            this.cbCostFinal.FormattingEnabled = true;
            this.cbCostFinal.Location = new System.Drawing.Point(136, 324);
            this.cbCostFinal.Name = "cbCostFinal";
            this.cbCostFinal.Size = new System.Drawing.Size(216, 28);
            this.cbCostFinal.TabIndex = 6;
            this.cbCostFinal.Visible = false;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // ratingToolStripMenuItem
            // 
            this.ratingToolStripMenuItem.Name = "ratingToolStripMenuItem";
            this.ratingToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.ratingToolStripMenuItem.Text = "Rating";
            this.ratingToolStripMenuItem.Click += new System.EventHandler(this.ratingToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 559);
            this.Controls.Add(this.cbCostFinal);
            this.Controls.Add(this.lbNumePacient);
            this.Controls.Add(this.btnAchita);
            this.Controls.Add(this.btnCasierie);
            this.Controls.Add(this.lvProgramari);
            this.Controls.Add(this.tbMess);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pacintiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem diagnosticToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rapoarteToolStripMenuItem;
        private System.Windows.Forms.TextBox tbMess;
        private System.Windows.Forms.ListView lvProgramari;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button btnCasierie;
        private System.Windows.Forms.Button btnAchita;
        private System.Windows.Forms.Label lbNumePacient;
        private System.Windows.Forms.ComboBox cbCostFinal;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        public System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ToolStripMenuItem graficDiagnosticeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ratingToolStripMenuItem;
    }
}

