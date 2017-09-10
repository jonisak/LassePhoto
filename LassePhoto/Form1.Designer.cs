namespace LassePhoto
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
            this.btnOpenImage = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.txtImageText = new System.Windows.Forms.TextBox();
            this.lblImageText = new System.Windows.Forms.Label();
            this.btnSaveImage = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.btnSelectColor = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.imgView = new System.Windows.Forms.PictureBox();
            this.lblTextSize = new System.Windows.Forms.Label();
            this.lblTextColor = new System.Windows.Forms.Label();
            this.btnPreview = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOpenImage
            // 
            this.btnOpenImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenImage.Location = new System.Drawing.Point(12, 43);
            this.btnOpenImage.Name = "btnOpenImage";
            this.btnOpenImage.Size = new System.Drawing.Size(279, 47);
            this.btnOpenImage.TabIndex = 1;
            this.btnOpenImage.Text = "Öppna bild";
            this.btnOpenImage.UseVisualStyleBackColor = true;
            this.btnOpenImage.Click += new System.EventHandler(this.btnOpenImage_Click);
            // 
            // txtImageText
            // 
            this.txtImageText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtImageText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImageText.Location = new System.Drawing.Point(1056, 139);
            this.txtImageText.Multiline = true;
            this.txtImageText.Name = "txtImageText";
            this.txtImageText.Size = new System.Drawing.Size(231, 470);
            this.txtImageText.TabIndex = 2;
            this.txtImageText.TextChanged += new System.EventHandler(this.txtImageText_TextChanged);
            // 
            // lblImageText
            // 
            this.lblImageText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblImageText.AutoSize = true;
            this.lblImageText.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImageText.Location = new System.Drawing.Point(1052, 114);
            this.lblImageText.Name = "lblImageText";
            this.lblImageText.Size = new System.Drawing.Size(46, 22);
            this.lblImageText.TabIndex = 3;
            this.lblImageText.Text = "Text";
            // 
            // btnSaveImage
            // 
            this.btnSaveImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveImage.Location = new System.Drawing.Point(297, 43);
            this.btnSaveImage.Name = "btnSaveImage";
            this.btnSaveImage.Size = new System.Drawing.Size(279, 47);
            this.btnSaveImage.TabIndex = 4;
            this.btnSaveImage.Text = "Spara bild";
            this.btnSaveImage.UseVisualStyleBackColor = true;
            this.btnSaveImage.Click += new System.EventHandler(this.btnSaveImage_Click);
            // 
            // colorDialog
            // 
            this.colorDialog.SolidColorOnly = true;
            // 
            // btnSelectColor
            // 
            this.btnSelectColor.Location = new System.Drawing.Point(1222, 58);
            this.btnSelectColor.Name = "btnSelectColor";
            this.btnSelectColor.Size = new System.Drawing.Size(75, 23);
            this.btnSelectColor.TabIndex = 5;
            this.btnSelectColor.UseVisualStyleBackColor = true;
            this.btnSelectColor.Click += new System.EventHandler(this.btnSelectColor_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(955, 52);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 32);
            this.numericUpDown1.TabIndex = 6;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.imgView);
            this.panel1.Location = new System.Drawing.Point(12, 114);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1021, 473);
            this.panel1.TabIndex = 7;
            // 
            // imgView
            // 
            this.imgView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgView.Location = new System.Drawing.Point(23, 16);
            this.imgView.Name = "imgView";
            this.imgView.Size = new System.Drawing.Size(936, 418);
            this.imgView.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.imgView.TabIndex = 0;
            this.imgView.TabStop = false;
            this.imgView.Paint += new System.Windows.Forms.PaintEventHandler(this.imgView_Paint_1);
            // 
            // lblTextSize
            // 
            this.lblTextSize.AutoSize = true;
            this.lblTextSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextSize.Location = new System.Drawing.Point(801, 53);
            this.lblTextSize.Name = "lblTextSize";
            this.lblTextSize.Size = new System.Drawing.Size(148, 31);
            this.lblTextSize.TabIndex = 8;
            this.lblTextSize.Text = "Textstorlek";
            // 
            // lblTextColor
            // 
            this.lblTextColor.AutoSize = true;
            this.lblTextColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextColor.Location = new System.Drawing.Point(1077, 51);
            this.lblTextColor.Name = "lblTextColor";
            this.lblTextColor.Size = new System.Drawing.Size(114, 31);
            this.lblTextColor.TabIndex = 9;
            this.lblTextColor.Text = "Textfärg";
            // 
            // btnPreview
            // 
            this.btnPreview.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreview.Location = new System.Drawing.Point(590, 43);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(203, 47);
            this.btnPreview.TabIndex = 10;
            this.btnPreview.Text = "Förhandsgranska";
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1299, 621);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.lblTextColor);
            this.Controls.Add(this.lblTextSize);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.btnSelectColor);
            this.Controls.Add(this.btnSaveImage);
            this.Controls.Add(this.lblImageText);
            this.Controls.Add(this.txtImageText);
            this.Controls.Add(this.btnOpenImage);
            this.Name = "Form1";
            this.Text = "Lasse Photo";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnOpenImage;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.TextBox txtImageText;
        private System.Windows.Forms.Label lblImageText;
        private System.Windows.Forms.Button btnSaveImage;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.Button btnSelectColor;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox imgView;
        private System.Windows.Forms.Label lblTextSize;
        private System.Windows.Forms.Label lblTextColor;
        private System.Windows.Forms.Button btnPreview;
    }
}

