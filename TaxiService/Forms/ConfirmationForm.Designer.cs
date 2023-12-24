namespace TaxiService.Forms
{
    partial class ConfirmationForm
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
            this.components = new System.ComponentModel.Container();
            this.preferredDateTimeLabel = new System.Windows.Forms.Label();
            this.preferredDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.PictureBox();
            this.luggageLabel = new System.Windows.Forms.Label();
            this.luggageTextBox = new System.Windows.Forms.TextBox();
            this.priceLabel = new System.Windows.Forms.Label();
            this.confirmButton = new System.Windows.Forms.Button();
            this.taxiDataSet = new TaxiService.TaxiDataSet();
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ordersTableAdapter = new TaxiService.TaxiDataSetTableAdapters.OrdersTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.BackButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taxiDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // preferredDateTimeLabel
            // 
            this.preferredDateTimeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.preferredDateTimeLabel.AutoSize = true;
            this.preferredDateTimeLabel.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.preferredDateTimeLabel.Location = new System.Drawing.Point(12, 110);
            this.preferredDateTimeLabel.Name = "preferredDateTimeLabel";
            this.preferredDateTimeLabel.Size = new System.Drawing.Size(276, 28);
            this.preferredDateTimeLabel.TabIndex = 0;
            this.preferredDateTimeLabel.Text = "Час та дата прибуття таксі";
            // 
            // preferredDateTimePicker
            // 
            this.preferredDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.preferredDateTimePicker.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.preferredDateTimePicker.Location = new System.Drawing.Point(393, 104);
            this.preferredDateTimePicker.Name = "preferredDateTimePicker";
            this.preferredDateTimePicker.Size = new System.Drawing.Size(277, 34);
            this.preferredDateTimePicker.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(189, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(311, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Підтвердження замовлення";
            // 
            // BackButton
            // 
            this.BackButton.Image = global::TaxiService.Properties.Resources.back;
            this.BackButton.InitialImage = global::TaxiService.Properties.Resources.back;
            this.BackButton.Location = new System.Drawing.Point(12, 12);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(32, 32);
            this.BackButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BackButton.TabIndex = 3;
            this.BackButton.TabStop = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // luggageLabel
            // 
            this.luggageLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.luggageLabel.AutoSize = true;
            this.luggageLabel.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.luggageLabel.Location = new System.Drawing.Point(12, 196);
            this.luggageLabel.Name = "luggageLabel";
            this.luggageLabel.Size = new System.Drawing.Size(109, 28);
            this.luggageLabel.TabIndex = 4;
            this.luggageLabel.Text = "Багаж (кг)";
            // 
            // luggageTextBox
            // 
            this.luggageTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.luggageTextBox.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.luggageTextBox.Location = new System.Drawing.Point(194, 196);
            this.luggageTextBox.Name = "luggageTextBox";
            this.luggageTextBox.Size = new System.Drawing.Size(100, 34);
            this.luggageTextBox.TabIndex = 5;
            this.luggageTextBox.TextChanged += new System.EventHandler(this.luggageTextBox_TextChanged);
            this.luggageTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.luggageTextBox_KeyPress);
            // 
            // priceLabel
            // 
            this.priceLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceLabel.Location = new System.Drawing.Point(12, 313);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(145, 28);
            this.priceLabel.TabIndex = 6;
            this.priceLabel.Text = "Кінцева ціна: ";
            // 
            // confirmButton
            // 
            this.confirmButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.confirmButton.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmButton.Location = new System.Drawing.Point(391, 360);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(279, 40);
            this.confirmButton.TabIndex = 7;
            this.confirmButton.Text = "Підтверджую замовлення";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // taxiDataSet
            // 
            this.taxiDataSet.DataSetName = "TaxiDataSet";
            this.taxiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ordersBindingSource
            // 
            this.ordersBindingSource.DataMember = "Orders";
            this.ordersBindingSource.DataSource = this.taxiDataSet;
            // 
            // ordersTableAdapter
            // 
            this.ordersTableAdapter.ClearBeforeFill = true;
            // 
            // ConfirmationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 433);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.luggageTextBox);
            this.Controls.Add(this.luggageLabel);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.preferredDateTimePicker);
            this.Controls.Add(this.preferredDateTimeLabel);
            this.Name = "ConfirmationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "confirmationForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.confirmationForm_FormClosing);
            this.Load += new System.EventHandler(this.confirmationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BackButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taxiDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label preferredDateTimeLabel;
        private System.Windows.Forms.DateTimePicker preferredDateTimePicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox BackButton;
        private System.Windows.Forms.Label luggageLabel;
        private System.Windows.Forms.TextBox luggageTextBox;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Button confirmButton;
        private TaxiDataSet taxiDataSet;
        private System.Windows.Forms.BindingSource ordersBindingSource;
        private TaxiDataSetTableAdapters.OrdersTableAdapter ordersTableAdapter;
    }
}