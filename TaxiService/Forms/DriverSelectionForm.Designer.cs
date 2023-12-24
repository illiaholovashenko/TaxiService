namespace TaxiService.Forms
{
    partial class DriverSelectionForm
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
            this.driverBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.taxiDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.taxiDataSet = new TaxiService.TaxiDataSet();
            this.titleLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.driversDataGridView = new System.Windows.Forms.DataGridView();
            this.driveridDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstnameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastnameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.middlenameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phonenumberDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ratingDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.drivingexpirienceDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registrationdateDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthdateDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filterButton = new System.Windows.Forms.Button();
            this.cancelFilterButton = new System.Windows.Forms.Button();
            this.descRadioButton = new System.Windows.Forms.RadioButton();
            this.ascRadioButton = new System.Windows.Forms.RadioButton();
            this.sortComboBox = new System.Windows.Forms.ComboBox();
            this.sortLabel = new System.Windows.Forms.Label();
            this.ageLabel = new System.Windows.Forms.Label();
            this.ageCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.experienceLabel = new System.Windows.Forms.Label();
            this.ratingLabel = new System.Windows.Forms.Label();
            this.ratingCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.carCategoryLabel = new System.Windows.Forms.Label();
            this.categoryCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.filterLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.nextButton = new System.Windows.Forms.Button();
            this.driverTableAdapter = new TaxiService.TaxiDataSetTableAdapters.DriverTableAdapter();
            this.errorLabel = new System.Windows.Forms.Label();
            this.fromExperienceTextBox = new System.Windows.Forms.TextBox();
            this.fromExperienceLabel = new System.Windows.Forms.Label();
            this.toExperienceLabel = new System.Windows.Forms.Label();
            this.toExperienceTextBox = new System.Windows.Forms.TextBox();
            this.inputErrorLabel = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.driverBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taxiDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taxiDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.driversDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackButton)).BeginInit();
            this.SuspendLayout();
            // 
            // driverBindingSource
            // 
            this.driverBindingSource.DataMember = "Driver";
            this.driverBindingSource.DataSource = this.taxiDataSetBindingSource;
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
            // titleLabel
            // 
            this.titleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Leelawadee UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(400, 13);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(195, 31);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "Виберіть водія";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 28);
            this.label1.TabIndex = 12;
            this.label1.Text = "Пошук по ПІБ";
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(12, 117);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(268, 22);
            this.searchTextBox.TabIndex = 0;
            this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
            // 
            // driversDataGridView
            // 
            this.driversDataGridView.AllowUserToAddRows = false;
            this.driversDataGridView.AllowUserToDeleteRows = false;
            this.driversDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.driversDataGridView.AutoGenerateColumns = false;
            this.driversDataGridView.ColumnHeadersHeight = 29;
            this.driversDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.driveridDataGridViewTextBoxColumn1,
            this.firstnameDataGridViewTextBoxColumn1,
            this.lastnameDataGridViewTextBoxColumn1,
            this.middlenameDataGridViewTextBoxColumn1,
            this.phonenumberDataGridViewTextBoxColumn1,
            this.cityDataGridViewTextBoxColumn1,
            this.ratingDataGridViewTextBoxColumn1,
            this.drivingexpirienceDataGridViewTextBoxColumn1,
            this.registrationdateDataGridViewTextBoxColumn1,
            this.emailDataGridViewTextBoxColumn1,
            this.birthdateDataGridViewTextBoxColumn1});
            this.driversDataGridView.DataSource = this.driverBindingSource;
            this.driversDataGridView.Location = new System.Drawing.Point(0, 161);
            this.driversDataGridView.MultiSelect = false;
            this.driversDataGridView.Name = "driversDataGridView";
            this.driversDataGridView.ReadOnly = true;
            this.driversDataGridView.RowHeadersWidth = 51;
            this.driversDataGridView.RowTemplate.Height = 24;
            this.driversDataGridView.Size = new System.Drawing.Size(650, 496);
            this.driversDataGridView.TabIndex = 0;
            this.driversDataGridView.SelectionChanged += new System.EventHandler(this.driversDataGridView_SelectionChanged);
            // 
            // driveridDataGridViewTextBoxColumn1
            // 
            this.driveridDataGridViewTextBoxColumn1.DataPropertyName = "Driver_id";
            this.driveridDataGridViewTextBoxColumn1.HeaderText = "Driver_id";
            this.driveridDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.driveridDataGridViewTextBoxColumn1.Name = "driveridDataGridViewTextBoxColumn1";
            this.driveridDataGridViewTextBoxColumn1.ReadOnly = true;
            this.driveridDataGridViewTextBoxColumn1.Width = 125;
            // 
            // firstnameDataGridViewTextBoxColumn1
            // 
            this.firstnameDataGridViewTextBoxColumn1.DataPropertyName = "First_name";
            this.firstnameDataGridViewTextBoxColumn1.HeaderText = "First_name";
            this.firstnameDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.firstnameDataGridViewTextBoxColumn1.Name = "firstnameDataGridViewTextBoxColumn1";
            this.firstnameDataGridViewTextBoxColumn1.ReadOnly = true;
            this.firstnameDataGridViewTextBoxColumn1.Width = 125;
            // 
            // lastnameDataGridViewTextBoxColumn1
            // 
            this.lastnameDataGridViewTextBoxColumn1.DataPropertyName = "Last_name";
            this.lastnameDataGridViewTextBoxColumn1.HeaderText = "Last_name";
            this.lastnameDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.lastnameDataGridViewTextBoxColumn1.Name = "lastnameDataGridViewTextBoxColumn1";
            this.lastnameDataGridViewTextBoxColumn1.ReadOnly = true;
            this.lastnameDataGridViewTextBoxColumn1.Width = 125;
            // 
            // middlenameDataGridViewTextBoxColumn1
            // 
            this.middlenameDataGridViewTextBoxColumn1.DataPropertyName = "Middle_name";
            this.middlenameDataGridViewTextBoxColumn1.HeaderText = "Middle_name";
            this.middlenameDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.middlenameDataGridViewTextBoxColumn1.Name = "middlenameDataGridViewTextBoxColumn1";
            this.middlenameDataGridViewTextBoxColumn1.ReadOnly = true;
            this.middlenameDataGridViewTextBoxColumn1.Width = 125;
            // 
            // phonenumberDataGridViewTextBoxColumn1
            // 
            this.phonenumberDataGridViewTextBoxColumn1.DataPropertyName = "Phone_number";
            this.phonenumberDataGridViewTextBoxColumn1.HeaderText = "Phone_number";
            this.phonenumberDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.phonenumberDataGridViewTextBoxColumn1.Name = "phonenumberDataGridViewTextBoxColumn1";
            this.phonenumberDataGridViewTextBoxColumn1.ReadOnly = true;
            this.phonenumberDataGridViewTextBoxColumn1.Width = 125;
            // 
            // cityDataGridViewTextBoxColumn1
            // 
            this.cityDataGridViewTextBoxColumn1.DataPropertyName = "City";
            this.cityDataGridViewTextBoxColumn1.HeaderText = "City";
            this.cityDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.cityDataGridViewTextBoxColumn1.Name = "cityDataGridViewTextBoxColumn1";
            this.cityDataGridViewTextBoxColumn1.ReadOnly = true;
            this.cityDataGridViewTextBoxColumn1.Width = 125;
            // 
            // ratingDataGridViewTextBoxColumn1
            // 
            this.ratingDataGridViewTextBoxColumn1.DataPropertyName = "Rating";
            this.ratingDataGridViewTextBoxColumn1.HeaderText = "Rating";
            this.ratingDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.ratingDataGridViewTextBoxColumn1.Name = "ratingDataGridViewTextBoxColumn1";
            this.ratingDataGridViewTextBoxColumn1.ReadOnly = true;
            this.ratingDataGridViewTextBoxColumn1.Width = 125;
            // 
            // drivingexpirienceDataGridViewTextBoxColumn1
            // 
            this.drivingexpirienceDataGridViewTextBoxColumn1.DataPropertyName = "Driving_expirience";
            this.drivingexpirienceDataGridViewTextBoxColumn1.HeaderText = "Driving_expirience";
            this.drivingexpirienceDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.drivingexpirienceDataGridViewTextBoxColumn1.Name = "drivingexpirienceDataGridViewTextBoxColumn1";
            this.drivingexpirienceDataGridViewTextBoxColumn1.ReadOnly = true;
            this.drivingexpirienceDataGridViewTextBoxColumn1.Width = 125;
            // 
            // registrationdateDataGridViewTextBoxColumn1
            // 
            this.registrationdateDataGridViewTextBoxColumn1.DataPropertyName = "Registration_date";
            this.registrationdateDataGridViewTextBoxColumn1.HeaderText = "Registration_date";
            this.registrationdateDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.registrationdateDataGridViewTextBoxColumn1.Name = "registrationdateDataGridViewTextBoxColumn1";
            this.registrationdateDataGridViewTextBoxColumn1.ReadOnly = true;
            this.registrationdateDataGridViewTextBoxColumn1.Width = 125;
            // 
            // emailDataGridViewTextBoxColumn1
            // 
            this.emailDataGridViewTextBoxColumn1.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn1.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.emailDataGridViewTextBoxColumn1.Name = "emailDataGridViewTextBoxColumn1";
            this.emailDataGridViewTextBoxColumn1.ReadOnly = true;
            this.emailDataGridViewTextBoxColumn1.Width = 125;
            // 
            // birthdateDataGridViewTextBoxColumn1
            // 
            this.birthdateDataGridViewTextBoxColumn1.DataPropertyName = "Birth_date";
            this.birthdateDataGridViewTextBoxColumn1.HeaderText = "Birth_date";
            this.birthdateDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.birthdateDataGridViewTextBoxColumn1.Name = "birthdateDataGridViewTextBoxColumn1";
            this.birthdateDataGridViewTextBoxColumn1.ReadOnly = true;
            this.birthdateDataGridViewTextBoxColumn1.Width = 125;
            // 
            // filterButton
            // 
            this.filterButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.filterButton.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterButton.Location = new System.Drawing.Point(830, 706);
            this.filterButton.Name = "filterButton";
            this.filterButton.Size = new System.Drawing.Size(120, 35);
            this.filterButton.TabIndex = 16;
            this.filterButton.Text = "Фільтрувати";
            this.filterButton.UseVisualStyleBackColor = true;
            this.filterButton.Click += new System.EventHandler(this.filterButton_Click);
            // 
            // cancelFilterButton
            // 
            this.cancelFilterButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelFilterButton.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelFilterButton.Location = new System.Drawing.Point(700, 706);
            this.cancelFilterButton.Name = "cancelFilterButton";
            this.cancelFilterButton.Size = new System.Drawing.Size(120, 35);
            this.cancelFilterButton.TabIndex = 15;
            this.cancelFilterButton.Text = "Скасувати";
            this.cancelFilterButton.UseVisualStyleBackColor = true;
            this.cancelFilterButton.Click += new System.EventHandler(this.cancelFilterButton_Click);
            // 
            // descRadioButton
            // 
            this.descRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.descRadioButton.AutoSize = true;
            this.descRadioButton.Location = new System.Drawing.Point(767, 176);
            this.descRadioButton.Name = "descRadioButton";
            this.descRadioButton.Size = new System.Drawing.Size(119, 20);
            this.descRadioButton.TabIndex = 14;
            this.descRadioButton.Text = "За спаданням";
            this.descRadioButton.UseVisualStyleBackColor = true;
            this.descRadioButton.CheckedChanged += new System.EventHandler(this.descRadioButton_CheckedChanged);
            // 
            // ascRadioButton
            // 
            this.ascRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ascRadioButton.AutoSize = true;
            this.ascRadioButton.Checked = true;
            this.ascRadioButton.Location = new System.Drawing.Point(767, 147);
            this.ascRadioButton.Name = "ascRadioButton";
            this.ascRadioButton.Size = new System.Drawing.Size(126, 20);
            this.ascRadioButton.TabIndex = 13;
            this.ascRadioButton.TabStop = true;
            this.ascRadioButton.Text = "За зростанням";
            this.ascRadioButton.UseVisualStyleBackColor = true;
            this.ascRadioButton.CheckedChanged += new System.EventHandler(this.ascRadioButton_CheckedChanged);
            // 
            // sortComboBox
            // 
            this.sortComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sortComboBox.FormattingEnabled = true;
            this.sortComboBox.Items.AddRange(new object[] {
            "За рейтингом",
            "За стажем водіння",
            "За віком",
            "За кількістю поїздок"});
            this.sortComboBox.Location = new System.Drawing.Point(725, 117);
            this.sortComboBox.Name = "sortComboBox";
            this.sortComboBox.Size = new System.Drawing.Size(200, 24);
            this.sortComboBox.TabIndex = 12;
            this.sortComboBox.SelectedIndexChanged += new System.EventHandler(this.sortComboBox_SelectedIndexChanged);
            // 
            // sortLabel
            // 
            this.sortLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sortLabel.AutoSize = true;
            this.sortLabel.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sortLabel.Location = new System.Drawing.Point(684, 84);
            this.sortLabel.Name = "sortLabel";
            this.sortLabel.Size = new System.Drawing.Size(130, 28);
            this.sortLabel.TabIndex = 11;
            this.sortLabel.Text = "Сортування";
            // 
            // ageLabel
            // 
            this.ageLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ageLabel.AutoSize = true;
            this.ageLabel.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ageLabel.Location = new System.Drawing.Point(719, 477);
            this.ageLabel.Name = "ageLabel";
            this.ageLabel.Size = new System.Drawing.Size(30, 20);
            this.ageLabel.TabIndex = 10;
            this.ageLabel.Text = "Вік";
            // 
            // ageCheckedListBox
            // 
            this.ageCheckedListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ageCheckedListBox.FormattingEnabled = true;
            this.ageCheckedListBox.Items.AddRange(new object[] {
            "молодше 20 років",
            "20 - 30 років",
            "30 - 45 років",
            "45 - 60 років",
            "старше 60 років"});
            this.ageCheckedListBox.Location = new System.Drawing.Point(724, 504);
            this.ageCheckedListBox.Name = "ageCheckedListBox";
            this.ageCheckedListBox.Size = new System.Drawing.Size(200, 72);
            this.ageCheckedListBox.TabIndex = 9;
            // 
            // experienceLabel
            // 
            this.experienceLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.experienceLabel.AutoSize = true;
            this.experienceLabel.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.experienceLabel.Location = new System.Drawing.Point(721, 597);
            this.experienceLabel.Name = "experienceLabel";
            this.experienceLabel.Size = new System.Drawing.Size(103, 20);
            this.experienceLabel.TabIndex = 8;
            this.experienceLabel.Text = "Стаж водіння";
            // 
            // ratingLabel
            // 
            this.ratingLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ratingLabel.AutoSize = true;
            this.ratingLabel.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ratingLabel.Location = new System.Drawing.Point(721, 386);
            this.ratingLabel.Name = "ratingLabel";
            this.ratingLabel.Size = new System.Drawing.Size(64, 20);
            this.ratingLabel.TabIndex = 6;
            this.ratingLabel.Text = "Рейтинг";
            // 
            // ratingCheckedListBox
            // 
            this.ratingCheckedListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ratingCheckedListBox.FormattingEnabled = true;
            this.ratingCheckedListBox.Items.AddRange(new object[] {
            "0 - 2",
            "2 - 4",
            "більше 4"});
            this.ratingCheckedListBox.Location = new System.Drawing.Point(726, 409);
            this.ratingCheckedListBox.Name = "ratingCheckedListBox";
            this.ratingCheckedListBox.Size = new System.Drawing.Size(200, 55);
            this.ratingCheckedListBox.TabIndex = 5;
            // 
            // carCategoryLabel
            // 
            this.carCategoryLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.carCategoryLabel.AutoSize = true;
            this.carCategoryLabel.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carCategoryLabel.Location = new System.Drawing.Point(722, 259);
            this.carCategoryLabel.Name = "carCategoryLabel";
            this.carCategoryLabel.Size = new System.Drawing.Size(112, 20);
            this.carCategoryLabel.TabIndex = 4;
            this.carCategoryLabel.Text = "Категорія авто";
            // 
            // categoryCheckedListBox
            // 
            this.categoryCheckedListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.categoryCheckedListBox.FormattingEnabled = true;
            this.categoryCheckedListBox.Items.AddRange(new object[] {
            "Стандарт",
            "Комфорт",
            "Бізнес",
            "Універсал",
            "Дитячий",
            "Мікроавтобус"});
            this.categoryCheckedListBox.Location = new System.Drawing.Point(725, 282);
            this.categoryCheckedListBox.Name = "categoryCheckedListBox";
            this.categoryCheckedListBox.Size = new System.Drawing.Size(200, 89);
            this.categoryCheckedListBox.TabIndex = 3;
            // 
            // filterLabel
            // 
            this.filterLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.filterLabel.AutoSize = true;
            this.filterLabel.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterLabel.Location = new System.Drawing.Point(684, 214);
            this.filterLabel.Name = "filterLabel";
            this.filterLabel.Size = new System.Drawing.Size(92, 28);
            this.filterLabel.TabIndex = 2;
            this.filterLabel.Text = "Фільтри";
            // 
            // priceLabel
            // 
            this.priceLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceLabel.Location = new System.Drawing.Point(12, 697);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(66, 28);
            this.priceLabel.TabIndex = 1;
            this.priceLabel.Text = "Ціна: ";
            // 
            // nextButton
            // 
            this.nextButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.nextButton.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextButton.Location = new System.Drawing.Point(525, 691);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(125, 40);
            this.nextButton.TabIndex = 0;
            this.nextButton.Text = "Далі";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // driverTableAdapter
            // 
            this.driverTableAdapter.ClearBeforeFill = true;
            // 
            // errorLabel
            // 
            this.errorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.errorLabel.AutoSize = true;
            this.errorLabel.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLabel.ForeColor = System.Drawing.Color.IndianRed;
            this.errorLabel.Location = new System.Drawing.Point(12, 660);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(0, 20);
            this.errorLabel.TabIndex = 2;
            // 
            // fromExperienceTextBox
            // 
            this.fromExperienceTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fromExperienceTextBox.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fromExperienceTextBox.Location = new System.Drawing.Point(766, 630);
            this.fromExperienceTextBox.Name = "fromExperienceTextBox";
            this.fromExperienceTextBox.Size = new System.Drawing.Size(50, 27);
            this.fromExperienceTextBox.TabIndex = 17;
            this.fromExperienceTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.fromExperienceTextBox_KeyPress);
            // 
            // fromExperienceLabel
            // 
            this.fromExperienceLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fromExperienceLabel.AutoSize = true;
            this.fromExperienceLabel.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fromExperienceLabel.Location = new System.Drawing.Point(725, 633);
            this.fromExperienceLabel.Name = "fromExperienceLabel";
            this.fromExperienceLabel.Size = new System.Drawing.Size(31, 20);
            this.fromExperienceLabel.TabIndex = 18;
            this.fromExperienceLabel.Text = "Від";
            // 
            // toExperienceLabel
            // 
            this.toExperienceLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.toExperienceLabel.AutoSize = true;
            this.toExperienceLabel.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toExperienceLabel.Location = new System.Drawing.Point(835, 633);
            this.toExperienceLabel.Name = "toExperienceLabel";
            this.toExperienceLabel.Size = new System.Drawing.Size(30, 20);
            this.toExperienceLabel.TabIndex = 20;
            this.toExperienceLabel.Text = "До";
            // 
            // toExperienceTextBox
            // 
            this.toExperienceTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.toExperienceTextBox.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toExperienceTextBox.Location = new System.Drawing.Point(876, 630);
            this.toExperienceTextBox.Name = "toExperienceTextBox";
            this.toExperienceTextBox.Size = new System.Drawing.Size(50, 27);
            this.toExperienceTextBox.TabIndex = 19;
            this.toExperienceTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.toExperienceTextBox_KeyPress);
            // 
            // inputErrorLabel
            // 
            this.inputErrorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.inputErrorLabel.AutoSize = true;
            this.inputErrorLabel.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputErrorLabel.ForeColor = System.Drawing.Color.IndianRed;
            this.inputErrorLabel.Location = new System.Drawing.Point(725, 660);
            this.inputErrorLabel.Name = "inputErrorLabel";
            this.inputErrorLabel.Size = new System.Drawing.Size(0, 20);
            this.inputErrorLabel.TabIndex = 21;
            // 
            // BackButton
            // 
            this.BackButton.Image = global::TaxiService.Properties.Resources.back;
            this.BackButton.InitialImage = global::TaxiService.Properties.Resources.back;
            this.BackButton.Location = new System.Drawing.Point(12, 12);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(32, 32);
            this.BackButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BackButton.TabIndex = 0;
            this.BackButton.TabStop = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // DriverSelectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 753);
            this.Controls.Add(this.inputErrorLabel);
            this.Controls.Add(this.toExperienceLabel);
            this.Controls.Add(this.toExperienceTextBox);
            this.Controls.Add(this.fromExperienceLabel);
            this.Controls.Add(this.fromExperienceTextBox);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.driversDataGridView);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.filterButton);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.cancelFilterButton);
            this.Controls.Add(this.categoryCheckedListBox);
            this.Controls.Add(this.descRadioButton);
            this.Controls.Add(this.filterLabel);
            this.Controls.Add(this.ascRadioButton);
            this.Controls.Add(this.carCategoryLabel);
            this.Controls.Add(this.sortComboBox);
            this.Controls.Add(this.ratingCheckedListBox);
            this.Controls.Add(this.sortLabel);
            this.Controls.Add(this.ratingLabel);
            this.Controls.Add(this.ageLabel);
            this.Controls.Add(this.ageCheckedListBox);
            this.Controls.Add(this.experienceLabel);
            this.Name = "DriverSelectionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Вибір водія";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DriverSelectionForm_FormClosing);
            this.Load += new System.EventHandler(this.DriverSelectionForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.driverBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taxiDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taxiDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.driversDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource taxiDataSetBindingSource;
        private TaxiDataSet taxiDataSet;
        private System.Windows.Forms.BindingSource driverBindingSource;
        private TaxiDataSetTableAdapters.DriverTableAdapter driverTableAdapter;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.PictureBox BackButton;
        private System.Windows.Forms.CheckedListBox categoryCheckedListBox;
        private System.Windows.Forms.Label filterLabel;
        private System.Windows.Forms.Label carCategoryLabel;
        private System.Windows.Forms.Label experienceLabel;
        private System.Windows.Forms.Label ratingLabel;
        private System.Windows.Forms.CheckedListBox ratingCheckedListBox;
        private System.Windows.Forms.Label ageLabel;
        private System.Windows.Forms.CheckedListBox ageCheckedListBox;
        private System.Windows.Forms.RadioButton descRadioButton;
        private System.Windows.Forms.RadioButton ascRadioButton;
        private System.Windows.Forms.ComboBox sortComboBox;
        private System.Windows.Forms.Label sortLabel;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.DataGridView driversDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn driveridDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstnameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastnameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn middlenameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn phonenumberDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ratingDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn drivingexpirienceDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn registrationdateDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthdateDataGridViewTextBoxColumn1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Button cancelFilterButton;
        private System.Windows.Forms.Button filterButton;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.TextBox fromExperienceTextBox;
        private System.Windows.Forms.Label fromExperienceLabel;
        private System.Windows.Forms.Label toExperienceLabel;
        private System.Windows.Forms.TextBox toExperienceTextBox;
        private System.Windows.Forms.Label inputErrorLabel;
    }
}