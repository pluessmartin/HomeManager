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
            // 
            // txtPasswort
            // 
            txtPasswort.Location = new Point(172, 134);
            txtPasswort.Name = "txtPasswort";
            txtPasswort.PasswordChar = '*';
            txtPasswort.Size = new Size(218, 23);
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}
