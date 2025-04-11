namespace MapDrive
{
    partial class Form1
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
            btnVerbinden = new Button();
            txtPasswort = new TextBox();
            label1 = new Label();
            cbBenutzer = new ComboBox();
            label2 = new Label();
            cbPfad = new ComboBox();
            label3 = new Label();
            cbLaufwerke = new ComboBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // btnVerbinden
            // 
            btnVerbinden.Location = new Point(92, 197);
            btnVerbinden.Name = "btnVerbinden";
            btnVerbinden.Size = new Size(75, 23);
            btnVerbinden.TabIndex = 0;
            btnVerbinden.Text = "Verbinden";
            btnVerbinden.UseVisualStyleBackColor = true;
            btnVerbinden.Click += btnVerbinden_Click;
            // 
            // txtPasswort
            // 
            txtPasswort.Location = new Point(172, 134);
            txtPasswort.Name = "txtPasswort";
            txtPasswort.PasswordChar = '*';
            txtPasswort.Size = new Size(326, 23);
            txtPasswort.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(92, 140);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 2;
            label1.Text = "Passwort";
            label1.Click += label1_Click;
            // 
            // cbBenutzer
            // 
            cbBenutzer.FormattingEnabled = true;
            cbBenutzer.Items.AddRange(new object[] { "martin", "irene" });
            cbBenutzer.Location = new Point(173, 98);
            cbBenutzer.Name = "cbBenutzer";
            cbBenutzer.Size = new Size(325, 23);
            cbBenutzer.TabIndex = 3;
            cbBenutzer.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(92, 101);
            label2.Name = "label2";
            label2.Size = new Size(53, 15);
            label2.TabIndex = 4;
            label2.Text = "Benutzer";
            // 
            // cbPfad
            // 
            cbPfad.FormattingEnabled = true;
            cbPfad.Items.AddRange(new object[] { "\\\\PLUESS-SE1000\\Daten" });
            cbPfad.Location = new Point(173, 69);
            cbPfad.Name = "cbPfad";
            cbPfad.Size = new Size(325, 23);
            cbPfad.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(92, 72);
            label3.Name = "label3";
            label3.Size = new Size(31, 15);
            label3.TabIndex = 6;
            label3.Text = "Pfad";
            label3.Click += label3_Click;
            // 
            // cbLaufwerke
            // 
            cbLaufwerke.FormattingEnabled = true;
            cbLaufwerke.Items.AddRange(new object[] { "V", "W", "X", "Y" });
            cbLaufwerke.Location = new Point(173, 40);
            cbLaufwerke.Name = "cbLaufwerke";
            cbLaufwerke.Size = new Size(63, 23);
            cbLaufwerke.TabIndex = 7;
            cbLaufwerke.SelectedIndexChanged += comboBox3_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(92, 43);
            label4.Name = "label4";
            label4.Size = new Size(55, 15);
            label4.TabIndex = 8;
            label4.Text = "Laufwerk";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(cbLaufwerke);
            Controls.Add(label3);
            Controls.Add(cbPfad);
            Controls.Add(label2);
            Controls.Add(cbBenutzer);
            Controls.Add(label1);
            Controls.Add(txtPasswort);
            Controls.Add(btnVerbinden);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnVerbinden;
        private TextBox txtPasswort;
        private Label label1;
        private ComboBox cbBenutzer;
        private Label label2;
        private ComboBox cbPfad;
        private Label label3;
        private ComboBox cbLaufwerke;
        private Label label4;
    }
}
