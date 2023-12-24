namespace TaxiService.Forms
{
    partial class OrdersViewForm
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.titleLabel = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.отриматиЗвітиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orderReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.driverReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setReviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordersDataGridView = new System.Windows.Forms.DataGridView();
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
            this.taxiDataSet = new TaxiService.TaxiDataSet();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.ordersTableAdapter = new TaxiService.TaxiDataSetTableAdapters.OrdersTableAdapter();
            this.ErrorLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BackButton)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ordersDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taxiDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.ErrorLabel);
            this.splitContainer1.Panel1.Controls.Add(this.titleLabel);
            this.splitContainer1.Panel1.Controls.Add(this.BackButton);
            this.splitContainer1.Panel1.Controls.Add(this.menuStrip1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.ordersDataGridView);
            this.splitContainer1.Panel2.Controls.Add(this.splitter1);
            this.splitContainer1.Size = new System.Drawing.Size(782, 503);
            this.splitContainer1.SplitterDistance = 89;
            this.splitContainer1.TabIndex = 0;
            // 
            // titleLabel
            // 
            this.titleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Leelawadee UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(299, 34);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(202, 31);
            this.titleLabel.TabIndex = 5;
            this.titleLabel.Text = "Історія Поїздок";
            // 
            // BackButton
            // 
            this.BackButton.Image = global::TaxiService.Properties.Resources.back;
            this.BackButton.InitialImage = global::TaxiService.Properties.Resources.back;
            this.BackButton.Location = new System.Drawing.Point(12, 33);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(32, 32);
            this.BackButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BackButton.TabIndex = 4;
            this.BackButton.TabStop = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.отриматиЗвітиToolStripMenuItem,
            this.setReviewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(782, 30);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // отриматиЗвітиToolStripMenuItem
            // 
            this.отриматиЗвітиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.orderReportToolStripMenuItem,
            this.driverReportToolStripMenuItem});
            this.отриматиЗвітиToolStripMenuItem.Name = "отриматиЗвітиToolStripMenuItem";
            this.отриматиЗвітиToolStripMenuItem.Size = new System.Drawing.Size(130, 24);
            this.отриматиЗвітиToolStripMenuItem.Text = "Отримати звіти";
            // 
            // orderReportToolStripMenuItem
            // 
            this.orderReportToolStripMenuItem.Name = "orderReportToolStripMenuItem";
            this.orderReportToolStripMenuItem.Size = new System.Drawing.Size(204, 26);
            this.orderReportToolStripMenuItem.Text = "Звіт про поїздку";
            this.orderReportToolStripMenuItem.Click += new System.EventHandler(this.orderReportToolStripMenuItem_Click);
            // 
            // driverReportToolStripMenuItem
            // 
            this.driverReportToolStripMenuItem.Name = "driverReportToolStripMenuItem";
            this.driverReportToolStripMenuItem.Size = new System.Drawing.Size(204, 26);
            this.driverReportToolStripMenuItem.Text = "Звіт про водія";
            this.driverReportToolStripMenuItem.Click += new System.EventHandler(this.driverReportToolStripMenuItem_Click);
            // 
            // setReviewToolStripMenuItem
            // 
            this.setReviewToolStripMenuItem.Name = "setReviewToolStripMenuItem";
            this.setReviewToolStripMenuItem.Size = new System.Drawing.Size(136, 24);
            this.setReviewToolStripMenuItem.Text = "Залишити відгук";
            this.setReviewToolStripMenuItem.Click += new System.EventHandler(this.setReviewToolStripMenuItem_Click);
            // 
            // ordersDataGridView
            // 
            this.ordersDataGridView.AllowUserToAddRows = false;
            this.ordersDataGridView.AllowUserToDeleteRows = false;
            this.ordersDataGridView.AutoGenerateColumns = false;
            this.ordersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ordersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.ordersDataGridView.DataSource = this.ordersBindingSource;
            this.ordersDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ordersDataGridView.Location = new System.Drawing.Point(3, 0);
            this.ordersDataGridView.Name = "ordersDataGridView";
            this.ordersDataGridView.ReadOnly = true;
            this.ordersDataGridView.RowHeadersWidth = 51;
            this.ordersDataGridView.RowTemplate.Height = 24;
            this.ordersDataGridView.Size = new System.Drawing.Size(779, 410);
            this.ordersDataGridView.TabIndex = 1;
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
            this.adressfromDataGridViewTextBoxColumn.ReadOnly = true;
            this.adressfromDataGridViewTextBoxColumn.Width = 125;
            // 
            // adresstoDataGridViewTextBoxColumn
            // 
            this.adresstoDataGridViewTextBoxColumn.DataPropertyName = "Adress_to";
            this.adresstoDataGridViewTextBoxColumn.HeaderText = "Adress_to";
            this.adresstoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.adresstoDataGridViewTextBoxColumn.Name = "adresstoDataGridViewTextBoxColumn";
            this.adresstoDataGridViewTextBoxColumn.ReadOnly = true;
            this.adresstoDataGridViewTextBoxColumn.Width = 125;
            // 
            // creationdatetimeDataGridViewTextBoxColumn
            // 
            this.creationdatetimeDataGridViewTextBoxColumn.DataPropertyName = "Creation_datetime";
            this.creationdatetimeDataGridViewTextBoxColumn.HeaderText = "Creation_datetime";
            this.creationdatetimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.creationdatetimeDataGridViewTextBoxColumn.Name = "creationdatetimeDataGridViewTextBoxColumn";
            this.creationdatetimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.creationdatetimeDataGridViewTextBoxColumn.Width = 125;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            this.priceDataGridViewTextBoxColumn.Width = 125;
            // 
            // orderstateDataGridViewTextBoxColumn
            // 
            this.orderstateDataGridViewTextBoxColumn.DataPropertyName = "Order_state";
            this.orderstateDataGridViewTextBoxColumn.HeaderText = "Order_state";
            this.orderstateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.orderstateDataGridViewTextBoxColumn.Name = "orderstateDataGridViewTextBoxColumn";
            this.orderstateDataGridViewTextBoxColumn.ReadOnly = true;
            this.orderstateDataGridViewTextBoxColumn.Width = 125;
            // 
            // luggageweightDataGridViewTextBoxColumn
            // 
            this.luggageweightDataGridViewTextBoxColumn.DataPropertyName = "Luggage_weight";
            this.luggageweightDataGridViewTextBoxColumn.HeaderText = "Luggage_weight";
            this.luggageweightDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.luggageweightDataGridViewTextBoxColumn.Name = "luggageweightDataGridViewTextBoxColumn";
            this.luggageweightDataGridViewTextBoxColumn.ReadOnly = true;
            this.luggageweightDataGridViewTextBoxColumn.Width = 125;
            // 
            // preferreddatetimeDataGridViewTextBoxColumn
            // 
            this.preferreddatetimeDataGridViewTextBoxColumn.DataPropertyName = "Preferred_datetime";
            this.preferreddatetimeDataGridViewTextBoxColumn.HeaderText = "Preferred_datetime";
            this.preferreddatetimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.preferreddatetimeDataGridViewTextBoxColumn.Name = "preferreddatetimeDataGridViewTextBoxColumn";
            this.preferreddatetimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.preferreddatetimeDataGridViewTextBoxColumn.Width = 125;
            // 
            // passengeridDataGridViewTextBoxColumn
            // 
            this.passengeridDataGridViewTextBoxColumn.DataPropertyName = "Passenger_id";
            this.passengeridDataGridViewTextBoxColumn.HeaderText = "Passenger_id";
            this.passengeridDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.passengeridDataGridViewTextBoxColumn.Name = "passengeridDataGridViewTextBoxColumn";
            this.passengeridDataGridViewTextBoxColumn.ReadOnly = true;
            this.passengeridDataGridViewTextBoxColumn.Width = 125;
            // 
            // driveridDataGridViewTextBoxColumn
            // 
            this.driveridDataGridViewTextBoxColumn.DataPropertyName = "Driver_id";
            this.driveridDataGridViewTextBoxColumn.HeaderText = "Driver_id";
            this.driveridDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.driveridDataGridViewTextBoxColumn.Name = "driveridDataGridViewTextBoxColumn";
            this.driveridDataGridViewTextBoxColumn.ReadOnly = true;
            this.driveridDataGridViewTextBoxColumn.Width = 125;
            // 
            // ordersBindingSource
            // 
            this.ordersBindingSource.DataMember = "Orders";
            this.ordersBindingSource.DataSource = this.taxiDataSet;
            // 
            // taxiDataSet
            // 
            this.taxiDataSet.DataSetName = "TaxiDataSet";
            this.taxiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 410);
            this.splitter1.TabIndex = 0;
            this.splitter1.TabStop = false;
            // 
            // ordersTableAdapter
            // 
            this.ordersTableAdapter.ClearBeforeFill = true;
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ErrorLabel.AutoSize = true;
            this.ErrorLabel.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorLabel.ForeColor = System.Drawing.Color.IndianRed;
            this.ErrorLabel.Location = new System.Drawing.Point(8, 69);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(0, 20);
            this.ErrorLabel.TabIndex = 10;
            // 
            // OrdersViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 503);
            this.Controls.Add(this.splitContainer1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "OrdersViewForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Мої поїздки";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OrdersViewForm_FormClosing);
            this.Load += new System.EventHandler(this.ordersViewForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BackButton)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ordersDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taxiDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.PictureBox BackButton;
        private System.Windows.Forms.Label titleLabel;
        private TaxiDataSet taxiDataSet;
        private System.Windows.Forms.BindingSource ordersBindingSource;
        private TaxiDataSetTableAdapters.OrdersTableAdapter ordersTableAdapter;
        private System.Windows.Forms.DataGridView ordersDataGridView;
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
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem отриматиЗвітиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orderReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem driverReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setReviewToolStripMenuItem;
        private System.Windows.Forms.Label ErrorLabel;
    }
}