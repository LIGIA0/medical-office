
namespace MedApp
{
    partial class Form3
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
            this.lbNume = new System.Windows.Forms.Label();
            this.lbSimptome = new System.Windows.Forms.Label();
            this.lbBoala = new System.Windows.Forms.Label();
            this.lbMedicamentatie = new System.Windows.Forms.Label();
            this.btnReteta = new System.Windows.Forms.Button();
            this.tbMedicamentatie = new System.Windows.Forms.RichTextBox();
            this.btnRenunta = new System.Windows.Forms.Button();
            this.tbSimptome = new System.Windows.Forms.TextBox();
            this.tbNume = new System.Windows.Forms.TextBox();
            this.cbBoala = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lbNume
            // 
            this.lbNume.AutoSize = true;
            this.lbNume.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbNume.Location = new System.Drawing.Point(71, 54);
            this.lbNume.Name = "lbNume";
            this.lbNume.Size = new System.Drawing.Size(122, 22);
            this.lbNume.TabIndex = 0;
            this.lbNume.Text = "Nume Pacient";
            // 
            // lbSimptome
            // 
            this.lbSimptome.AutoSize = true;
            this.lbSimptome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbSimptome.Location = new System.Drawing.Point(71, 105);
            this.lbSimptome.Name = "lbSimptome";
            this.lbSimptome.Size = new System.Drawing.Size(89, 22);
            this.lbSimptome.TabIndex = 2;
            this.lbSimptome.Text = "Simptome";
            // 
            // lbBoala
            // 
            this.lbBoala.AutoSize = true;
            this.lbBoala.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbBoala.Location = new System.Drawing.Point(71, 163);
            this.lbBoala.Name = "lbBoala";
            this.lbBoala.Size = new System.Drawing.Size(56, 22);
            this.lbBoala.TabIndex = 3;
            this.lbBoala.Text = "Boala";
            // 
            // lbMedicamentatie
            // 
            this.lbMedicamentatie.AutoSize = true;
            this.lbMedicamentatie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbMedicamentatie.Location = new System.Drawing.Point(71, 219);
            this.lbMedicamentatie.Name = "lbMedicamentatie";
            this.lbMedicamentatie.Size = new System.Drawing.Size(135, 22);
            this.lbMedicamentatie.TabIndex = 4;
            this.lbMedicamentatie.Text = "Medicamentatie";
            // 
            // btnReteta
            // 
            this.btnReteta.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnReteta.Location = new System.Drawing.Point(624, 485);
            this.btnReteta.Name = "btnReteta";
            this.btnReteta.Size = new System.Drawing.Size(130, 57);
            this.btnReteta.TabIndex = 5;
            this.btnReteta.Text = "Reteta";
            this.btnReteta.UseVisualStyleBackColor = true;
            // 
            // tbMedicamentatie
            // 
            this.tbMedicamentatie.Location = new System.Drawing.Point(257, 219);
            this.tbMedicamentatie.Name = "tbMedicamentatie";
            this.tbMedicamentatie.Size = new System.Drawing.Size(272, 148);
            this.tbMedicamentatie.TabIndex = 10;
            this.tbMedicamentatie.Text = "";
            // 
            // btnRenunta
            // 
            this.btnRenunta.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnRenunta.Location = new System.Drawing.Point(775, 485);
            this.btnRenunta.Name = "btnRenunta";
            this.btnRenunta.Size = new System.Drawing.Size(123, 57);
            this.btnRenunta.TabIndex = 11;
            this.btnRenunta.Text = "Renunta";
            this.btnRenunta.UseVisualStyleBackColor = true;
            // 
            // tbSimptome
            // 
            this.tbSimptome.Location = new System.Drawing.Point(257, 104);
            this.tbSimptome.Multiline = true;
            this.tbSimptome.Name = "tbSimptome";
            this.tbSimptome.Size = new System.Drawing.Size(272, 26);
            this.tbSimptome.TabIndex = 12;
            // 
            // tbNume
            // 
            this.tbNume.Location = new System.Drawing.Point(257, 54);
            this.tbNume.Name = "tbNume";
            this.tbNume.Size = new System.Drawing.Size(272, 26);
            this.tbNume.TabIndex = 14;
            // 
            // cbBoala
            // 
            this.cbBoala.FormattingEnabled = true;
            this.cbBoala.Items.AddRange(new object[] {
            "COVID-19",
            "Pojar",
            "Varicela",
            "Gripa",
            "Toxiinfectie alimentara",
            "Raceala",
            "Diabet",
            "Rujeola",
            "Cancer",
            "Depresie"});
            this.cbBoala.Location = new System.Drawing.Point(257, 156);
            this.cbBoala.Name = "cbBoala";
            this.cbBoala.Size = new System.Drawing.Size(272, 28);
            this.cbBoala.TabIndex = 15;
            // 
            // Form3
            // 
            this.AcceptButton = this.btnReteta;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.CancelButton = this.btnRenunta;
            this.ClientSize = new System.Drawing.Size(953, 575);
            this.Controls.Add(this.cbBoala);
            this.Controls.Add(this.tbNume);
            this.Controls.Add(this.tbSimptome);
            this.Controls.Add(this.btnRenunta);
            this.Controls.Add(this.tbMedicamentatie);
            this.Controls.Add(this.btnReteta);
            this.Controls.Add(this.lbMedicamentatie);
            this.Controls.Add(this.lbBoala);
            this.Controls.Add(this.lbSimptome);
            this.Controls.Add(this.lbNume);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNume;
        private System.Windows.Forms.Label lbSimptome;
        private System.Windows.Forms.Label lbBoala;
        private System.Windows.Forms.Label lbMedicamentatie;
        private System.Windows.Forms.Button btnReteta;
        private System.Windows.Forms.Button btnRenunta;
        public System.Windows.Forms.TextBox tbSimptome;
        public System.Windows.Forms.RichTextBox tbMedicamentatie;
        public System.Windows.Forms.TextBox tbNume;
        public System.Windows.Forms.ComboBox cbBoala;
    }
}