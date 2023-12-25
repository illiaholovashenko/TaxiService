namespace TaxiService.Forms
{
    partial class CarCategoryForm
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
            System.Windows.Forms.Label category_nameLabel;
            System.Windows.Forms.Label max_passengers_numberLabel;
            System.Windows.Forms.Label kilometer_priceLabel;
            this.taxiDataSet = new TaxiService.TaxiDataSet();
            this.car_categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.car_categoryTableAdapter = new TaxiService.TaxiDataSetTableAdapters.Car_categoryTableAdapter();
            this.tableAdapterManager = new TaxiService.TaxiDataSetTableAdapters.TableAdapterManager();
            this.confirmButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.category_nameTextBox = new System.Windows.Forms.TextBox();
            this.max_passengers_numberTextBox = new System.Windows.Forms.TextBox();
            this.kilometer_priceTextBox = new System.Windows.Forms.TextBox();
            this.ErrorLabel = new System.Windows.Forms.Label();
            category_nameLabel = new System.Windows.Forms.Label();
            max_passengers_numberLabel = new System.Windows.Forms.Label();
            kilometer_priceLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.taxiDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.car_categoryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // category_nameLabel
            // 
            category_nameLabel.AutoSize = true;
            category_nameLabel.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            category_nameLabel.Location = new System.Drawing.Point(25, 84);
            category_nameLabel.Name = "category_nameLabel";
            category_nameLabel.Size = new System.Drawing.Size(177, 28);
            category_nameLabel.TabIndex = 3;
            category_nameLabel.Text = "Назва категорії*:";
            // 
            // max_passengers_numberLabel
            // 
            max_passengers_numberLabel.AutoSize = true;
            max_passengers_numberLabel.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            max_passengers_numberLabel.Location = new System.Drawing.Point(25, 134);
            max_passengers_numberLabel.Name = "max_passengers_numberLabel";
            max_passengers_numberLabel.Size = new System.Drawing.Size(279, 28);
            max_passengers_numberLabel.TabIndex = 5;
            max_passengers_numberLabel.Text = "Макс. кількість пасажирів*:";
            // 
            // kilometer_priceLabel
            // 
            kilometer_priceLabel.AutoSize = true;
            kilometer_priceLabel.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            kilometer_priceLabel.Location = new System.Drawing.Point(25, 185);
            kilometer_priceLabel.Name = "kilometer_priceLabel";
            kilometer_priceLabel.Size = new System.Drawing.Size(191, 28);
            kilometer_priceLabel.TabIndex = 7;
            kilometer_priceLabel.Text = "Ціна за кілометр*:";
            // 
            // taxiDataSet
            // 
            this.taxiDataSet.DataSetName = "TaxiDataSet";
            this.taxiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // car_categoryBindingSource
            // 
            this.car_categoryBindingSource.DataMember = "Car_category";
            this.car_categoryBindingSource.DataSource = this.taxiDataSet;
            // 
            // car_categoryTableAdapter
            // 
            this.car_categoryTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Car_categoryTableAdapter = this.car_categoryTableAdapter;
            this.tableAdapterManager.CarTableAdapter = null;
            this.tableAdapterManager.DriverTableAdapter = null;
            this.tableAdapterManager.OrdersTableAdapter = null;
            this.tableAdapterManager.PassengerTableAdapter = null;
            this.tableAdapterManager.ReviewTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = TaxiService.TaxiDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // confirmButton
            // 
            this.confirmButton.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmButton.Location = new System.Drawing.Point(300, 331);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(160, 55);
            this.confirmButton.TabIndex = 26;
            this.confirmButton.Text = "Підтвердити";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.Location = new System.Drawing.Point(50, 331);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(160, 55);
            this.cancelButton.TabIndex = 25;
            this.cancelButton.Text = "Скасувати";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // category_nameTextBox
            // 
            this.category_nameTextBox.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.category_nameTextBox.Location = new System.Drawing.Point(318, 84);
            this.category_nameTextBox.Name = "category_nameTextBox";
            this.category_nameTextBox.Size = new System.Drawing.Size(132, 34);
            this.category_nameTextBox.TabIndex = 27;
            // 
            // max_passengers_numberTextBox
            // 
            this.max_passengers_numberTextBox.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.max_passengers_numberTextBox.Location = new System.Drawing.Point(318, 134);
            this.max_passengers_numberTextBox.Name = "max_passengers_numberTextBox";
            this.max_passengers_numberTextBox.Size = new System.Drawing.Size(132, 34);
            this.max_passengers_numberTextBox.TabIndex = 28;
            this.max_passengers_numberTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.max_passengers_numberTextBox_KeyPress);
            // 
            // kilometer_priceTextBox
            // 
            this.kilometer_priceTextBox.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kilometer_priceTextBox.Location = new System.Drawing.Point(318, 185);
            this.kilometer_priceTextBox.Name = "kilometer_priceTextBox";
            this.kilometer_priceTextBox.Size = new System.Drawing.Size(132, 34);
            this.kilometer_priceTextBox.TabIndex = 29;
            this.kilometer_priceTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.kilometer_priceTextBox_KeyPress);
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ErrorLabel.AutoSize = true;
            this.ErrorLabel.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorLabel.ForeColor = System.Drawing.Color.IndianRed;
            this.ErrorLabel.Location = new System.Drawing.Point(26, 239);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(0, 20);
            this.ErrorLabel.TabIndex = 39;
            // 
            // CarCategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 403);
            this.Controls.Add(this.ErrorLabel);
            this.Controls.Add(this.kilometer_priceTextBox);
            this.Controls.Add(this.max_passengers_numberTextBox);
            this.Controls.Add(this.category_nameTextBox);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(category_nameLabel);
            this.Controls.Add(max_passengers_numberLabel);
            this.Controls.Add(kilometer_priceLabel);
            this.MaximumSize = new System.Drawing.Size(500, 450);
            this.MinimumSize = new System.Drawing.Size(500, 450);
            this.Name = "CarCategoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CarCategoryForm";
            this.Load += new System.EventHandler(this.CarCategoryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.taxiDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.car_categoryBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TaxiDataSet taxiDataSet;
        private System.Windows.Forms.BindingSource car_categoryBindingSource;
        private TaxiDataSetTableAdapters.Car_categoryTableAdapter car_categoryTableAdapter;
        private TaxiDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.TextBox category_nameTextBox;
        private System.Windows.Forms.TextBox max_passengers_numberTextBox;
        private System.Windows.Forms.TextBox kilometer_priceTextBox;
        private System.Windows.Forms.Label ErrorLabel;
    }
}