namespace RandomFace
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.generate_b = new System.Windows.Forms.Button();
            this.generatedImg = new System.Windows.Forms.PictureBox();
            this.link_site = new System.Windows.Forms.LinkLabel();
            this.save_b = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.generatedImg)).BeginInit();
            this.SuspendLayout();
            // 
            // generate_b
            // 
            this.generate_b.Location = new System.Drawing.Point(287, 245);
            this.generate_b.Name = "generate_b";
            this.generate_b.Size = new System.Drawing.Size(75, 23);
            this.generate_b.TabIndex = 0;
            this.generate_b.Text = "Generate";
            this.generate_b.UseVisualStyleBackColor = true;
            this.generate_b.Click += new System.EventHandler(this.generate_b_Click);
            // 
            // generatedImg
            // 
            this.generatedImg.Location = new System.Drawing.Point(12, 12);
            this.generatedImg.Name = "generatedImg";
            this.generatedImg.Size = new System.Drawing.Size(256, 256);
            this.generatedImg.TabIndex = 1;
            this.generatedImg.TabStop = false;
            // 
            // link_site
            // 
            this.link_site.AutoSize = true;
            this.link_site.Location = new System.Drawing.Point(12, 309);
            this.link_site.Name = "link_site";
            this.link_site.Size = new System.Drawing.Size(178, 13);
            this.link_site.TabIndex = 2;
            this.link_site.TabStop = true;
            this.link_site.Text = "https://thispersondoesnotexist.com/";
            this.link_site.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_site_LinkClicked);
            // 
            // save_b
            // 
            this.save_b.Location = new System.Drawing.Point(287, 216);
            this.save_b.Name = "save_b";
            this.save_b.Size = new System.Drawing.Size(75, 23);
            this.save_b.TabIndex = 3;
            this.save_b.Text = "Save Image";
            this.save_b.UseVisualStyleBackColor = true;
            this.save_b.Click += new System.EventHandler(this.save_b_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(374, 331);
            this.Controls.Add(this.save_b);
            this.Controls.Add(this.link_site);
            this.Controls.Add(this.generatedImg);
            this.Controls.Add(this.generate_b);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "RandomFace";
            ((System.ComponentModel.ISupportInitialize)(this.generatedImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button generate_b;
        private System.Windows.Forms.PictureBox generatedImg;
        private System.Windows.Forms.Button save_b;
        private System.Windows.Forms.LinkLabel link_site;
    }
}

