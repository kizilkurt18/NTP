namespace FormSınıfı_Uygulaması
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
            this.btnShow = new System.Windows.Forms.Button();
            this.btnShowDialog = new System.Windows.Forms.Button();
            this.btnControlBox = new System.Windows.Forms.Button();
            this.btnCenter = new System.Windows.Forms.Button();
            this.btnGancel = new System.Windows.Forms.Button();
            this.btnAccept = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnShow
            // 
            this.btnShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnShow.Location = new System.Drawing.Point(523, 344);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(216, 48);
            this.btnShow.TabIndex = 11;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnShowDialog
            // 
            this.btnShowDialog.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnShowDialog.Location = new System.Drawing.Point(523, 431);
            this.btnShowDialog.Name = "btnShowDialog";
            this.btnShowDialog.Size = new System.Drawing.Size(216, 48);
            this.btnShowDialog.TabIndex = 10;
            this.btnShowDialog.Text = "ShowDialog";
            this.btnShowDialog.UseVisualStyleBackColor = true;
            this.btnShowDialog.Click += new System.EventHandler(this.btnShowDialog_Click);
            // 
            // btnControlBox
            // 
            this.btnControlBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnControlBox.Location = new System.Drawing.Point(523, 185);
            this.btnControlBox.Name = "btnControlBox";
            this.btnControlBox.Size = new System.Drawing.Size(216, 48);
            this.btnControlBox.TabIndex = 9;
            this.btnControlBox.Text = "ControlBox";
            this.btnControlBox.UseVisualStyleBackColor = true;
            this.btnControlBox.Click += new System.EventHandler(this.btnControlBox_Click);
            // 
            // btnCenter
            // 
            this.btnCenter.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCenter.Location = new System.Drawing.Point(523, 263);
            this.btnCenter.Name = "btnCenter";
            this.btnCenter.Size = new System.Drawing.Size(216, 48);
            this.btnCenter.TabIndex = 8;
            this.btnCenter.Text = "CenterToScreen";
            this.btnCenter.UseVisualStyleBackColor = true;
            this.btnCenter.Click += new System.EventHandler(this.btnCenter_Click);
            // 
            // btnGancel
            // 
            this.btnGancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGancel.Location = new System.Drawing.Point(523, 109);
            this.btnGancel.Name = "btnGancel";
            this.btnGancel.Size = new System.Drawing.Size(216, 48);
            this.btnGancel.TabIndex = 7;
            this.btnGancel.Text = "Gancel";
            this.btnGancel.UseVisualStyleBackColor = true;
            this.btnGancel.Click += new System.EventHandler(this.btnGancel_Click);
            // 
            // btnAccept
            // 
            this.btnAccept.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAccept.Location = new System.Drawing.Point(523, 41);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(216, 48);
            this.btnAccept.TabIndex = 6;
            this.btnAccept.Text = "Accept";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 538);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.btnShowDialog);
            this.Controls.Add(this.btnControlBox);
            this.Controls.Add(this.btnCenter);
            this.Controls.Add(this.btnGancel);
            this.Controls.Add(this.btnAccept);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnShowDialog;
        private System.Windows.Forms.Button btnControlBox;
        private System.Windows.Forms.Button btnCenter;
        private System.Windows.Forms.Button btnGancel;
        private System.Windows.Forms.Button btnAccept;
    }
}

