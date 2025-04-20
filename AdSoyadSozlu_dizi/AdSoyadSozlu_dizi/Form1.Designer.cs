namespace AdSoyadSozlu_dizi
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.listeNotlar = new System.Windows.Forms.ListBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnListele = new System.Windows.Forms.Button();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.txtNot1 = new System.Windows.Forms.TextBox();
            this.txtNot2 = new System.Windows.Forms.TextBox();
            this.txtNot4 = new System.Windows.Forms.TextBox();
            this.txtNot3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(138, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad Soyad = ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(139, 237);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Yazılı 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(280, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Yazılı 2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(557, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "Sözlü 2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(416, 237);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 24);
            this.label5.TabIndex = 3;
            this.label5.Text = "Sözlü 1";
            // 
            // listeNotlar
            // 
            this.listeNotlar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listeNotlar.FormattingEnabled = true;
            this.listeNotlar.ItemHeight = 25;
            this.listeNotlar.Location = new System.Drawing.Point(755, 75);
            this.listeNotlar.Name = "listeNotlar";
            this.listeNotlar.Size = new System.Drawing.Size(317, 304);
            this.listeNotlar.TabIndex = 5;
            // 
            // btnEkle
            // 
            this.btnEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.Location = new System.Drawing.Point(522, 87);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(96, 40);
            this.btnEkle.TabIndex = 6;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnListele
            // 
            this.btnListele.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnListele.Location = new System.Drawing.Point(755, 406);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(153, 71);
            this.btnListele.TabIndex = 7;
            this.btnListele.Text = "Listele";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAdSoyad.Location = new System.Drawing.Point(284, 93);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(105, 29);
            this.txtAdSoyad.TabIndex = 8;
            // 
            // txtNot1
            // 
            this.txtNot1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtNot1.Location = new System.Drawing.Point(143, 278);
            this.txtNot1.Name = "txtNot1";
            this.txtNot1.Size = new System.Drawing.Size(72, 29);
            this.txtNot1.TabIndex = 9;
            // 
            // txtNot2
            // 
            this.txtNot2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtNot2.Location = new System.Drawing.Point(284, 278);
            this.txtNot2.Name = "txtNot2";
            this.txtNot2.Size = new System.Drawing.Size(72, 29);
            this.txtNot2.TabIndex = 10;
            // 
            // txtNot4
            // 
            this.txtNot4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtNot4.Location = new System.Drawing.Point(561, 278);
            this.txtNot4.Name = "txtNot4";
            this.txtNot4.Size = new System.Drawing.Size(72, 29);
            this.txtNot4.TabIndex = 12;
            // 
            // txtNot3
            // 
            this.txtNot3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtNot3.Location = new System.Drawing.Point(420, 278);
            this.txtNot3.Name = "txtNot3";
            this.txtNot3.Size = new System.Drawing.Size(72, 29);
            this.txtNot3.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 539);
            this.Controls.Add(this.txtNot4);
            this.Controls.Add(this.txtNot3);
            this.Controls.Add(this.txtNot2);
            this.Controls.Add(this.txtNot1);
            this.Controls.Add(this.txtAdSoyad);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.listeNotlar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox listeNotlar;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.TextBox txtNot1;
        private System.Windows.Forms.TextBox txtNot2;
        private System.Windows.Forms.TextBox txtNot4;
        private System.Windows.Forms.TextBox txtNot3;
    }
}

