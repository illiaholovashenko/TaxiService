namespace TaxiService.Forms
{
    partial class OrderForm
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
            System.Windows.Forms.Label adress_fromLabel;
            System.Windows.Forms.Label adress_toLabel;
            System.Windows.Forms.Label creation_datetimeLabel;
            System.Windows.Forms.Label priceLabel;
            System.Windows.Forms.Label order_stateLabel;
            System.Windows.Forms.Label luggage_weightLabel;
            System.Windows.Forms.Label preferred_datetimeLabel;
            System.Windows.Forms.Label passenger_idLabel;
            System.Windows.Forms.Label driver_idLabel;
            this.taxiDataSet = new TaxiService.TaxiDataSet();
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ordersTableAdapter = new TaxiService.TaxiDataSetTableAdapters.OrdersTableAdapter();
            this.tableAdapterManager = new TaxiService.TaxiDataSetTableAdapters.TableAdapterManager();
            this.confirmButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.passenger_idComboBox = new System.Windows.Forms.ComboBox();
            this.passengerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.driver_idComboBox = new System.Windows.Forms.ComboBox();
            this.driverBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.passengerTableAdapter = new TaxiService.TaxiDataSetTableAdapters.PassengerTableAdapter();
            this.driverTableAdapter = new TaxiService.TaxiDataSetTableAdapters.DriverTableAdapter();
            this.order_stateComboBox = new System.Windows.Forms.ComboBox();
            this.adress_fromTextBox = new System.Windows.Forms.TextBox();
            this.adress_toTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.creation_datetimeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.preferred_datetimeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.luggage_weightTextBox = new System.Windows.Forms.TextBox();
            this.ErrorLabel = new System.Windows.Forms.Label();
            adress_fromLabel = new System.Windows.Forms.Label();
            adress_toLabel = new System.Windows.Forms.Label();
            creation_datetimeLabel = new System.Windows.Forms.Label();
            priceLabel = new System.Windows.Forms.Label();
            order_stateLabel = new System.Windows.Forms.Label();
            luggage_weightLabel = new System.Windows.Forms.Label();
            preferred_datetimeLabel = new System.Windows.Forms.Label();
            passenger_idLabel = new System.Windows.Forms.Label();
            driver_idLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.taxiDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passengerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.driverBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // adress_fromLabel
            // 
            adress_fromLabel.AutoSize = true;
            adress_fromLabel.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            adress_fromLabel.Location = new System.Drawing.Point(12, 58);
            adress_fromLabel.Name = "adress_fromLabel";
            adress_fromLabel.Size = new System.Drawing.Size(164, 28);
            adress_fromLabel.TabIndex = 3;
            adress_fromLabel.Text = "Адреса звідки*:";
            // 
            // adress_toLabel
            // 
            adress_toLabel.AutoSize = true;
            adress_toLabel.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            adress_toLabel.Location = new System.Drawing.Point(12, 112);
            adress_toLabel.Name = "adress_toLabel";
            adress_toLabel.Size = new System.Drawing.Size(148, 28);
            adress_toLabel.TabIndex = 5;
            adress_toLabel.Text = "Адреса куди*:";
            // 
            // creation_datetimeLabel
            // 
            creation_datetimeLabel.AutoSize = true;
            creation_datetimeLabel.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            creation_datetimeLabel.Location = new System.Drawing.Point(12, 167);
            creation_datetimeLabel.Name = "creation_datetimeLabel";
            creation_datetimeLabel.Size = new System.Drawing.Size(174, 28);
            creation_datetimeLabel.TabIndex = 7;
            creation_datetimeLabel.Text = "Дата створення:";
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            priceLabel.Location = new System.Drawing.Point(12, 220);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new System.Drawing.Size(69, 28);
            priceLabel.TabIndex = 9;
            priceLabel.Text = "Ціна*:";
            // 
            // order_stateLabel
            // 
            order_stateLabel.AutoSize = true;
            order_stateLabel.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            order_stateLabel.Location = new System.Drawing.Point(12, 274);
            order_stateLabel.Name = "order_stateLabel";
            order_stateLabel.Size = new System.Drawing.Size(198, 28);
            order_stateLabel.TabIndex = 11;
            order_stateLabel.Text = "Стан замовлення*:";
            // 
            // luggage_weightLabel
            // 
            luggage_weightLabel.AutoSize = true;
            luggage_weightLabel.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            luggage_weightLabel.Location = new System.Drawing.Point(12, 329);
            luggage_weightLabel.Name = "luggage_weightLabel";
            luggage_weightLabel.Size = new System.Drawing.Size(137, 28);
            luggage_weightLabel.TabIndex = 13;
            luggage_weightLabel.Text = "Вага багажу:";
            // 
            // preferred_datetimeLabel
            // 
            preferred_datetimeLabel.AutoSize = true;
            preferred_datetimeLabel.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            preferred_datetimeLabel.Location = new System.Drawing.Point(12, 384);
            preferred_datetimeLabel.Name = "preferred_datetimeLabel";
            preferred_datetimeLabel.Size = new System.Drawing.Size(281, 28);
            preferred_datetimeLabel.TabIndex = 15;
            preferred_datetimeLabel.Text = "Бажана дата/час прибуття:";
            // 
            // passenger_idLabel
            // 
            passenger_idLabel.AutoSize = true;
            passenger_idLabel.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            passenger_idLabel.Location = new System.Drawing.Point(12, 438);
            passenger_idLabel.Name = "passenger_idLabel";
            passenger_idLabel.Size = new System.Drawing.Size(105, 28);
            passenger_idLabel.TabIndex = 17;
            passenger_idLabel.Text = "Пасажир:";
            // 
            // driver_idLabel
            // 
            driver_idLabel.AutoSize = true;
            driver_idLabel.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            driver_idLabel.Location = new System.Drawing.Point(12, 492);
            driver_idLabel.Name = "driver_idLabel";
            driver_idLabel.Size = new System.Drawing.Size(71, 28);
            driver_idLabel.TabIndex = 19;
            driver_idLabel.Text = "Водій:";
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Car_categoryTableAdapter = null;
            this.tableAdapterManager.CarTableAdapter = null;
            this.tableAdapterManager.DriverTableAdapter = null;
            this.tableAdapterManager.OrdersTableAdapter = this.ordersTableAdapter;
            this.tableAdapterManager.PassengerTableAdapter = null;
            this.tableAdapterManager.ReviewTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = TaxiService.TaxiDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // confirmButton
            // 
            this.confirmButton.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmButton.Location = new System.Drawing.Point(382, 624);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(160, 55);
            this.confirmButton.TabIndex = 28;
            this.confirmButton.Text = "Підтвердити";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.Location = new System.Drawing.Point(77, 624);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(160, 55);
            this.cancelButton.TabIndex = 27;
            this.cancelButton.Text = "Скасувати";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // passenger_idComboBox
            // 
            this.passenger_idComboBox.DataSource = this.passengerBindingSource;
            this.passenger_idComboBox.DisplayMember = "First_name";
            this.passenger_idComboBox.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passenger_idComboBox.FormattingEnabled = true;
            this.passenger_idComboBox.Location = new System.Drawing.Point(293, 438);
            this.passenger_idComboBox.Name = "passenger_idComboBox";
            this.passenger_idComboBox.Size = new System.Drawing.Size(287, 36);
            this.passenger_idComboBox.TabIndex = 29;
            this.passenger_idComboBox.ValueMember = "Passenger_id";
            // 
            // passengerBindingSource
            // 
            this.passengerBindingSource.DataMember = "Passenger";
            this.passengerBindingSource.DataSource = this.taxiDataSet;
            // 
            // driver_idComboBox
            // 
            this.driver_idComboBox.DataSource = this.driverBindingSource;
            this.driver_idComboBox.DisplayMember = "First_name";
            this.driver_idComboBox.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.driver_idComboBox.FormattingEnabled = true;
            this.driver_idComboBox.Location = new System.Drawing.Point(293, 492);
            this.driver_idComboBox.Name = "driver_idComboBox";
            this.driver_idComboBox.Size = new System.Drawing.Size(287, 36);
            this.driver_idComboBox.TabIndex = 30;
            this.driver_idComboBox.ValueMember = "Driver_id";
            // 
            // driverBindingSource
            // 
            this.driverBindingSource.DataMember = "Driver";
            this.driverBindingSource.DataSource = this.taxiDataSet;
            // 
            // passengerTableAdapter
            // 
            this.passengerTableAdapter.ClearBeforeFill = true;
            // 
            // driverTableAdapter
            // 
            this.driverTableAdapter.ClearBeforeFill = true;
            // 
            // order_stateComboBox
            // 
            this.order_stateComboBox.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.order_stateComboBox.FormattingEnabled = true;
            this.order_stateComboBox.Items.AddRange(new object[] {
            "В очікуванні",
            "Виконується",
            "Виконано",
            "Скасовано"});
            this.order_stateComboBox.Location = new System.Drawing.Point(293, 274);
            this.order_stateComboBox.Name = "order_stateComboBox";
            this.order_stateComboBox.Size = new System.Drawing.Size(287, 36);
            this.order_stateComboBox.TabIndex = 31;
            // 
            // adress_fromTextBox
            // 
            this.adress_fromTextBox.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adress_fromTextBox.Location = new System.Drawing.Point(293, 58);
            this.adress_fromTextBox.Name = "adress_fromTextBox";
            this.adress_fromTextBox.Size = new System.Drawing.Size(287, 34);
            this.adress_fromTextBox.TabIndex = 32;
            // 
            // adress_toTextBox
            // 
            this.adress_toTextBox.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adress_toTextBox.Location = new System.Drawing.Point(293, 112);
            this.adress_toTextBox.Name = "adress_toTextBox";
            this.adress_toTextBox.Size = new System.Drawing.Size(287, 34);
            this.adress_toTextBox.TabIndex = 33;
            // 
            // priceTextBox
            // 
            this.priceTextBox.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceTextBox.Location = new System.Drawing.Point(293, 220);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(287, 34);
            this.priceTextBox.TabIndex = 34;
            this.priceTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.priceTextBox_KeyPress);
            // 
            // creation_datetimeDateTimePicker
            // 
            this.creation_datetimeDateTimePicker.CalendarFont = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creation_datetimeDateTimePicker.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creation_datetimeDateTimePicker.Location = new System.Drawing.Point(293, 167);
            this.creation_datetimeDateTimePicker.Name = "creation_datetimeDateTimePicker";
            this.creation_datetimeDateTimePicker.Size = new System.Drawing.Size(287, 34);
            this.creation_datetimeDateTimePicker.TabIndex = 35;
            // 
            // preferred_datetimeDateTimePicker
            // 
            this.preferred_datetimeDateTimePicker.CalendarFont = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.preferred_datetimeDateTimePicker.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.preferred_datetimeDateTimePicker.Location = new System.Drawing.Point(293, 384);
            this.preferred_datetimeDateTimePicker.Name = "preferred_datetimeDateTimePicker";
            this.preferred_datetimeDateTimePicker.Size = new System.Drawing.Size(287, 34);
            this.preferred_datetimeDateTimePicker.TabIndex = 36;
            // 
            // luggage_weightTextBox
            // 
            this.luggage_weightTextBox.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.luggage_weightTextBox.Location = new System.Drawing.Point(293, 329);
            this.luggage_weightTextBox.Name = "luggage_weightTextBox";
            this.luggage_weightTextBox.Size = new System.Drawing.Size(287, 34);
            this.luggage_weightTextBox.TabIndex = 37;
            this.luggage_weightTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.luggage_weightTextBox_KeyPress);
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ErrorLabel.AutoSize = true;
            this.ErrorLabel.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorLabel.ForeColor = System.Drawing.Color.IndianRed;
            this.ErrorLabel.Location = new System.Drawing.Point(13, 538);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(0, 20);
            this.ErrorLabel.TabIndex = 38;
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 703);
            this.Controls.Add(this.ErrorLabel);
            this.Controls.Add(this.luggage_weightTextBox);
            this.Controls.Add(this.preferred_datetimeDateTimePicker);
            this.Controls.Add(this.creation_datetimeDateTimePicker);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.adress_toTextBox);
            this.Controls.Add(this.adress_fromTextBox);
            this.Controls.Add(this.order_stateComboBox);
            this.Controls.Add(this.driver_idComboBox);
            this.Controls.Add(this.passenger_idComboBox);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(adress_fromLabel);
            this.Controls.Add(adress_toLabel);
            this.Controls.Add(creation_datetimeLabel);
            this.Controls.Add(priceLabel);
            this.Controls.Add(order_stateLabel);
            this.Controls.Add(luggage_weightLabel);
            this.Controls.Add(preferred_datetimeLabel);
            this.Controls.Add(passenger_idLabel);
            this.Controls.Add(driver_idLabel);
            this.MaximumSize = new System.Drawing.Size(610, 750);
            this.MinimumSize = new System.Drawing.Size(610, 750);
            this.Name = "OrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrderForm";
            this.Load += new System.EventHandler(this.OrderForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.taxiDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passengerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.driverBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TaxiDataSet taxiDataSet;
        private System.Windows.Forms.BindingSource ordersBindingSource;
        private TaxiDataSetTableAdapters.OrdersTableAdapter ordersTableAdapter;
        private TaxiDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.ComboBox passenger_idComboBox;
        private System.Windows.Forms.ComboBox driver_idComboBox;
        private System.Windows.Forms.BindingSource passengerBindingSource;
        private TaxiDataSetTableAdapters.PassengerTableAdapter passengerTableAdapter;
        private System.Windows.Forms.BindingSource driverBindingSource;
        private TaxiDataSetTableAdapters.DriverTableAdapter driverTableAdapter;
        private System.Windows.Forms.ComboBox order_stateComboBox;
        private System.Windows.Forms.TextBox adress_fromTextBox;
        private System.Windows.Forms.TextBox adress_toTextBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.DateTimePicker creation_datetimeDateTimePicker;
        private System.Windows.Forms.DateTimePicker preferred_datetimeDateTimePicker;
        private System.Windows.Forms.TextBox luggage_weightTextBox;
        private System.Windows.Forms.Label ErrorLabel;
    }
}