namespace TaxiService.Forms
{
    partial class StatisticForm
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
            this.статистикаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.driverStatisticToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.carStatisticToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orderStatisticToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.reviewStatisticToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.titleLabel = new System.Windows.Forms.Label();
            this.statisticDataGridView = new System.Windows.Forms.DataGridView();
            this.taxiDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.taxiDataSet = new TaxiService.TaxiDataSet();
            this.errorLabel = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statisticDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taxiDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taxiDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackButton)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.статистикаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(882, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // статистикаToolStripMenuItem
            // 
            this.статистикаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.driverStatisticToolStripMenuItem,
            this.carStatisticToolStripMenuItem,
            this.orderStatisticToolStripMenuItem2,
            this.reviewStatisticToolStripMenuItem1});
            this.статистикаToolStripMenuItem.Name = "статистикаToolStripMenuItem";
            this.статистикаToolStripMenuItem.Size = new System.Drawing.Size(98, 24);
            this.статистикаToolStripMenuItem.Text = "Статистика";
            // 
            // driverStatisticToolStripMenuItem
            // 
            this.driverStatisticToolStripMenuItem.Name = "driverStatisticToolStripMenuItem";
            this.driverStatisticToolStripMenuItem.Size = new System.Drawing.Size(255, 26);
            this.driverStatisticToolStripMenuItem.Text = "Водії статистика";
            this.driverStatisticToolStripMenuItem.Click += new System.EventHandler(this.driverStatisticToolStripMenuItem_Click);
            // 
            // carStatisticToolStripMenuItem
            // 
            this.carStatisticToolStripMenuItem.Name = "carStatisticToolStripMenuItem";
            this.carStatisticToolStripMenuItem.Size = new System.Drawing.Size(255, 26);
            this.carStatisticToolStripMenuItem.Text = "Автомобілі статистика";
            this.carStatisticToolStripMenuItem.Click += new System.EventHandler(this.carStatisticToolStripMenuItem_Click);
            // 
            // orderStatisticToolStripMenuItem2
            // 
            this.orderStatisticToolStripMenuItem2.Name = "orderStatisticToolStripMenuItem2";
            this.orderStatisticToolStripMenuItem2.Size = new System.Drawing.Size(255, 26);
            this.orderStatisticToolStripMenuItem2.Text = "Замовлення статистика";
            this.orderStatisticToolStripMenuItem2.Click += new System.EventHandler(this.orderStatisticToolStripMenuItem2_Click);
            // 
            // reviewStatisticToolStripMenuItem1
            // 
            this.reviewStatisticToolStripMenuItem1.Name = "reviewStatisticToolStripMenuItem1";
            this.reviewStatisticToolStripMenuItem1.Size = new System.Drawing.Size(255, 26);
            this.reviewStatisticToolStripMenuItem1.Text = "Статистика відгуків";
            this.reviewStatisticToolStripMenuItem1.Click += new System.EventHandler(this.reviewStatisticToolStripMenuItem1_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 30);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.errorLabel);
            this.splitContainer1.Panel1.Controls.Add(this.titleLabel);
            this.splitContainer1.Panel1.Controls.Add(this.BackButton);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.statisticDataGridView);
            this.splitContainer1.Size = new System.Drawing.Size(882, 473);
            this.splitContainer1.SplitterDistance = 73;
            this.splitContainer1.TabIndex = 1;
            // 
            // titleLabel
            // 
            this.titleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Leelawadee UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(312, 13);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(275, 31);
            this.titleLabel.TabIndex = 2;
            this.titleLabel.Text = "Перегляд статистики";
            // 
            // statisticDataGridView
            // 
            this.statisticDataGridView.AllowUserToAddRows = false;
            this.statisticDataGridView.AllowUserToDeleteRows = false;
            this.statisticDataGridView.AutoGenerateColumns = false;
            this.statisticDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.statisticDataGridView.DataSource = this.taxiDataSetBindingSource;
            this.statisticDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.statisticDataGridView.Location = new System.Drawing.Point(0, 0);
            this.statisticDataGridView.Name = "statisticDataGridView";
            this.statisticDataGridView.ReadOnly = true;
            this.statisticDataGridView.RowHeadersWidth = 51;
            this.statisticDataGridView.RowTemplate.Height = 24;
            this.statisticDataGridView.Size = new System.Drawing.Size(882, 396);
            this.statisticDataGridView.TabIndex = 0;
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
            // errorLabel
            // 
            this.errorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.errorLabel.AutoSize = true;
            this.errorLabel.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLabel.ForeColor = System.Drawing.Color.IndianRed;
            this.errorLabel.Location = new System.Drawing.Point(8, 53);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(0, 20);
            this.errorLabel.TabIndex = 3;
            // 
            // BackButton
            // 
            this.BackButton.Image = global::TaxiService.Properties.Resources.back;
            this.BackButton.InitialImage = global::TaxiService.Properties.Resources.back;
            this.BackButton.Location = new System.Drawing.Point(12, 12);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(32, 32);
            this.BackButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BackButton.TabIndex = 1;
            this.BackButton.TabStop = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // StatisticForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 503);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "StatisticForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Статистика";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StatisticForm_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.statisticDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taxiDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taxiDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem статистикаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem driverStatisticToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem carStatisticToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reviewStatisticToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem orderStatisticToolStripMenuItem2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PictureBox BackButton;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.DataGridView statisticDataGridView;
        private System.Windows.Forms.BindingSource taxiDataSetBindingSource;
        private TaxiDataSet taxiDataSet;
        private System.Windows.Forms.Label errorLabel;
    }
}