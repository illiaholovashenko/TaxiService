namespace TaxiService
{
    partial class AuthorisationForm
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
            this.EmailLabel = new System.Windows.Forms.Label();
            this.UserEmail = new System.Windows.Forms.TextBox();
            this.AuthorisationButton = new System.Windows.Forms.Button();
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // EmailLabel
            // 
            this.EmailLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Font = new System.Drawing.Font("Leelawadee", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailLabel.Location = new System.Drawing.Point(125, 70);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(200, 27);
            this.EmailLabel.TabIndex = 0;
            this.EmailLabel.Text = "Введіть ваш Email";
            // 
            // UserEmail
            // 
            this.UserEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.UserEmail.Font = new System.Drawing.Font("Leelawadee", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserEmail.Location = new System.Drawing.Point(110, 125);
            this.UserEmail.MaxLength = 50;
            this.UserEmail.Name = "UserEmail";
            this.UserEmail.Size = new System.Drawing.Size(230, 31);
            this.UserEmail.TabIndex = 1;
            this.UserEmail.TextChanged += new System.EventHandler(this.UserEmail_TextChanged);
            // 
            // AuthorisationButton
            // 
            this.AuthorisationButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.AuthorisationButton.BackColor = System.Drawing.Color.Gray;
            this.AuthorisationButton.Enabled = false;
            this.AuthorisationButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AuthorisationButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AuthorisationButton.Location = new System.Drawing.Point(150, 200);
            this.AuthorisationButton.MaximumSize = new System.Drawing.Size(150, 40);
            this.AuthorisationButton.MinimumSize = new System.Drawing.Size(150, 40);
            this.AuthorisationButton.Name = "AuthorisationButton";
            this.AuthorisationButton.Size = new System.Drawing.Size(150, 40);
            this.AuthorisationButton.TabIndex = 2;
            this.AuthorisationButton.Text = "Увійти";
            this.AuthorisationButton.UseVisualStyleBackColor = false;
            this.AuthorisationButton.Click += new System.EventHandler(this.AuthorisationButton_Click);
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.ErrorLabel.AutoSize = true;
            this.ErrorLabel.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorLabel.ForeColor = System.Drawing.Color.IndianRed;
            this.ErrorLabel.Location = new System.Drawing.Point(87, 159);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(0, 20);
            this.ErrorLabel.TabIndex = 3;
            // 
            // AuthorisationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 303);
            this.Controls.Add(this.ErrorLabel);
            this.Controls.Add(this.AuthorisationButton);
            this.Controls.Add(this.UserEmail);
            this.Controls.Add(this.EmailLabel);
            this.Name = "AuthorisationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Увійдіть/Створіть акаунт";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AuthorisationForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.TextBox UserEmail;
        private System.Windows.Forms.Button AuthorisationButton;
        private System.Windows.Forms.Label ErrorLabel;
    }
}