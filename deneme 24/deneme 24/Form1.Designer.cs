namespace deneme_24
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
            this.ilksayı = new System.Windows.Forms.Label();
            this.sonsayı = new System.Windows.Forms.Label();
            this.işlemyap = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ilksayı
            // 
            this.ilksayı.AutoSize = true;
            this.ilksayı.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ilksayı.Location = new System.Drawing.Point(55, 43);
            this.ilksayı.Name = "ilksayı";
            this.ilksayı.Size = new System.Drawing.Size(79, 25);
            this.ilksayı.TabIndex = 0;
            this.ilksayı.Text = "İlk sayı";
            // 
            // sonsayı
            // 
            this.sonsayı.AutoSize = true;
            this.sonsayı.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sonsayı.Location = new System.Drawing.Point(55, 116);
            this.sonsayı.Name = "sonsayı";
            this.sonsayı.Size = new System.Drawing.Size(100, 25);
            this.sonsayı.TabIndex = 1;
            this.sonsayı.Text = "Son Sayı";
            // 
            // işlemyap
            // 
            this.işlemyap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.işlemyap.Location = new System.Drawing.Point(75, 191);
            this.işlemyap.Name = "işlemyap";
            this.işlemyap.Size = new System.Drawing.Size(108, 51);
            this.işlemyap.TabIndex = 2;
            this.işlemyap.Text = "İşlem Yap";
            this.işlemyap.UseVisualStyleBackColor = true;
            this.işlemyap.Click += new System.EventHandler(this.işlemyap_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(343, 24);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(144, 196);
            this.listBox1.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(164, 34);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(130, 43);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(164, 101);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(130, 40);
            this.textBox2.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 358);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.işlemyap);
            this.Controls.Add(this.sonsayı);
            this.Controls.Add(this.ilksayı);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ilksayı;
        private System.Windows.Forms.Label sonsayı;
        private System.Windows.Forms.Button işlemyap;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}

