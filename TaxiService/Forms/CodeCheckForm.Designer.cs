namespace TaxiService
{
    partial class CodeCheckForm
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
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.AuthorisationButton = new System.Windows.Forms.Button();
            this.ConfirmCode = new System.Windows.Forms.TextBox();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.BackButton)).BeginInit();
            this.SuspendLayout();
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.ErrorLabel.AutoSize = true;
            this.ErrorLabel.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorLabel.ForeColor = System.Drawing.Color.IndianRed;
            this.ErrorLabel.Location = new System.Drawing.Point(156, 166);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(0, 20);
            this.ErrorLabel.TabIndex = 7;
            // 
            // AuthorisationButton
            // 
            this.AuthorisationButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.AuthorisationButton.BackColor = System.Drawing.Color.Gray;
            this.AuthorisationButton.Enabled = false;
            this.AuthorisationButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AuthorisationButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AuthorisationButton.Location = new System.Drawing.Point(150, 207);
            this.AuthorisationButton.MaximumSize = new System.Drawing.Size(150, 40);
            this.AuthorisationButton.MinimumSize = new System.Drawing.Size(150, 40);
            this.AuthorisationButton.Name = "AuthorisationButton";
            this.AuthorisationButton.Size = new System.Drawing.Size(150, 40);
            this.AuthorisationButton.TabIndex = 6;
            this.AuthorisationButton.Text = "Підтвердити";
            this.AuthorisationButton.UseVisualStyleBackColor = false;
            this.AuthorisationButton.Click += new System.EventHandler(this.AuthorisationButton_Click);
            // 
            // ConfirmCode
            // 
            this.ConfirmCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.ConfirmCode.Font = new System.Drawing.Font("Leelawadee", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmCode.Location = new System.Drawing.Point(185, 132);
            this.ConfirmCode.MaxLength = 6;
            this.ConfirmCode.Name = "ConfirmCode";
            this.ConfirmCode.Size = new System.Drawing.Size(80, 31);
            this.ConfirmCode.TabIndex = 5;
            this.ConfirmCode.TextChanged += new System.EventHandler(this.ConfirmCode_TextChanged);
            this.ConfirmCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ConfirmCode_KeyPress);
            // 
            // TitleLabel
            // 
            this.TitleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Leelawadee", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(159, 51);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(132, 27);
            this.TitleLabel.TabIndex = 4;
            this.TitleLabel.Text = "Введіть код";
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Font = new System.Drawing.Font("Leelawadee UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescriptionLabel.Location = new System.Drawing.Point(12, 101);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(223, 17);
            this.DescriptionLabel.TabIndex = 8;
            this.DescriptionLabel.Text = "Код було відправлено на пошту ";
            // 
            // BackButton
            // 
            this.BackButton.Image = global::TaxiService.Properties.Resources.back;
            this.BackButton.Location = new System.Drawing.Point(12, 12);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(32, 32);
            this.BackButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BackButton.TabIndex = 9;
            this.BackButton.TabStop = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // CodeCheckForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 303);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.DescriptionLabel);
            this.Controls.Add(this.ErrorLabel);
            this.Controls.Add(this.AuthorisationButton);
            this.Controls.Add(this.ConfirmCode);
            this.Controls.Add(this.TitleLabel);
            this.Name = "CodeCheckForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Підтвердження пошти";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CodeCheckForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.BackButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ErrorLabel;
        private System.Windows.Forms.Button AuthorisationButton;
        private System.Windows.Forms.TextBox ConfirmCode;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.PictureBox BackButton;
    }
}