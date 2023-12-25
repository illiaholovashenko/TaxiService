namespace TaxiService.Forms
{
    partial class TablesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TablesForm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ordersidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adressfromDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresstoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creationdatetimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderstateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.luggageweightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preferreddatetimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passengeridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.driveridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.taxiDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.taxiDataSet = new TaxiService.TaxiDataSet();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.тToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.driversToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.passengersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.carToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.carCategoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редагуванняДанихToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.queryEditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableNameLabel = new System.Windows.Forms.Label();
            this.ordersTableAdapter = new TaxiService.TaxiDataSetTableAdapters.OrdersTableAdapter();
            this.driverBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.driverTableAdapter = new TaxiService.TaxiDataSetTableAdapters.DriverTableAdapter();
            this.carBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carTableAdapter = new TaxiService.TaxiDataSetTableAdapters.CarTableAdapter();
            this.passengerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.passengerTableAdapter = new TaxiService.TaxiDataSetTableAdapters.PassengerTableAdapter();
            this.reviewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reviewTableAdapter = new TaxiService.TaxiDataSetTableAdapters.ReviewTableAdapter();
            this.carcategoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.car_categoryTableAdapter = new TaxiService.TaxiDataSetTableAdapters.Car_categoryTableAdapter();
            this.ErrorLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taxiDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taxiDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.driverBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passengerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reviewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carcategoryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ordersidDataGridViewTextBoxColumn,
            this.adressfromDataGridViewTextBoxColumn,
            this.adresstoDataGridViewTextBoxColumn,
            this.creationdatetimeDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.orderstateDataGridViewTextBoxColumn,
            this.luggageweightDataGridViewTextBoxColumn,
            this.preferreddatetimeDataGridViewTextBoxColumn,
            this.passengeridDataGridViewTextBoxColumn,
            this.driveridDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.ordersBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 70);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(808, 380);
            this.dataGridView1.TabIndex = 0;
            // 
            // ordersidDataGridViewTextBoxColumn
            // 
            this.ordersidDataGridViewTextBoxColumn.DataPropertyName = "Orders_id";
            this.ordersidDataGridViewTextBoxColumn.HeaderText = "Orders_id";
            this.ordersidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ordersidDataGridViewTextBoxColumn.Name = "ordersidDataGridViewTextBoxColumn";
            this.ordersidDataGridViewTextBoxColumn.ReadOnly = true;
            this.ordersidDataGridViewTextBoxColumn.Width = 125;
            // 
            // adressfromDataGridViewTextBoxColumn
            // 
            this.adressfromDataGridViewTextBoxColumn.DataPropertyName = "Adress_from";
            this.adressfromDataGridViewTextBoxColumn.HeaderText = "Adress_from";
            this.adressfromDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.adressfromDataGridViewTextBoxColumn.Name = "adressfromDataGridViewTextBoxColumn";
            this.adressfromDataGridViewTextBoxColumn.Width = 125;
            // 
            // adresstoDataGridViewTextBoxColumn
            // 
            this.adresstoDataGridViewTextBoxColumn.DataPropertyName = "Adress_to";
            this.adresstoDataGridViewTextBoxColumn.HeaderText = "Adress_to";
            this.adresstoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.adresstoDataGridViewTextBoxColumn.Name = "adresstoDataGridViewTextBoxColumn";
            this.adresstoDataGridViewTextBoxColumn.Width = 125;
            // 
            // creationdatetimeDataGridViewTextBoxColumn
            // 
            this.creationdatetimeDataGridViewTextBoxColumn.DataPropertyName = "Creation_datetime";
            this.creationdatetimeDataGridViewTextBoxColumn.HeaderText = "Creation_datetime";
            this.creationdatetimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.creationdatetimeDataGridViewTextBoxColumn.Name = "creationdatetimeDataGridViewTextBoxColumn";
            this.creationdatetimeDataGridViewTextBoxColumn.Width = 125;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.Width = 125;
            // 
            // orderstateDataGridViewTextBoxColumn
            // 
            this.orderstateDataGridViewTextBoxColumn.DataPropertyName = "Order_state";
            this.orderstateDataGridViewTextBoxColumn.HeaderText = "Order_state";
            this.orderstateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.orderstateDataGridViewTextBoxColumn.Name = "orderstateDataGridViewTextBoxColumn";
            this.orderstateDataGridViewTextBoxColumn.Width = 125;
            // 
            // luggageweightDataGridViewTextBoxColumn
            // 
            this.luggageweightDataGridViewTextBoxColumn.DataPropertyName = "Luggage_weight";
            this.luggageweightDataGridViewTextBoxColumn.HeaderText = "Luggage_weight";
            this.luggageweightDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.luggageweightDataGridViewTextBoxColumn.Name = "luggageweightDataGridViewTextBoxColumn";
            this.luggageweightDataGridViewTextBoxColumn.Width = 125;
            // 
            // preferreddatetimeDataGridViewTextBoxColumn
            // 
            this.preferreddatetimeDataGridViewTextBoxColumn.DataPropertyName = "Preferred_datetime";
            this.preferreddatetimeDataGridViewTextBoxColumn.HeaderText = "Preferred_datetime";
            this.preferreddatetimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.preferreddatetimeDataGridViewTextBoxColumn.Name = "preferreddatetimeDataGridViewTextBoxColumn";
            this.preferreddatetimeDataGridViewTextBoxColumn.Width = 125;
            // 
            // passengeridDataGridViewTextBoxColumn
            // 
            this.passengeridDataGridViewTextBoxColumn.DataPropertyName = "Passenger_id";
            this.passengeridDataGridViewTextBoxColumn.HeaderText = "Passenger_id";
            this.passengeridDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.passengeridDataGridViewTextBoxColumn.Name = "passengeridDataGridViewTextBoxColumn";
            this.passengeridDataGridViewTextBoxColumn.Width = 125;
            // 
            // driveridDataGridViewTextBoxColumn
            // 
            this.driveridDataGridViewTextBoxColumn.DataPropertyName = "Driver_id";
            this.driveridDataGridViewTextBoxColumn.HeaderText = "Driver_id";
            this.driveridDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.driveridDataGridViewTextBoxColumn.Name = "driveridDataGridViewTextBoxColumn";
            this.driveridDataGridViewTextBoxColumn.Width = 125;
            // 
            // ordersBindingSource
            // 
            this.ordersBindingSource.DataMember = "Orders";
            this.ordersBindingSource.DataSource = this.taxiDataSetBindingSource;
            // 
            // taxiDataSetBindingSource
            // 
            this.taxiDataSetBindingSource.DataSource = this.taxiDataSet;
            this.taxiDataSetBindingSource.Position = 0;
            // 
            // taxiDataSet
            // 
            this.taxiDataSet.DataSetName = "TaxiDataSet";
            this.taxiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.BindingSource = this.ordersBindingSource;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator1.Dock = System.Windows.Forms.DockStyle.None;
            this.bindingNavigator1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem});
            this.bindingNavigator1.Location = new System.Drawing.Point(12, 458);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(302, 31);
            this.bindingNavigator1.TabIndex = 1;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 28);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.тToolStripMenuItem,
            this.редагуванняДанихToolStripMenuItem,
            this.queryEditToolStripMenuItem,
            this.mainFormToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(832, 30);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // тToolStripMenuItem
            // 
            this.тToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.driversToolStripMenuItem,
            this.passengersToolStripMenuItem,
            this.ordersToolStripMenuItem,
            this.carToolStripMenuItem,
            this.carCategoryToolStripMenuItem});
            this.тToolStripMenuItem.Name = "тToolStripMenuItem";
            this.тToolStripMenuItem.Size = new System.Drawing.Size(82, 26);
            this.тToolStripMenuItem.Text = "Таблиця";
            // 
            // driversToolStripMenuItem
            // 
            this.driversToolStripMenuItem.Name = "driversToolStripMenuItem";
            this.driversToolStripMenuItem.Size = new System.Drawing.Size(194, 26);
            this.driversToolStripMenuItem.Text = "Водії";
            this.driversToolStripMenuItem.Click += new System.EventHandler(this.driversToolStripMenuItem_Click);
            // 
            // passengersToolStripMenuItem
            // 
            this.passengersToolStripMenuItem.Name = "passengersToolStripMenuItem";
            this.passengersToolStripMenuItem.Size = new System.Drawing.Size(194, 26);
            this.passengersToolStripMenuItem.Text = "Пасажири";
            this.passengersToolStripMenuItem.Click += new System.EventHandler(this.passengersToolStripMenuItem_Click);
            // 
            // ordersToolStripMenuItem
            // 
            this.ordersToolStripMenuItem.Name = "ordersToolStripMenuItem";
            this.ordersToolStripMenuItem.Size = new System.Drawing.Size(194, 26);
            this.ordersToolStripMenuItem.Text = "Замовлення";
            this.ordersToolStripMenuItem.Click += new System.EventHandler(this.ordersToolStripMenuItem_Click);
            // 
            // carToolStripMenuItem
            // 
            this.carToolStripMenuItem.Name = "carToolStripMenuItem";
            this.carToolStripMenuItem.Size = new System.Drawing.Size(194, 26);
            this.carToolStripMenuItem.Text = "Авто";
            this.carToolStripMenuItem.Click += new System.EventHandler(this.carToolStripMenuItem_Click);
            // 
            // carCategoryToolStripMenuItem
            // 
            this.carCategoryToolStripMenuItem.Name = "carCategoryToolStripMenuItem";
            this.carCategoryToolStripMenuItem.Size = new System.Drawing.Size(194, 26);
            this.carCategoryToolStripMenuItem.Text = "Категорія авто";
            this.carCategoryToolStripMenuItem.Click += new System.EventHandler(this.carCategoryToolStripMenuItem_Click);
            // 
            // редагуванняДанихToolStripMenuItem
            // 
            this.редагуванняДанихToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.редагуванняДанихToolStripMenuItem.Name = "редагуванняДанихToolStripMenuItem";
            this.редагуванняДанихToolStripMenuItem.Size = new System.Drawing.Size(155, 26);
            this.редагуванняДанихToolStripMenuItem.Text = "Редагування даних";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(168, 26);
            this.addToolStripMenuItem.Text = "Додати";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(168, 26);
            this.editToolStripMenuItem.Text = "Редагувати";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(168, 26);
            this.deleteToolStripMenuItem.Text = "Видалити";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // queryEditToolStripMenuItem
            // 
            this.queryEditToolStripMenuItem.Name = "queryEditToolStripMenuItem";
            this.queryEditToolStripMenuItem.Size = new System.Drawing.Size(141, 26);
            this.queryEditToolStripMenuItem.Text = "Редактор запитів";
            this.queryEditToolStripMenuItem.Click += new System.EventHandler(this.queryEditToolStripMenuItem_Click);
            // 
            // mainFormToolStripMenuItem
            // 
            this.mainFormToolStripMenuItem.Name = "mainFormToolStripMenuItem";
            this.mainFormToolStripMenuItem.Size = new System.Drawing.Size(90, 26);
            this.mainFormToolStripMenuItem.Text = "MainForm";
            this.mainFormToolStripMenuItem.Click += new System.EventHandler(this.mainFormToolStripMenuItem_Click);
            // 
            // tableNameLabel
            // 
            this.tableNameLabel.AutoSize = true;
            this.tableNameLabel.Font = new System.Drawing.Font("Leelawadee UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableNameLabel.Location = new System.Drawing.Point(12, 42);
            this.tableNameLabel.Name = "tableNameLabel";
            this.tableNameLabel.Size = new System.Drawing.Size(116, 25);
            this.tableNameLabel.TabIndex = 3;
            this.tableNameLabel.Text = "Замовлення";
            // 
            // ordersTableAdapter
            // 
            this.ordersTableAdapter.ClearBeforeFill = true;
            // 
            // driverBindingSource
            // 
            this.driverBindingSource.DataMember = "Driver";
            this.driverBindingSource.DataSource = this.taxiDataSetBindingSource;
            // 
            // driverTableAdapter
            // 
            this.driverTableAdapter.ClearBeforeFill = true;
            // 
            // carBindingSource
            // 
            this.carBindingSource.DataMember = "Car";
            this.carBindingSource.DataSource = this.taxiDataSetBindingSource;
            // 
            // carTableAdapter
            // 
            this.carTableAdapter.ClearBeforeFill = true;
            // 
            // passengerBindingSource
            // 
            this.passengerBindingSource.DataMember = "Passenger";
            this.passengerBindingSource.DataSource = this.taxiDataSetBindingSource;
            // 
            // passengerTableAdapter
            // 
            this.passengerTableAdapter.ClearBeforeFill = true;
            // 
            // reviewBindingSource
            // 
            this.reviewBindingSource.DataMember = "Review";
            this.reviewBindingSource.DataSource = this.taxiDataSetBindingSource;
            // 
            // reviewTableAdapter
            // 
            this.reviewTableAdapter.ClearBeforeFill = true;
            // 
            // carcategoryBindingSource
            // 
            this.carcategoryBindingSource.DataMember = "Car_category";
            this.carcategoryBindingSource.DataSource = this.taxiDataSet;
            // 
            // car_categoryTableAdapter
            // 
            this.car_categoryTableAdapter.ClearBeforeFill = true;
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ErrorLabel.AutoSize = true;
            this.ErrorLabel.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorLabel.ForeColor = System.Drawing.Color.IndianRed;
            this.ErrorLabel.Location = new System.Drawing.Point(502, 458);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(0, 20);
            this.ErrorLabel.TabIndex = 10;
            // 
            // TablesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 503);
            this.Controls.Add(this.ErrorLabel);
            this.Controls.Add(this.tableNameLabel);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dataGridView1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TablesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TablesForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TablesForm_FormClosing);
            this.Load += new System.EventHandler(this.TablesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taxiDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taxiDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.driverBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passengerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reviewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carcategoryBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource taxiDataSetBindingSource;
        private TaxiDataSet taxiDataSet;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem тToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem driversToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem passengersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem carCategoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem carToolStripMenuItem;
        private System.Windows.Forms.Label tableNameLabel;
        private System.Windows.Forms.BindingSource ordersBindingSource;
        private TaxiDataSetTableAdapters.OrdersTableAdapter ordersTableAdapter;
        private System.Windows.Forms.BindingSource driverBindingSource;
        private TaxiDataSetTableAdapters.DriverTableAdapter driverTableAdapter;
        private System.Windows.Forms.BindingSource carBindingSource;
        private TaxiDataSetTableAdapters.CarTableAdapter carTableAdapter;
        private System.Windows.Forms.BindingSource passengerBindingSource;
        private TaxiDataSetTableAdapters.PassengerTableAdapter passengerTableAdapter;
        private System.Windows.Forms.BindingSource reviewBindingSource;
        private TaxiDataSetTableAdapters.ReviewTableAdapter reviewTableAdapter;
        private System.Windows.Forms.ToolStripMenuItem mainFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem queryEditToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редагуванняДанихToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.BindingSource carcategoryBindingSource;
        private TaxiDataSetTableAdapters.Car_categoryTableAdapter car_categoryTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ordersidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adressfromDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresstoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn creationdatetimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderstateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn luggageweightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn preferreddatetimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passengeridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn driveridDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label ErrorLabel;
    }
}