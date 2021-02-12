
namespace EasyStego_Forms
{
    partial class MainScreen
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
            System.Windows.Forms.Label labelPublicImage;
            System.Windows.Forms.Label labelHiddenFile;
            System.Windows.Forms.Label labelOutputEncrypt;
            System.Windows.Forms.Label labelEncrypt;
            System.Windows.Forms.Label labelDecrypt;
            System.Windows.Forms.Label labelOutputDecrypt;
            System.Windows.Forms.Label labelImageDecrypt;
            this.buttonPublicImageEncrypt = new System.Windows.Forms.Button();
            this.buttonHiddenFileEncrypt = new System.Windows.Forms.Button();
            this.buttonOutputEncrypt = new System.Windows.Forms.Button();
            this.buttonEncrypt = new System.Windows.Forms.Button();
            this.buttonOutputDecrypt = new System.Windows.Forms.Button();
            this.buttonImageDecrypt = new System.Windows.Forms.Button();
            this.buttonDecrypt = new System.Windows.Forms.Button();
            this.labelPathImageEncrypt = new System.Windows.Forms.Label();
            this.labelPathFileEncrypt = new System.Windows.Forms.Label();
            this.labelPathOutputEncrypt = new System.Windows.Forms.Label();
            this.labelPathImageDecrypt = new System.Windows.Forms.Label();
            this.labelPathOutputDecrypt = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.checkBoxEncrypt = new System.Windows.Forms.CheckBox();
            this.checkBoxDecrypt = new System.Windows.Forms.CheckBox();
            this.labelErrorEncrypt = new System.Windows.Forms.Label();
            this.labelErrorDecrypt = new System.Windows.Forms.Label();
            labelPublicImage = new System.Windows.Forms.Label();
            labelHiddenFile = new System.Windows.Forms.Label();
            labelOutputEncrypt = new System.Windows.Forms.Label();
            labelEncrypt = new System.Windows.Forms.Label();
            labelDecrypt = new System.Windows.Forms.Label();
            labelOutputDecrypt = new System.Windows.Forms.Label();
            labelImageDecrypt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelPublicImage
            // 
            labelPublicImage.AutoSize = true;
            labelPublicImage.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            labelPublicImage.Location = new System.Drawing.Point(10, 70);
            labelPublicImage.Name = "labelPublicImage";
            labelPublicImage.Size = new System.Drawing.Size(85, 17);
            labelPublicImage.TabIndex = 1;
            labelPublicImage.Text = "Public image";
            labelPublicImage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelHiddenFile
            // 
            labelHiddenFile.AutoSize = true;
            labelHiddenFile.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            labelHiddenFile.Location = new System.Drawing.Point(10, 150);
            labelHiddenFile.Name = "labelHiddenFile";
            labelHiddenFile.Size = new System.Drawing.Size(73, 17);
            labelHiddenFile.TabIndex = 3;
            labelHiddenFile.Text = "Hidden file";
            labelHiddenFile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelOutputEncrypt
            // 
            labelOutputEncrypt.AutoSize = true;
            labelOutputEncrypt.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            labelOutputEncrypt.Location = new System.Drawing.Point(10, 230);
            labelOutputEncrypt.Name = "labelOutputEncrypt";
            labelOutputEncrypt.Size = new System.Drawing.Size(52, 17);
            labelOutputEncrypt.TabIndex = 5;
            labelOutputEncrypt.Text = "Output";
            labelOutputEncrypt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelEncrypt
            // 
            labelEncrypt.AutoSize = true;
            labelEncrypt.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            labelEncrypt.Location = new System.Drawing.Point(48, 18);
            labelEncrypt.Name = "labelEncrypt";
            labelEncrypt.Size = new System.Drawing.Size(80, 25);
            labelEncrypt.TabIndex = 7;
            labelEncrypt.Text = "Encrypt";
            // 
            // labelDecrypt
            // 
            labelDecrypt.AutoSize = true;
            labelDecrypt.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            labelDecrypt.Location = new System.Drawing.Point(533, 18);
            labelDecrypt.Name = "labelDecrypt";
            labelDecrypt.Size = new System.Drawing.Size(82, 25);
            labelDecrypt.TabIndex = 15;
            labelDecrypt.Text = "Decrypt";
            // 
            // labelOutputDecrypt
            // 
            labelOutputDecrypt.AutoSize = true;
            labelOutputDecrypt.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            labelOutputDecrypt.Location = new System.Drawing.Point(495, 148);
            labelOutputDecrypt.Name = "labelOutputDecrypt";
            labelOutputDecrypt.Size = new System.Drawing.Size(52, 17);
            labelOutputDecrypt.TabIndex = 13;
            labelOutputDecrypt.Text = "Output";
            labelOutputDecrypt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelImageDecrypt
            // 
            labelImageDecrypt.AutoSize = true;
            labelImageDecrypt.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            labelImageDecrypt.Location = new System.Drawing.Point(495, 70);
            labelImageDecrypt.Name = "labelImageDecrypt";
            labelImageDecrypt.Size = new System.Drawing.Size(85, 17);
            labelImageDecrypt.TabIndex = 9;
            labelImageDecrypt.Text = "Public image";
            labelImageDecrypt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonPublicImageEncrypt
            // 
            this.buttonPublicImageEncrypt.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonPublicImageEncrypt.Location = new System.Drawing.Point(100, 65);
            this.buttonPublicImageEncrypt.Name = "buttonPublicImageEncrypt";
            this.buttonPublicImageEncrypt.Size = new System.Drawing.Size(75, 30);
            this.buttonPublicImageEncrypt.TabIndex = 0;
            this.buttonPublicImageEncrypt.Text = "Search";
            this.buttonPublicImageEncrypt.UseVisualStyleBackColor = true;
            this.buttonPublicImageEncrypt.Click += new System.EventHandler(this.buttonPublicImageEncrypt_Click);
            // 
            // buttonHiddenFileEncrypt
            // 
            this.buttonHiddenFileEncrypt.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonHiddenFileEncrypt.Location = new System.Drawing.Point(100, 145);
            this.buttonHiddenFileEncrypt.Name = "buttonHiddenFileEncrypt";
            this.buttonHiddenFileEncrypt.Size = new System.Drawing.Size(75, 30);
            this.buttonHiddenFileEncrypt.TabIndex = 2;
            this.buttonHiddenFileEncrypt.Text = "Search";
            this.buttonHiddenFileEncrypt.UseVisualStyleBackColor = true;
            this.buttonHiddenFileEncrypt.Click += new System.EventHandler(this.buttonHiddenFileEncrypt_Click);
            // 
            // buttonOutputEncrypt
            // 
            this.buttonOutputEncrypt.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonOutputEncrypt.Location = new System.Drawing.Point(100, 225);
            this.buttonOutputEncrypt.Name = "buttonOutputEncrypt";
            this.buttonOutputEncrypt.Size = new System.Drawing.Size(75, 30);
            this.buttonOutputEncrypt.TabIndex = 4;
            this.buttonOutputEncrypt.Text = "Search";
            this.buttonOutputEncrypt.UseVisualStyleBackColor = true;
            this.buttonOutputEncrypt.Click += new System.EventHandler(this.buttonOutputEncrypt_Click);
            // 
            // buttonEncrypt
            // 
            this.buttonEncrypt.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonEncrypt.Location = new System.Drawing.Point(50, 305);
            this.buttonEncrypt.Name = "buttonEncrypt";
            this.buttonEncrypt.Size = new System.Drawing.Size(90, 50);
            this.buttonEncrypt.TabIndex = 6;
            this.buttonEncrypt.Text = "Encrypt";
            this.buttonEncrypt.UseVisualStyleBackColor = true;
            this.buttonEncrypt.Click += new System.EventHandler(this.buttonEncrypt_Click);
            // 
            // buttonOutputDecrypt
            // 
            this.buttonOutputDecrypt.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonOutputDecrypt.Location = new System.Drawing.Point(585, 145);
            this.buttonOutputDecrypt.Name = "buttonOutputDecrypt";
            this.buttonOutputDecrypt.Size = new System.Drawing.Size(75, 30);
            this.buttonOutputDecrypt.TabIndex = 12;
            this.buttonOutputDecrypt.Text = "Search";
            this.buttonOutputDecrypt.UseVisualStyleBackColor = true;
            this.buttonOutputDecrypt.Click += new System.EventHandler(this.buttonOutputDecrypt_Click);
            // 
            // buttonImageDecrypt
            // 
            this.buttonImageDecrypt.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonImageDecrypt.Location = new System.Drawing.Point(585, 65);
            this.buttonImageDecrypt.Name = "buttonImageDecrypt";
            this.buttonImageDecrypt.Size = new System.Drawing.Size(75, 30);
            this.buttonImageDecrypt.TabIndex = 8;
            this.buttonImageDecrypt.Text = "Search";
            this.buttonImageDecrypt.UseVisualStyleBackColor = true;
            this.buttonImageDecrypt.Click += new System.EventHandler(this.buttonImageDecrypt_Click);
            // 
            // buttonDecrypt
            // 
            this.buttonDecrypt.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonDecrypt.Location = new System.Drawing.Point(535, 225);
            this.buttonDecrypt.Name = "buttonDecrypt";
            this.buttonDecrypt.Size = new System.Drawing.Size(90, 50);
            this.buttonDecrypt.TabIndex = 16;
            this.buttonDecrypt.Text = "Decrypt";
            this.buttonDecrypt.UseVisualStyleBackColor = true;
            this.buttonDecrypt.Click += new System.EventHandler(this.buttonDecrypt_Click);
            // 
            // labelPathImageEncrypt
            // 
            this.labelPathImageEncrypt.AutoSize = true;
            this.labelPathImageEncrypt.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelPathImageEncrypt.Location = new System.Drawing.Point(185, 70);
            this.labelPathImageEncrypt.Name = "labelPathImageEncrypt";
            this.labelPathImageEncrypt.Size = new System.Drawing.Size(28, 17);
            this.labelPathImageEncrypt.TabIndex = 17;
            this.labelPathImageEncrypt.Text = "----";
            // 
            // labelPathFileEncrypt
            // 
            this.labelPathFileEncrypt.AutoSize = true;
            this.labelPathFileEncrypt.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelPathFileEncrypt.Location = new System.Drawing.Point(185, 150);
            this.labelPathFileEncrypt.Name = "labelPathFileEncrypt";
            this.labelPathFileEncrypt.Size = new System.Drawing.Size(28, 17);
            this.labelPathFileEncrypt.TabIndex = 18;
            this.labelPathFileEncrypt.Text = "----";
            // 
            // labelPathOutputEncrypt
            // 
            this.labelPathOutputEncrypt.AutoSize = true;
            this.labelPathOutputEncrypt.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelPathOutputEncrypt.Location = new System.Drawing.Point(185, 230);
            this.labelPathOutputEncrypt.Name = "labelPathOutputEncrypt";
            this.labelPathOutputEncrypt.Size = new System.Drawing.Size(28, 17);
            this.labelPathOutputEncrypt.TabIndex = 19;
            this.labelPathOutputEncrypt.Text = "----";
            // 
            // labelPathImageDecrypt
            // 
            this.labelPathImageDecrypt.AutoSize = true;
            this.labelPathImageDecrypt.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelPathImageDecrypt.Location = new System.Drawing.Point(670, 70);
            this.labelPathImageDecrypt.Name = "labelPathImageDecrypt";
            this.labelPathImageDecrypt.Size = new System.Drawing.Size(28, 17);
            this.labelPathImageDecrypt.TabIndex = 20;
            this.labelPathImageDecrypt.Text = "----";
            // 
            // labelPathOutputDecrypt
            // 
            this.labelPathOutputDecrypt.AutoSize = true;
            this.labelPathOutputDecrypt.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelPathOutputDecrypt.Location = new System.Drawing.Point(670, 150);
            this.labelPathOutputDecrypt.Name = "labelPathOutputDecrypt";
            this.labelPathOutputDecrypt.Size = new System.Drawing.Size(28, 17);
            this.labelPathOutputDecrypt.TabIndex = 21;
            this.labelPathOutputDecrypt.Text = "----";
            // 
            // checkBoxEncrypt
            // 
            this.checkBoxEncrypt.AutoSize = true;
            this.checkBoxEncrypt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.checkBoxEncrypt.Location = new System.Drawing.Point(10, 280);
            this.checkBoxEncrypt.Name = "checkBoxEncrypt";
            this.checkBoxEncrypt.Size = new System.Drawing.Size(140, 21);
            this.checkBoxEncrypt.TabIndex = 22;
            this.checkBoxEncrypt.Text = "Skip alpha channel";
            this.checkBoxEncrypt.UseVisualStyleBackColor = true;
            this.checkBoxEncrypt.CheckedChanged += new System.EventHandler(this.checkBoxEncrypt_CheckedChanged);
            // 
            // checkBoxDecrypt
            // 
            this.checkBoxDecrypt.AutoSize = true;
            this.checkBoxDecrypt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.checkBoxDecrypt.Location = new System.Drawing.Point(495, 200);
            this.checkBoxDecrypt.Name = "checkBoxDecrypt";
            this.checkBoxDecrypt.Size = new System.Drawing.Size(140, 21);
            this.checkBoxDecrypt.TabIndex = 23;
            this.checkBoxDecrypt.Text = "Skip alpha channel";
            this.checkBoxDecrypt.UseVisualStyleBackColor = true;
            this.checkBoxDecrypt.CheckedChanged += new System.EventHandler(this.checkBoxDecrypt_CheckedChanged);
            // 
            // labelErrorEncrypt
            // 
            this.labelErrorEncrypt.AutoSize = true;
            this.labelErrorEncrypt.ForeColor = System.Drawing.Color.Red;
            this.labelErrorEncrypt.Location = new System.Drawing.Point(10, 370);
            this.labelErrorEncrypt.Name = "labelErrorEncrypt";
            this.labelErrorEncrypt.Size = new System.Drawing.Size(158, 17);
            this.labelErrorEncrypt.TabIndex = 24;
            this.labelErrorEncrypt.Text = "Error: message message.";
            // 
            // labelErrorDecrypt
            // 
            this.labelErrorDecrypt.AutoSize = true;
            this.labelErrorDecrypt.ForeColor = System.Drawing.Color.Red;
            this.labelErrorDecrypt.Location = new System.Drawing.Point(495, 290);
            this.labelErrorDecrypt.Name = "labelErrorDecrypt";
            this.labelErrorDecrypt.Size = new System.Drawing.Size(158, 17);
            this.labelErrorDecrypt.TabIndex = 25;
            this.labelErrorDecrypt.Text = "Error: message message.";
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 503);
            this.Controls.Add(this.labelErrorDecrypt);
            this.Controls.Add(this.labelErrorEncrypt);
            this.Controls.Add(this.checkBoxDecrypt);
            this.Controls.Add(this.checkBoxEncrypt);
            this.Controls.Add(this.labelPathOutputDecrypt);
            this.Controls.Add(this.labelPathImageDecrypt);
            this.Controls.Add(this.labelPathOutputEncrypt);
            this.Controls.Add(this.labelPathFileEncrypt);
            this.Controls.Add(this.labelPathImageEncrypt);
            this.Controls.Add(this.buttonDecrypt);
            this.Controls.Add(labelDecrypt);
            this.Controls.Add(labelOutputDecrypt);
            this.Controls.Add(this.buttonOutputDecrypt);
            this.Controls.Add(labelImageDecrypt);
            this.Controls.Add(this.buttonImageDecrypt);
            this.Controls.Add(labelEncrypt);
            this.Controls.Add(this.buttonEncrypt);
            this.Controls.Add(labelOutputEncrypt);
            this.Controls.Add(this.buttonOutputEncrypt);
            this.Controls.Add(labelHiddenFile);
            this.Controls.Add(this.buttonHiddenFileEncrypt);
            this.Controls.Add(labelPublicImage);
            this.Controls.Add(this.buttonPublicImageEncrypt);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Name = "MainScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EasyStego";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonPublicImageEncrypt;
        private System.Windows.Forms.Label labelPublicImage;
        private System.Windows.Forms.Label labelHiddenFile;
        private System.Windows.Forms.Button buttonHiddenFileEncrypt;
        private System.Windows.Forms.Label labelOutputEncrypt;
        private System.Windows.Forms.Button buttonOutputEncrypt;
        private System.Windows.Forms.Button buttonEncrypt;
        private System.Windows.Forms.Label labelOutputDecrypt;
        private System.Windows.Forms.Button buttonOutputDecrypt;
        private System.Windows.Forms.Label labelImageDecrypt;
        private System.Windows.Forms.Button buttonImageDecrypt;
        private System.Windows.Forms.Button buttonDecrypt;
        private System.Windows.Forms.Label labelPathImageEncrypt;
        private System.Windows.Forms.Label labelPathFileEncrypt;
        private System.Windows.Forms.Label labelPathOutputEncrypt;
        private System.Windows.Forms.Label labelPathImageDecrypt;
        private System.Windows.Forms.Label labelPathOutputDecrypt;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.CheckBox checkBoxEncrypt;
        private System.Windows.Forms.CheckBox checkBoxDecrypt;
        private System.Windows.Forms.Label labelErrorEncrypt;
        private System.Windows.Forms.Label labelErrorDecrypt;
    }
}

