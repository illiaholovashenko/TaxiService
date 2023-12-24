namespace TaxiService.Forms
{
    partial class CarForm
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
            System.Windows.Forms.Label car_numberLabel;
            System.Windows.Forms.Label modelLabel;
            System.Windows.Forms.Label colorLabel;
            System.Windows.Forms.Label production_yearLabel;
            System.Windows.Forms.Label driver_idLabel;
            System.Windows.Forms.Label car_category_idLabel;
            this.taxiDataSet = new TaxiService.TaxiDataSet();
            this.carBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carTableAdapter = new TaxiService.TaxiDataSetTableAdapters.CarTableAdapter();
            this.tableAdapterManager = new TaxiService.TaxiDataSetTableAdapters.TableAdapterManager();
            this.confirmButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.driver_idComboBox = new System.Windows.Forms.ComboBox();
            this.driverBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.car_category_idComboBox = new System.Windows.Forms.ComboBox();
            this.carcategoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.driverTableAdapter = new TaxiService.TaxiDataSetTableAdapters.DriverTableAdapter();
            this.car_categoryTableAdapter = new TaxiService.TaxiDataSetTableAdapters.Car_categoryTableAdapter();
            this.car_numberTextBox = new System.Windows.Forms.TextBox();
            this.modelTextBox = new System.Windows.Forms.TextBox();
            this.production_yearTextBox = new System.Windows.Forms.TextBox();
            this.colorTextBox = new System.Windows.Forms.TextBox();
            this.ErrorLabel = new System.Windows.Forms.Label();
            car_numberLabel = new System.Windows.Forms.Label();
            modelLabel = new System.Windows.Forms.Label();
            colorLabel = new System.Windows.Forms.Label();
            production_yearLabel = new System.Windows.Forms.Label();
            driver_idLabel = new System.Windows.Forms.Label();
            car_category_idLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.taxiDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.driverBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carcategoryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // car_numberLabel
            // 
            car_numberLabel.AutoSize = true;
            car_numberLabel.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            car_numberLabel.Location = new System.Drawing.Point(41, 83);
            car_numberLabel.Name = "car_numberLabel";
            car_numberLabel.Size = new System.Drawing.Size(140, 28);
            car_numberLabel.TabIndex = 1;
            car_numberLabel.Text = "Номер авто*:";
            // 
            // modelLabel
            // 
            modelLabel.AutoSize = true;
            modelLabel.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            modelLabel.Location = new System.Drawing.Point(41, 134);
            modelLabel.Name = "modelLabel";
            modelLabel.Size = new System.Drawing.Size(101, 28);
            modelLabel.TabIndex = 3;
            modelLabel.Text = "Модель*:";
            // 
            // colorLabel
            // 
            colorLabel.AutoSize = true;
            colorLabel.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            colorLabel.Location = new System.Drawing.Point(41, 187);
            colorLabel.Name = "colorLabel";
            colorLabel.Size = new System.Drawing.Size(79, 28);
            colorLabel.TabIndex = 5;
            colorLabel.Text = "Колір*:";
            // 
            // production_yearLabel
            // 
            production_yearLabel.AutoSize = true;
            production_yearLabel.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            production_yearLabel.Location = new System.Drawing.Point(41, 240);
            production_yearLabel.Name = "production_yearLabel";
            production_yearLabel.Size = new System.Drawing.Size(138, 28);
            production_yearLabel.TabIndex = 7;
            production_yearLabel.Text = "Рік випуску*:";
            // 
            // driver_idLabel
            // 
            driver_idLabel.AutoSize = true;
            driver_idLabel.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            driver_idLabel.Location = new System.Drawing.Point(41, 294);
            driver_idLabel.Name = "driver_idLabel";
            driver_idLabel.Size = new System.Drawing.Size(100, 28);
            driver_idLabel.TabIndex = 9;
            driver_idLabel.Text = "Власник:";
            // 
            // car_category_idLabel
            // 
            car_category_idLabel.AutoSize = true;
            car_category_idLabel.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            car_category_idLabel.Location = new System.Drawing.Point(41, 348);
            car_category_idLabel.Name = "car_category_idLabel";
            car_category_idLabel.Size = new System.Drawing.Size(162, 28);
            car_category_idLabel.TabIndex = 11;
            car_category_idLabel.Text = "Категорія авто:";
            // 
            // taxiDataSet
            // 
            this.taxiDataSet.DataSetName = "TaxiDataSet";
            this.taxiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // carBindingSource
            // 
            this.carBindingSource.DataMember = "Car";
            this.carBindingSource.DataSource = this.taxiDataSet;
            // 
            // carTableAdapter
            // 
            this.carTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Car_categoryTableAdapter = null;
            this.tableAdapterManager.CarTableAdapter = this.carTableAdapter;
            this.tableAdapterManager.DriverTableAdapter = null;
            this.tableAdapterManager.OrdersTableAdapter = null;
            this.tableAdapterManager.PassengerTableAdapter = null;
            this.tableAdapterManager.ReviewTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = TaxiService.TaxiDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // confirmButton
            // 
            this.confirmButton.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmButton.Location = new System.Drawing.Point(300, 476);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(150, 50);
            this.confirmButton.TabIndex = 30;
            this.confirmButton.Text = "Підтвердити";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.Location = new System.Drawing.Point(50, 476);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(150, 50);
            this.cancelButton.TabIndex = 29;
            this.cancelButton.Text = "Скасувати";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // driver_idComboBox
            // 
            this.driver_idComboBox.DataSource = this.driverBindingSource;
            this.driver_idComboBox.DisplayMember = "Phone_number";
            this.driver_idComboBox.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.driver_idComboBox.FormattingEnabled = true;
            this.driver_idComboBox.Location = new System.Drawing.Point(228, 294);
            this.driver_idComboBox.Name = "driver_idComboBox";
            this.driver_idComboBox.Size = new System.Drawing.Size(169, 36);
            this.driver_idComboBox.TabIndex = 31;
            this.driver_idComboBox.ValueMember = "Driver_id";
            // 
            // driverBindingSource
            // 
            this.driverBindingSource.DataMember = "Driver";
            this.driverBindingSource.DataSource = this.taxiDataSet;
            // 
            // car_category_idComboBox
            // 
            this.car_category_idComboBox.DataSource = this.carcategoryBindingSource;
            this.car_category_idComboBox.DisplayMember = "Category_name";
            this.car_category_idComboBox.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.car_category_idComboBox.FormattingEnabled = true;
            this.car_category_idComboBox.Location = new System.Drawing.Point(228, 348);
            this.car_category_idComboBox.Name = "car_category_idComboBox";
            this.car_category_idComboBox.Size = new System.Drawing.Size(169, 36);
            this.car_category_idComboBox.TabIndex = 32;
            this.car_category_idComboBox.ValueMember = "Car_category_id";
            // 
            // carcategoryBindingSource
            // 
            this.carcategoryBindingSource.DataMember = "Car_category";
            this.carcategoryBindingSource.DataSource = this.taxiDataSet;
            // 
            // driverTableAdapter
            // 
            this.driverTableAdapter.ClearBeforeFill = true;
            // 
            // car_categoryTableAdapter
            // 
            this.car_categoryTableAdapter.ClearBeforeFill = true;
            // 
            // car_numberTextBox
            // 
            this.car_numberTextBox.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.car_numberTextBox.Location = new System.Drawing.Point(228, 83);
            this.car_numberTextBox.Name = "car_numberTextBox";
            this.car_numberTextBox.Size = new System.Drawing.Size(169, 34);
            this.car_numberTextBox.TabIndex = 33;
            // 
            // modelTextBox
            // 
            this.modelTextBox.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modelTextBox.Location = new System.Drawing.Point(228, 134);
            this.modelTextBox.Name = "modelTextBox";
            this.modelTextBox.Size = new System.Drawing.Size(169, 34);
            this.modelTextBox.TabIndex = 34;
            // 
            // production_yearTextBox
            // 
            this.production_yearTextBox.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.production_yearTextBox.Location = new System.Drawing.Point(228, 240);
            this.production_yearTextBox.Name = "production_yearTextBox";
            this.production_yearTextBox.Size = new System.Drawing.Size(169, 34);
            this.production_yearTextBox.TabIndex = 36;
            this.production_yearTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.production_yearTextBox_KeyPress);
            // 
            // colorTextBox
            // 
            this.colorTextBox.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colorTextBox.Location = new System.Drawing.Point(228, 187);
            this.colorTextBox.Name = "colorTextBox";
            this.colorTextBox.Size = new System.Drawing.Size(169, 34);
            this.colorTextBox.TabIndex = 35;
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ErrorLabel.AutoSize = true;
            this.ErrorLabel.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorLabel.ForeColor = System.Drawing.Color.IndianRed;
            this.ErrorLabel.Location = new System.Drawing.Point(42, 391);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(0, 20);
            this.ErrorLabel.TabIndex = 37;
            // 
            // CarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 553);
            this.Controls.Add(this.ErrorLabel);
            this.Controls.Add(this.production_yearTextBox);
            this.Controls.Add(this.colorTextBox);
            this.Controls.Add(this.modelTextBox);
            this.Controls.Add(this.car_numberTextBox);
            this.Controls.Add(this.car_category_idComboBox);
            this.Controls.Add(this.driver_idComboBox);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(car_numberLabel);
            this.Controls.Add(modelLabel);
            this.Controls.Add(colorLabel);
            this.Controls.Add(production_yearLabel);
            this.Controls.Add(driver_idLabel);
            this.Controls.Add(car_category_idLabel);
            this.MaximumSize = new System.Drawing.Size(500, 600);
            this.MinimumSize = new System.Drawing.Size(500, 600);
            this.Name = "CarForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CarForm";
            this.Load += new System.EventHandler(this.CarForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.taxiDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.driverBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carcategoryBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TaxiDataSet taxiDataSet;
        private System.Windows.Forms.BindingSource carBindingSource;
        private TaxiDataSetTableAdapters.CarTableAdapter carTableAdapter;
        private TaxiDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.ComboBox driver_idComboBox;
        private System.Windows.Forms.ComboBox car_category_idComboBox;
        private System.Windows.Forms.BindingSource driverBindingSource;
        private TaxiDataSetTableAdapters.DriverTableAdapter driverTableAdapter;
        private System.Windows.Forms.BindingSource carcategoryBindingSource;
        private TaxiDataSetTableAdapters.Car_categoryTableAdapter car_categoryTableAdapter;
        private System.Windows.Forms.TextBox car_numberTextBox;
        private System.Windows.Forms.TextBox modelTextBox;
        private System.Windows.Forms.TextBox production_yearTextBox;
        private System.Windows.Forms.TextBox colorTextBox;
        private System.Windows.Forms.Label ErrorLabel;
    }
}