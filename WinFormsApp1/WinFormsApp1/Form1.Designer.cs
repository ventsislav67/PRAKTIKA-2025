namespace WinFormsApp1
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
            txtSastavka = new TextBox();
            btnDobavi = new Button();
            listBoxSastavki = new ListBox();
            btnSwari = new Button();
            lblReultat = new Label();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // txtSastavka
            // 
            txtSastavka.Location = new Point(233, 156);
            txtSastavka.Name = "txtSastavka";
            txtSastavka.Size = new Size(299, 27);
            txtSastavka.TabIndex = 0;
            // 
            // btnDobavi
            // 
            btnDobavi.BackColor = Color.Transparent;
            btnDobavi.FlatAppearance.BorderSize = 0;
            btnDobavi.Font = new Font("Segoe UI", 12F);
            btnDobavi.ForeColor = Color.SlateBlue;
            btnDobavi.Location = new Point(233, 210);
            btnDobavi.Name = "btnDobavi";
            btnDobavi.Size = new Size(94, 64);
            btnDobavi.TabIndex = 1;
            btnDobavi.Text = "добави";
            btnDobavi.UseVisualStyleBackColor = false;
            btnDobavi.Click += btnDobavi_Click_1;
            // 
            // listBoxSastavki
            // 
            listBoxSastavki.BackColor = Color.MediumPurple;
            listBoxSastavki.Font = new Font("Showcard Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            listBoxSastavki.ForeColor = Color.Black;
            listBoxSastavki.FormattingEnabled = true;
            listBoxSastavki.ItemHeight = 18;
            listBoxSastavki.Location = new Point(669, 210);
            listBoxSastavki.Name = "listBoxSastavki";
            listBoxSastavki.Size = new Size(218, 40);
            listBoxSastavki.TabIndex = 2;
            // 
            // btnSwari
            // 
            btnSwari.BackColor = Color.Transparent;
            btnSwari.Font = new Font("Segoe UI", 12F);
            btnSwari.ForeColor = Color.SlateBlue;
            btnSwari.Location = new Point(438, 210);
            btnSwari.Name = "btnSwari";
            btnSwari.Size = new Size(94, 64);
            btnSwari.TabIndex = 3;
            btnSwari.Text = "свари";
            btnSwari.UseVisualStyleBackColor = false;
            btnSwari.Click += btnSwari_Click_1;
            // 
            // lblReultat
            // 
            lblReultat.AutoSize = true;
            lblReultat.BackColor = Color.Transparent;
            lblReultat.Font = new Font("Showcard Gothic", 16F);
            lblReultat.Location = new Point(214, 83);
            lblReultat.Name = "lblReultat";
            lblReultat.Size = new Size(104, 33);
            lblReultat.TabIndex = 4;
            lblReultat.Text = "label1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Showcard Gothic", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(409, 9);
            label1.Name = "label1";
            label1.Size = new Size(360, 31);
            label1.TabIndex = 5;
            label1.Text = "Създай своята отвара сега";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(648, 156);
            label2.Name = "label2";
            label2.Size = new Size(261, 29);
            label2.TabIndex = 6;
            label2.Text = "Списък на елементи";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SlateBlue;
            BackgroundImage = Properties.Resources.dark_magic_exlp6w1wrf3fe73i;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1092, 745);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblReultat);
            Controls.Add(btnSwari);
            Controls.Add(listBoxSastavki);
            Controls.Add(btnDobavi);
            Controls.Add(txtSastavka);
            ForeColor = Color.Transparent;
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSastavka;
        private Button btnDobavi;
        private ListBox listBoxSastavki;
        private Button btnSwari;
        private Label lblReultat;
        private Label label1;
        private Label label2;
    }
}
