namespace list_ornek1
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
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnListele = new System.Windows.Forms.Button();
            this.btnSirala = new System.Windows.Forms.Button();
            this.btnElemanSayisi = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.txtOgrenci = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(310, 32);
            this.btnEkle.Margin = new System.Windows.Forms.Padding(6);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(138, 42);
            this.btnEkle.TabIndex = 0;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnListele
            // 
            this.btnListele.Location = new System.Drawing.Point(460, 32);
            this.btnListele.Margin = new System.Windows.Forms.Padding(6);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(138, 42);
            this.btnListele.TabIndex = 1;
            this.btnListele.Text = "LİSTELE";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // btnSirala
            // 
            this.btnSirala.Location = new System.Drawing.Point(310, 94);
            this.btnSirala.Margin = new System.Windows.Forms.Padding(6);
            this.btnSirala.Name = "btnSirala";
            this.btnSirala.Size = new System.Drawing.Size(138, 42);
            this.btnSirala.TabIndex = 2;
            this.btnSirala.Text = "SIRALA";
            this.btnSirala.UseVisualStyleBackColor = true;
            this.btnSirala.Click += new System.EventHandler(this.btnSirala_Click);
            // 
            // btnElemanSayisi
            // 
            this.btnElemanSayisi.Location = new System.Drawing.Point(310, 148);
            this.btnElemanSayisi.Margin = new System.Windows.Forms.Padding(6);
            this.btnElemanSayisi.Name = "btnElemanSayisi";
            this.btnElemanSayisi.Size = new System.Drawing.Size(138, 69);
            this.btnElemanSayisi.TabIndex = 3;
            this.btnElemanSayisi.Text = "ELEMAN SAYISI";
            this.btnElemanSayisi.UseVisualStyleBackColor = true;
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(460, 94);
            this.btnSil.Margin = new System.Windows.Forms.Padding(6);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(138, 42);
            this.btnSil.TabIndex = 4;
            this.btnSil.Text = "SİL";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(460, 148);
            this.btnTemizle.Margin = new System.Windows.Forms.Padding(6);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(139, 53);
            this.btnTemizle.TabIndex = 5;
            this.btnTemizle.Text = "TEMİZLE";
            this.btnTemizle.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 24;
            this.listBox1.Location = new System.Drawing.Point(103, 94);
            this.listBox1.Margin = new System.Windows.Forms.Padding(6);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(195, 340);
            this.listBox1.TabIndex = 6;
            // 
            // txtOgrenci
            // 
            this.txtOgrenci.Location = new System.Drawing.Point(124, 32);
            this.txtOgrenci.Margin = new System.Windows.Forms.Padding(6);
            this.txtOgrenci.Name = "txtOgrenci";
            this.txtOgrenci.Size = new System.Drawing.Size(174, 29);
            this.txtOgrenci.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "Öğrenci Adı:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 469);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtOgrenci);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnElemanSayisi);
            this.Controls.Add(this.btnSirala);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.btnEkle);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.Button btnSirala;
        private System.Windows.Forms.Button btnElemanSayisi;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox txtOgrenci;
        private System.Windows.Forms.Label label1;
    }
}

