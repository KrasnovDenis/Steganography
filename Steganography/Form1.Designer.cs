namespace Steganography
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.encrypt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.choose_picture = new System.Windows.Forms.Button();
            this.decrypt = new System.Windows.Forms.Button();
            this.save_picture = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(321, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(426, 397);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(16, 50);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(240, 119);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(16, 222);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(240, 119);
            this.richTextBox2.TabIndex = 2;
            this.richTextBox2.Text = "";
            // 
            // encrypt
            // 
            this.encrypt.Location = new System.Drawing.Point(16, 347);
            this.encrypt.Name = "encrypt";
            this.encrypt.Size = new System.Drawing.Size(114, 47);
            this.encrypt.TabIndex = 3;
            this.encrypt.Text = "Зашифровать";
            this.encrypt.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Секретное сообщение";
            // 
            // choose_picture
            // 
            this.choose_picture.Location = new System.Drawing.Point(136, 347);
            this.choose_picture.Name = "choose_picture";
            this.choose_picture.Size = new System.Drawing.Size(114, 47);
            this.choose_picture.TabIndex = 5;
            this.choose_picture.Text = "Выбрать картинку";
            this.choose_picture.UseVisualStyleBackColor = true;
            this.choose_picture.Click += new System.EventHandler(this.choose_picture_Click);
            // 
            // decrypt
            // 
            this.decrypt.Location = new System.Drawing.Point(16, 400);
            this.decrypt.Name = "decrypt";
            this.decrypt.Size = new System.Drawing.Size(114, 47);
            this.decrypt.TabIndex = 6;
            this.decrypt.Text = "Расшифровать";
            this.decrypt.UseVisualStyleBackColor = true;
            // 
            // save_picture
            // 
            this.save_picture.Location = new System.Drawing.Point(136, 400);
            this.save_picture.Name = "save_picture";
            this.save_picture.Size = new System.Drawing.Size(114, 47);
            this.save_picture.TabIndex = 7;
            this.save_picture.Text = "Сохранить картинку";
            this.save_picture.UseVisualStyleBackColor = true;
            this.save_picture.Click += new System.EventHandler(this.save_picture_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Ключ";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 477);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.save_picture);
            this.Controls.Add(this.decrypt);
            this.Controls.Add(this.choose_picture);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.encrypt);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Button encrypt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button choose_picture;
        private System.Windows.Forms.Button decrypt;
        private System.Windows.Forms.Button save_picture;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

