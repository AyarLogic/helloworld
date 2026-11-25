namespace bpOgrenciKayit
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
            labAd = new Label();
            labSoyad = new Label();
            labBolumu = new Label();
            txtAdi = new TextBox();
            txtSoyadi = new TextBox();
            butEkle = new Button();
            button2 = new Button();
            cmbBolum = new ComboBox();
            dvgOgrencilerX = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dvgOgrencilerX).BeginInit();
            SuspendLayout();
            // 
            // labAd
            // 
            labAd.AutoSize = true;
            labAd.Location = new Point(86, 50);
            labAd.Name = "labAd";
            labAd.Size = new Size(28, 20);
            labAd.TabIndex = 0;
            labAd.Text = "Ad";
            // 
            // labSoyad
            // 
            labSoyad.AutoSize = true;
            labSoyad.Location = new Point(86, 108);
            labSoyad.Name = "labSoyad";
            labSoyad.Size = new Size(50, 20);
            labSoyad.TabIndex = 1;
            labSoyad.Text = "Soyad";
            // 
            // labBolumu
            // 
            labBolumu.AutoSize = true;
            labBolumu.Location = new Point(86, 171);
            labBolumu.Name = "labBolumu";
            labBolumu.Size = new Size(60, 20);
            labBolumu.TabIndex = 2;
            labBolumu.Text = "Bölümü";
            // 
            // txtAdi
            // 
            txtAdi.Location = new Point(207, 50);
            txtAdi.Name = "txtAdi";
            txtAdi.Size = new Size(125, 27);
            txtAdi.TabIndex = 3;
            // 
            // txtSoyadi
            // 
            txtSoyadi.Location = new Point(207, 108);
            txtSoyadi.Name = "txtSoyadi";
            txtSoyadi.Size = new Size(125, 27);
            txtSoyadi.TabIndex = 4;
            // 
            // butEkle
            // 
            butEkle.Location = new Point(446, 171);
            butEkle.Name = "butEkle";
            butEkle.Size = new Size(94, 29);
            butEkle.TabIndex = 6;
            butEkle.Text = "Ekle";
            butEkle.UseVisualStyleBackColor = true;
            butEkle.Click += butEkle_Click_1;
            // 
            // button2
            // 
            button2.Location = new Point(611, 171);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 7;
            button2.Text = "Sil";
            button2.UseVisualStyleBackColor = true;
            // 
            // cmbBolum
            // 
            cmbBolum.FormattingEnabled = true;
            cmbBolum.Items.AddRange(new object[] { "Bilgisayar Programcılığı", "Bilgisayar Mühendisliği", "Hukuk", "Mimarlık", "Elektrik elektronik müh." });
            cmbBolum.Location = new Point(207, 171);
            cmbBolum.Name = "cmbBolum";
            cmbBolum.Size = new Size(151, 28);
            cmbBolum.TabIndex = 8;
            // 
            // dvgOgrencilerX
            // 
            dvgOgrencilerX.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgOgrencilerX.Location = new Point(86, 231);
            dvgOgrencilerX.Name = "dvgOgrencilerX";
            dvgOgrencilerX.RowHeadersWidth = 51;
            dvgOgrencilerX.Size = new Size(619, 190);
            dvgOgrencilerX.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dvgOgrencilerX);
            Controls.Add(cmbBolum);
            Controls.Add(button2);
            Controls.Add(butEkle);
            Controls.Add(txtSoyadi);
            Controls.Add(txtAdi);
            Controls.Add(labBolumu);
            Controls.Add(labSoyad);
            Controls.Add(labAd);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dvgOgrencilerX).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labAd;
        private Label labSoyad;
        private Label labBolumu;
        private TextBox txtAdi;
        private TextBox txtSoyadi;
        private Button butEkle;
        private Button button2;
        private ComboBox cmbBolum;
        private DataGridView dvgOgrencilerX;
    }
}
