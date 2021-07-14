namespace Millionaire
{
    partial class MainWindow
    {
        /// <summary>
        /// gerekli tasarım değişkenlerinin olduğu kısım
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// protected override  
        /// </summary>
        /// <param name="disposing">yönetilen kaynakların atılması gerekiyorsa true yoksa false döndürür </param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer 

     
   
        private void InitializeComponent()
        {
            this.pictureBoxBG = new System.Windows.Forms.PictureBox();
            this.pictureBox5050 = new System.Windows.Forms.PictureBox();
            this.pictureBoxTelefonJokeri = new System.Windows.Forms.PictureBox();
            this.pictureBoxPesEtme = new System.Windows.Forms.PictureBox();
            this.pictureBoxPara = new System.Windows.Forms.PictureBox();
            this.labelSoru = new System.Windows.Forms.Label();
            this.labelA = new System.Windows.Forms.Label();
            this.labelB = new System.Windows.Forms.Label();
            this.labelC = new System.Windows.Forms.Label();
            this.labelD = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBoxPlay = new System.Windows.Forms.PictureBox();
            this.buttonBilgilendirme = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5050)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTelefonJokeri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPesEtme)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPara)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlay)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxBG
            // 
            this.pictureBoxBG.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxBG.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxBG.Image = global::Millionaire.Properties.Resources.Soru_Arkaplan1;
            this.pictureBoxBG.Location = new System.Drawing.Point(72, 50);
            this.pictureBoxBG.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxBG.Name = "pictureBoxBG";
            this.pictureBoxBG.Size = new System.Drawing.Size(951, 450);
            this.pictureBoxBG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBG.TabIndex = 0;
            this.pictureBoxBG.TabStop = false;
            this.pictureBoxBG.Visible = false;
            // 
            // pictureBox5050
            // 
            this.pictureBox5050.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox5050.Image = global::Millionaire.Properties.Resources._50_50;
            this.pictureBox5050.Location = new System.Drawing.Point(7, 22);
            this.pictureBox5050.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox5050.Name = "pictureBox5050";
            this.pictureBox5050.Size = new System.Drawing.Size(107, 98);
            this.pictureBox5050.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5050.TabIndex = 1;
            this.pictureBox5050.TabStop = false;
            this.pictureBox5050.Click += new System.EventHandler(this.pictureBox5050_Click);
            // 
            // pictureBoxTelefonJokeri
            // 
            this.pictureBoxTelefonJokeri.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxTelefonJokeri.Image = global::Millionaire.Properties.Resources.telefon_jokeri;
            this.pictureBoxTelefonJokeri.Location = new System.Drawing.Point(117, 22);
            this.pictureBoxTelefonJokeri.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxTelefonJokeri.Name = "pictureBoxTelefonJokeri";
            this.pictureBoxTelefonJokeri.Size = new System.Drawing.Size(107, 98);
            this.pictureBoxTelefonJokeri.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxTelefonJokeri.TabIndex = 2;
            this.pictureBoxTelefonJokeri.TabStop = false;
            this.pictureBoxTelefonJokeri.Click += new System.EventHandler(this.pictureBoxTelefonJokeri_Click);
            // 
            // pictureBoxPesEtme
            // 
            this.pictureBoxPesEtme.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxPesEtme.Image = global::Millionaire.Properties.Resources.Pes_etme;
            this.pictureBoxPesEtme.Location = new System.Drawing.Point(229, 22);
            this.pictureBoxPesEtme.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxPesEtme.Name = "pictureBoxPesEtme";
            this.pictureBoxPesEtme.Size = new System.Drawing.Size(107, 98);
            this.pictureBoxPesEtme.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPesEtme.TabIndex = 3;
            this.pictureBoxPesEtme.TabStop = false;
            this.pictureBoxPesEtme.Click += new System.EventHandler(this.pictureBoxWalkAway_Click);
            // 
            // pictureBoxPara
            // 
            this.pictureBoxPara.BackgroundImage = global::Millionaire.Properties.Resources.soru_11;
            this.pictureBoxPara.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxPara.Location = new System.Drawing.Point(747, 84);
            this.pictureBoxPara.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxPara.Name = "pictureBoxPara";
            this.pictureBoxPara.Size = new System.Drawing.Size(264, 409);
            this.pictureBoxPara.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPara.TabIndex = 5;
            this.pictureBoxPara.TabStop = false;
            this.pictureBoxPara.Visible = false;
            this.pictureBoxPara.Click += new System.EventHandler(this.pictureBoxPara_Click);
            // 
            // labelSoru
            // 
            this.labelSoru.AutoSize = true;
            this.labelSoru.BackColor = System.Drawing.Color.Transparent;
            this.labelSoru.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSoru.ForeColor = System.Drawing.Color.Transparent;
            this.labelSoru.Image = global::Millionaire.Properties.Resources.Soru_Arkaplan;
            this.labelSoru.Location = new System.Drawing.Point(210, 300);
            this.labelSoru.Name = "labelSoru";
            this.labelSoru.Size = new System.Drawing.Size(196, 17);
            this.labelSoru.TabIndex = 6;
            this.labelSoru.Text = "Görsel Programlama Final";
            this.labelSoru.Visible = false;
            // 
            // labelA
            // 
            this.labelA.AutoSize = true;
            this.labelA.BackColor = System.Drawing.Color.Transparent;
            this.labelA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelA.ForeColor = System.Drawing.Color.Transparent;
            this.labelA.Image = global::Millionaire.Properties.Resources.Soru_Arkaplan;
            this.labelA.Location = new System.Drawing.Point(232, 382);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(22, 20);
            this.labelA.TabIndex = 7;
            this.labelA.Text = "B";
            this.labelA.Visible = false;
            this.labelA.Click += new System.EventHandler(this.labelA_Click);
            // 
            // labelB
            // 
            this.labelB.AutoSize = true;
            this.labelB.BackColor = System.Drawing.Color.Transparent;
            this.labelB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelB.ForeColor = System.Drawing.Color.Transparent;
            this.labelB.Image = global::Millionaire.Properties.Resources.Soru_Arkaplan;
            this.labelB.Location = new System.Drawing.Point(501, 382);
            this.labelB.Name = "labelB";
            this.labelB.Size = new System.Drawing.Size(21, 20);
            this.labelB.TabIndex = 8;
            this.labelB.Text = "A";
            this.labelB.Visible = false;
            this.labelB.Click += new System.EventHandler(this.labelB_Click);
            // 
            // labelC
            // 
            this.labelC.AutoSize = true;
            this.labelC.BackColor = System.Drawing.Color.Transparent;
            this.labelC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelC.ForeColor = System.Drawing.Color.Transparent;
            this.labelC.Image = global::Millionaire.Properties.Resources.Soru_Arkaplan;
            this.labelC.Location = new System.Drawing.Point(232, 441);
            this.labelC.Name = "labelC";
            this.labelC.Size = new System.Drawing.Size(116, 20);
            this.labelC.TabIndex = 9;
            this.labelC.Text = "Aslı Karaçalı";
            this.labelC.Visible = false;
            this.labelC.Click += new System.EventHandler(this.labelC_Click);
            // 
            // labelD
            // 
            this.labelD.AutoSize = true;
            this.labelD.BackColor = System.Drawing.Color.Transparent;
            this.labelD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelD.ForeColor = System.Drawing.Color.Transparent;
            this.labelD.Image = global::Millionaire.Properties.Resources.Soru_Arkaplan;
            this.labelD.Location = new System.Drawing.Point(501, 441);
            this.labelD.Name = "labelD";
            this.labelD.Size = new System.Drawing.Size(129, 20);
            this.labelD.TabIndex = 10;
            this.labelD.Text = "201713709018";
            this.labelD.Visible = false;
            this.labelD.Click += new System.EventHandler(this.labelD_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.MidnightBlue;
            this.groupBox1.BackgroundImage = global::Millionaire.Properties.Resources.Soru_Arkaplan1;
            this.groupBox1.Controls.Add(this.pictureBox5050);
            this.groupBox1.Controls.Add(this.pictureBoxTelefonJokeri);
            this.groupBox1.Controls.Add(this.pictureBoxPesEtme);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(397, 84);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(343, 127);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "JOKERLER";
            this.groupBox1.Visible = false;
            // 
            // pictureBoxPlay
            // 
            this.pictureBoxPlay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxPlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxPlay.Image = global::Millionaire.Properties.Resources.playbutton1;
            this.pictureBoxPlay.Location = new System.Drawing.Point(436, 245);
            this.pictureBoxPlay.Name = "pictureBoxPlay";
            this.pictureBoxPlay.Size = new System.Drawing.Size(200, 100);
            this.pictureBoxPlay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPlay.TabIndex = 12;
            this.pictureBoxPlay.TabStop = false;
            this.pictureBoxPlay.Click += new System.EventHandler(this.pictureBoxPlay_Click);
            // 
            // buttonBilgilendirme
            // 
            this.buttonBilgilendirme.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonBilgilendirme.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBilgilendirme.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBilgilendirme.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonBilgilendirme.Location = new System.Drawing.Point(92, 71);
            this.buttonBilgilendirme.Name = "buttonBilgilendirme";
            this.buttonBilgilendirme.Size = new System.Drawing.Size(125, 44);
            this.buttonBilgilendirme.TabIndex = 13;
            this.buttonBilgilendirme.Text = "Bilgilendirme";
            this.buttonBilgilendirme.UseVisualStyleBackColor = false;
            this.buttonBilgilendirme.Visible = false;
            this.buttonBilgilendirme.Click += new System.EventHandler(this.buttonBilgilendirme_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Millionaire.Properties.Resources.Ana_Arkaplan1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1083, 553);
            this.Controls.Add(this.buttonBilgilendirme);
            this.Controls.Add(this.pictureBoxPlay);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelD);
            this.Controls.Add(this.labelC);
            this.Controls.Add(this.labelB);
            this.Controls.Add(this.labelA);
            this.Controls.Add(this.labelSoru);
            this.Controls.Add(this.pictureBoxPara);
            this.Controls.Add(this.pictureBoxBG);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainWindow";
            this.Text = "KİM MİLYONER OLMAK İSTER - Aslı Karaçalı 201713709018";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5050)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTelefonJokeri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPesEtme)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPara)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxBG;
        private System.Windows.Forms.PictureBox pictureBox5050;
        private System.Windows.Forms.PictureBox pictureBoxTelefonJokeri;
        private System.Windows.Forms.PictureBox pictureBoxPesEtme;
        private System.Windows.Forms.PictureBox pictureBoxPara;
        private System.Windows.Forms.Label labelSoru;
        private System.Windows.Forms.Label labelA;
        private System.Windows.Forms.Label labelB;
        private System.Windows.Forms.Label labelC;
        private System.Windows.Forms.Label labelD;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBoxPlay;
        private System.Windows.Forms.Button buttonBilgilendirme;
    }
}

