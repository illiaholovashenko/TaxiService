using GMap.NET.MapProviders;
using GMap.NET;

namespace TaxiService
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MyAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statisticToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.таблиціToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fromLabel = new System.Windows.Forms.Label();
            this.fromTextBox = new System.Windows.Forms.TextBox();
            this.toTextBox = new System.Windows.Forms.TextBox();
            this.toLabel = new System.Windows.Forms.Label();
            this.makeOrderButton = new System.Windows.Forms.Button();
            this.googleMap = new GMap.NET.WindowsForms.GMapControl();
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.taxiDataSet = new TaxiService.TaxiDataSet();
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ordersTableAdapter = new TaxiService.TaxiDataSetTableAdapters.OrdersTableAdapter();
            this.WeatherNotificationLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.taxiDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MyAccountToolStripMenuItem,
            this.ordersToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(682, 30);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MyAccountToolStripMenuItem
            // 
            this.MyAccountToolStripMenuItem.Name = "MyAccountToolStripMenuItem";
            this.MyAccountToolStripMenuItem.Size = new System.Drawing.Size(110, 26);
            this.MyAccountToolStripMenuItem.Text = "Мій профіль";
            this.MyAccountToolStripMenuItem.Click += new System.EventHandler(this.MyAccountToolStripMenuItem_Click);
            // 
            // ordersToolStripMenuItem
            // 
            this.ordersToolStripMenuItem.Name = "ordersToolStripMenuItem";
            this.ordersToolStripMenuItem.Size = new System.Drawing.Size(106, 26);
            this.ordersToolStripMenuItem.Text = "Мої поїздки";
            this.ordersToolStripMenuItem.Click += new System.EventHandler(this.ordersToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statisticToolStripMenuItem,
            this.таблиціToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(99, 26);
            this.aboutToolStripMenuItem.Text = "Про сервіс";
            // 
            // statisticToolStripMenuItem
            // 
            this.statisticToolStripMenuItem.Name = "statisticToolStripMenuItem";
            this.statisticToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.statisticToolStripMenuItem.Text = "Статистика";
            this.statisticToolStripMenuItem.Click += new System.EventHandler(this.statisticToolStripMenuItem_Click);
            // 
            // таблиціToolStripMenuItem
            // 
            this.таблиціToolStripMenuItem.Name = "таблиціToolStripMenuItem";
            this.таблиціToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.таблиціToolStripMenuItem.Text = "Таблиці";
            this.таблиціToolStripMenuItem.Click += new System.EventHandler(this.таблиціToolStripMenuItem_Click);
            // 
            // fromLabel
            // 
            this.fromLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fromLabel.AutoSize = true;
            this.fromLabel.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fromLabel.Location = new System.Drawing.Point(12, 390);
            this.fromLabel.Name = "fromLabel";
            this.fromLabel.Size = new System.Drawing.Size(141, 28);
            this.fromLabel.TabIndex = 3;
            this.fromLabel.Text = "Звідки їдемо:";
            // 
            // fromTextBox
            // 
            this.fromTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fromTextBox.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fromTextBox.Location = new System.Drawing.Point(210, 390);
            this.fromTextBox.MaximumSize = new System.Drawing.Size(760, 34);
            this.fromTextBox.Name = "fromTextBox";
            this.fromTextBox.Size = new System.Drawing.Size(460, 34);
            this.fromTextBox.TabIndex = 4;
            this.fromTextBox.Enter += new System.EventHandler(this.fromTextBox_Enter);
            this.fromTextBox.Leave += new System.EventHandler(this.fromTextBox_Leave);
            // 
            // toTextBox
            // 
            this.toTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.toTextBox.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toTextBox.Location = new System.Drawing.Point(210, 440);
            this.toTextBox.MaximumSize = new System.Drawing.Size(760, 34);
            this.toTextBox.Name = "toTextBox";
            this.toTextBox.Size = new System.Drawing.Size(460, 34);
            this.toTextBox.TabIndex = 6;
            this.toTextBox.Enter += new System.EventHandler(this.toTextBox_Enter);
            this.toTextBox.Leave += new System.EventHandler(this.toTextBox_Leave);
            // 
            // toLabel
            // 
            this.toLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.toLabel.AutoSize = true;
            this.toLabel.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toLabel.Location = new System.Drawing.Point(12, 440);
            this.toLabel.Name = "toLabel";
            this.toLabel.Size = new System.Drawing.Size(126, 28);
            this.toLabel.TabIndex = 5;
            this.toLabel.Text = "Куди їдемо:";
            // 
            // makeOrderButton
            // 
            this.makeOrderButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.makeOrderButton.Location = new System.Drawing.Point(520, 491);
            this.makeOrderButton.MaximumSize = new System.Drawing.Size(150, 40);
            this.makeOrderButton.MinimumSize = new System.Drawing.Size(150, 40);
            this.makeOrderButton.Name = "makeOrderButton";
            this.makeOrderButton.Size = new System.Drawing.Size(150, 40);
            this.makeOrderButton.TabIndex = 7;
            this.makeOrderButton.Text = "Замовити";
            this.makeOrderButton.UseVisualStyleBackColor = true;
            this.makeOrderButton.Click += new System.EventHandler(this.makeOrderButton_Click);
            // 
            // googleMap
            // 
            this.googleMap.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.googleMap.Bearing = 0F;
            this.googleMap.CanDragMap = true;
            this.googleMap.EmptyTileColor = System.Drawing.Color.Navy;
            this.googleMap.GrayScaleMode = false;
            this.googleMap.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.googleMap.LevelsKeepInMemory = 5;
            this.googleMap.Location = new System.Drawing.Point(0, 30);
            this.googleMap.MarkersEnabled = true;
            this.googleMap.MaxZoom = 2;
            this.googleMap.MinZoom = 2;
            this.googleMap.MouseWheelZoomEnabled = true;
            this.googleMap.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.googleMap.Name = "googleMap";
            this.googleMap.NegativeMode = false;
            this.googleMap.PolygonsEnabled = true;
            this.googleMap.RetryLoadTile = 0;
            this.googleMap.RoutesEnabled = true;
            this.googleMap.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.googleMap.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.googleMap.ShowTileGridLines = false;
            this.googleMap.Size = new System.Drawing.Size(682, 315);
            this.googleMap.TabIndex = 8;
            this.googleMap.Zoom = 0D;
            this.googleMap.Load += new System.EventHandler(this.gMapControl1_Load);
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ErrorLabel.AutoSize = true;
            this.ErrorLabel.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorLabel.ForeColor = System.Drawing.Color.IndianRed;
            this.ErrorLabel.Location = new System.Drawing.Point(212, 485);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(0, 20);
            this.ErrorLabel.TabIndex = 9;
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
            // WeatherNotificationLabel
            // 
            this.WeatherNotificationLabel.AutoSize = true;
            this.WeatherNotificationLabel.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WeatherNotificationLabel.ForeColor = System.Drawing.Color.Teal;
            this.WeatherNotificationLabel.Location = new System.Drawing.Point(12, 348);
            this.WeatherNotificationLabel.Name = "WeatherNotificationLabel";
            this.WeatherNotificationLabel.Size = new System.Drawing.Size(0, 20);
            this.WeatherNotificationLabel.TabIndex = 10;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 543);
            this.Controls.Add(this.WeatherNotificationLabel);
            this.Controls.Add(this.ErrorLabel);
            this.Controls.Add(this.googleMap);
            this.Controls.Add(this.makeOrderButton);
            this.Controls.Add(this.toTextBox);
            this.Controls.Add(this.toLabel);
            this.Controls.Add(this.fromTextBox);
            this.Controls.Add(this.fromLabel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.taxiDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MyAccountToolStripMenuItem;
        private System.Windows.Forms.Label fromLabel;
        private System.Windows.Forms.TextBox fromTextBox;
        private System.Windows.Forms.TextBox toTextBox;
        private System.Windows.Forms.Label toLabel;
        private System.Windows.Forms.Button makeOrderButton;
        private System.Windows.Forms.ToolStripMenuItem ordersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private GMap.NET.WindowsForms.GMapControl googleMap;
        private System.Windows.Forms.Label ErrorLabel;
        private TaxiDataSet taxiDataSet;
        private System.Windows.Forms.BindingSource ordersBindingSource;
        private TaxiDataSetTableAdapters.OrdersTableAdapter ordersTableAdapter;
        private System.Windows.Forms.ToolStripMenuItem statisticToolStripMenuItem;
        private System.Windows.Forms.Label WeatherNotificationLabel;
        private System.Windows.Forms.ToolStripMenuItem таблиціToolStripMenuItem;
    }
}

