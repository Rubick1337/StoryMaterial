namespace StoreMaterials.Forms
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView salesDataGridView;
        private System.Windows.Forms.FlowLayoutPanel buttonsFlowLayoutPanel;
        private System.Windows.Forms.Button addSaleButton;
        private System.Windows.Forms.Button editSaleButton;
        private System.Windows.Forms.Button deleteSaleButton;
        private System.Windows.Forms.Button generateReportButton;
        private System.Windows.Forms.GroupBox searchParametersGroupBox;
        private System.Windows.Forms.TextBox searchCustomerTextBox;
        private System.Windows.Forms.Label searchCustomerLabel;
        private System.Windows.Forms.Label searchCategoryLabel;
        private System.Windows.Forms.ComboBox searchCategoryComboBox;
        private System.Windows.Forms.Label searchMaterialLabel;
        private System.Windows.Forms.ComboBox searchMaterialComboBox;
        private System.Windows.Forms.Button searchParametersButton;
        private System.Windows.Forms.Button resetParametersButton;
        private System.Windows.Forms.GroupBox searchDateGroupBox;
        private System.Windows.Forms.Label searchDateLabel;
        private System.Windows.Forms.DateTimePicker searchDateFromPicker;
        private System.Windows.Forms.DateTimePicker searchDateToPicker;
        private System.Windows.Forms.Button searchDateButton;
        private System.Windows.Forms.Button resetDateButton;
        private System.Windows.Forms.GroupBox referenceManagementGroupBox; // Группировка для управления справочниками
        private System.Windows.Forms.Button addCategoryButton; // Кнопка добавления категории
        private System.Windows.Forms.Button editCategoryButton; // Кнопка редактирования категории
        private System.Windows.Forms.Button deleteCategoryButton; // Кнопка удаления категории
        private System.Windows.Forms.Button addMaterialButton; // Кнопка добавления материала
        private System.Windows.Forms.Button editMaterialButton; // Кнопка редактирования материала
        private System.Windows.Forms.Button deleteMaterialButton; // Кнопка удаления материала
        private System.Windows.Forms.Button refreshDataButton;
        private System.Windows.Forms.Button aboutButton; // Кнопка "О программе"
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.salesDataGridView = new System.Windows.Forms.DataGridView();
            this.buttonsFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.addSaleButton = new System.Windows.Forms.Button();
            this.editSaleButton = new System.Windows.Forms.Button();
            this.deleteSaleButton = new System.Windows.Forms.Button();
            this.generateReportButton = new System.Windows.Forms.Button();
            this.searchParametersGroupBox = new System.Windows.Forms.GroupBox();
            this.searchCustomerTextBox = new System.Windows.Forms.TextBox();
            this.searchCustomerLabel = new System.Windows.Forms.Label();
            this.searchCategoryLabel = new System.Windows.Forms.Label();
            this.searchCategoryComboBox = new System.Windows.Forms.ComboBox();
            this.searchMaterialLabel = new System.Windows.Forms.Label();
            this.searchMaterialComboBox = new System.Windows.Forms.ComboBox();
            this.searchParametersButton = new System.Windows.Forms.Button();
            this.resetParametersButton = new System.Windows.Forms.Button();
            this.searchDateGroupBox = new System.Windows.Forms.GroupBox();
            this.searchDateLabel = new System.Windows.Forms.Label();
            this.searchDateFromPicker = new System.Windows.Forms.DateTimePicker();
            this.searchDateToPicker = new System.Windows.Forms.DateTimePicker();
            this.searchDateButton = new System.Windows.Forms.Button();
            this.aboutButton = new System.Windows.Forms.Button();
            this.resetDateButton = new System.Windows.Forms.Button();
            this.referenceManagementGroupBox = new System.Windows.Forms.GroupBox();
            this.addCategoryButton = new System.Windows.Forms.Button();
            this.editCategoryButton = new System.Windows.Forms.Button();
            this.deleteCategoryButton = new System.Windows.Forms.Button();
            this.addMaterialButton = new System.Windows.Forms.Button();
            this.editMaterialButton = new System.Windows.Forms.Button();
            this.deleteMaterialButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.salesDataGridView)).BeginInit();
            this.buttonsFlowLayoutPanel.SuspendLayout();
            this.searchParametersGroupBox.SuspendLayout();
            this.searchDateGroupBox.SuspendLayout();
            this.referenceManagementGroupBox.SuspendLayout();
            this.SuspendLayout();

            // 
            // salesDataGridView
            // 
            this.salesDataGridView.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.salesDataGridView.Location = new System.Drawing.Point(12, 30);
            this.salesDataGridView.Name = "salesDataGridView";
            this.salesDataGridView.Size = new System.Drawing.Size(800, 180);
            this.salesDataGridView.TabIndex = 0;

            // 
            // buttonsFlowLayoutPanel
            // 
            this.buttonsFlowLayoutPanel.Controls.Add(this.addSaleButton);
            this.buttonsFlowLayoutPanel.Controls.Add(this.editSaleButton);
            this.buttonsFlowLayoutPanel.Controls.Add(this.deleteSaleButton);
            this.buttonsFlowLayoutPanel.Controls.Add(this.generateReportButton);
            this.buttonsFlowLayoutPanel.Controls.Add(this.aboutButton);
            this.buttonsFlowLayoutPanel.Location = new System.Drawing.Point(12, 400);
            this.buttonsFlowLayoutPanel.Name = "buttonsFlowLayoutPanel";
            this.buttonsFlowLayoutPanel.Size = new System.Drawing.Size(800, 100);
            this.buttonsFlowLayoutPanel.TabIndex = 3;
            this.aboutButton.Location = new System.Drawing.Point(630, 50); // Расположение кнопки
            this.aboutButton.Name = "aboutButton";
            this.aboutButton.Size = new System.Drawing.Size(150, 30);
            this.aboutButton.TabIndex = 6;
            this.aboutButton.Text = "О программе";
            this.aboutButton.UseVisualStyleBackColor = true;
            this.aboutButton.Click += new System.EventHandler(this.aboutButton_Click); // Подключите обработчик события

            // 
            // addSaleButton
            // 
            this.addSaleButton.Location = new System.Drawing.Point(3, 3);
            this.addSaleButton.Name = "addSaleButton";
            this.addSaleButton.Size = new System.Drawing.Size(150, 30);
            this.addSaleButton.TabIndex = 0;
            this.addSaleButton.Text = "Добавить продажу";
            this.addSaleButton.UseVisualStyleBackColor = true;
            this.addSaleButton.Click += new System.EventHandler(this.addSaleButton_Click);

            // 
            // editSaleButton
            // 
            this.editSaleButton.Location = new System.Drawing.Point(159, 3);
            this.editSaleButton.Name = "editSaleButton";
            this.editSaleButton.Size = new System.Drawing.Size(150, 30);
            this.editSaleButton.TabIndex = 1;
            this.editSaleButton.Text = "Редактировать";
            this.editSaleButton.UseVisualStyleBackColor = true;
            this.editSaleButton.Click += new System.EventHandler(this.editSaleButton_Click);

            // 
            // deleteSaleButton
            // 
            this.deleteSaleButton.Location = new System.Drawing.Point(315, 3);
            this.deleteSaleButton.Name = "deleteSaleButton";
            this.deleteSaleButton.Size = new System.Drawing.Size(150, 30);
            this.deleteSaleButton.TabIndex = 2;
            this.deleteSaleButton.Text = "Удалить";
            this.deleteSaleButton.UseVisualStyleBackColor = true;
            this.deleteSaleButton.Click += new System.EventHandler(this.deleteSaleButton_Click);

            // 
            // generateReportButton
            // 
            this.generateReportButton.Location = new System.Drawing.Point(471, 3);
            this.generateReportButton.Name = "generateReportButton";
            this.generateReportButton.Size = new System.Drawing.Size(150, 30);
            this.generateReportButton.TabIndex = 4;
            this.generateReportButton.Text = "Отчет";
            this.generateReportButton.UseVisualStyleBackColor = true;
            this.generateReportButton.Click += new System.EventHandler(this.generateReportButton_Click);

            // 
            // searchParametersGroupBox
            // 
            this.searchParametersGroupBox.Controls.Add(this.searchCustomerTextBox);
            this.searchParametersGroupBox.Controls.Add(this.searchCustomerLabel);
            this.searchParametersGroupBox.Controls.Add(this.searchCategoryLabel);
            this.searchParametersGroupBox.Controls.Add(this.searchCategoryComboBox);
            this.searchParametersGroupBox.Controls.Add(this.searchMaterialLabel);
            this.searchParametersGroupBox.Controls.Add(this.searchMaterialComboBox);
            this.searchParametersGroupBox.Controls.Add(this.searchParametersButton);
            this.searchParametersGroupBox.Controls.Add(this.resetParametersButton);
            this.searchParametersGroupBox.Location = new System.Drawing.Point(12, 520);
            this.searchParametersGroupBox.Name = "searchParametersGroupBox";
            this.searchParametersGroupBox.Size = new System.Drawing.Size(400, 150);
            this.searchParametersGroupBox.TabIndex = 4;
            this.searchParametersGroupBox.TabStop = false;
            this.searchParametersGroupBox.Text = "Поиск по параметрам";

            // 
            // searchCustomerTextBox
            // 
            this.searchCustomerTextBox.Location = new System.Drawing.Point(10, 40);
            this.searchCustomerTextBox.Name = "searchCustomerTextBox";
            this.searchCustomerTextBox.Size = new System.Drawing.Size(150, 20);
            this.searchCustomerTextBox.TabIndex = 0;

            // 
            // searchCustomerLabel
            // 
            this.searchCustomerLabel.AutoSize = true;
            this.searchCustomerLabel.Location = new System.Drawing.Point(10, 20);
            this.searchCustomerLabel.Name = "searchCustomerLabel";
            this.searchCustomerLabel.Size = new System.Drawing.Size(85, 13);
            this.searchCustomerLabel.TabIndex = 1;
            this.searchCustomerLabel.Text = "ФИО покупателя";

            // 
            // searchCategoryLabel
            // 
            this.searchCategoryLabel.AutoSize = true;
            this.searchCategoryLabel.Location = new System.Drawing.Point(10, 70);
            this.searchCategoryLabel.Name = "searchCategoryLabel";
            this.searchCategoryLabel.Size = new System.Drawing.Size(60, 13);
            this.searchCategoryLabel.TabIndex = 2;
            this.searchCategoryLabel.Text = "Категория";

            // 
            // searchCategoryComboBox
            // 
            this.searchCategoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.searchCategoryComboBox.FormattingEnabled = true;
            this.searchCategoryComboBox.Location = new System.Drawing.Point(10, 90);
            this.searchCategoryComboBox.Name = "searchCategoryComboBox";
            this.searchCategoryComboBox.Size = new System.Drawing.Size(150, 21);
            this.searchCategoryComboBox.TabIndex = 3;

            // 
            // searchMaterialLabel
            // 
            this.searchMaterialLabel.AutoSize = true;
            this.searchMaterialLabel.Location = new System.Drawing.Point(180, 20);
            this.searchMaterialLabel.Name = "searchMaterialLabel";
            this.searchMaterialLabel.Size = new System.Drawing.Size(73, 13);
            this.searchMaterialLabel.TabIndex = 4;
            this.searchMaterialLabel.Text = "Наименование";

            // 
            // searchMaterialComboBox
            // 
            this.searchMaterialComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.searchMaterialComboBox.FormattingEnabled = true;
            this.searchMaterialComboBox.Location = new System.Drawing.Point(180, 40);
            this.searchMaterialComboBox.Name = "searchMaterialComboBox";
            this.searchMaterialComboBox.Size = new System.Drawing.Size(150, 21);
            this.searchMaterialComboBox.TabIndex = 5;
            // 
            this.refreshDataButton = new System.Windows.Forms.Button();
            this.refreshDataButton.Location = new System.Drawing.Point(630, 3); // Расположение кнопки
            this.refreshDataButton.Name = "refreshDataButton";
            this.refreshDataButton.Size = new System.Drawing.Size(150, 30);
            this.refreshDataButton.TabIndex = 5;
            this.refreshDataButton.Text = "Обновить данные";
            this.refreshDataButton.UseVisualStyleBackColor = true;
            this.refreshDataButton.Click += new System.EventHandler(this.refreshDataButton_Click); // Подключите обработчик события
            this.buttonsFlowLayoutPanel.Controls.Add(this.refreshDataButton);
            // 
            // searchParametersButton
            // 
            this.searchParametersButton.Location = new System.Drawing.Point(180, 90);
            this.searchParametersButton.Name = "searchParametersButton";
            this.searchParametersButton.Size = new System.Drawing.Size(90, 30);
            this.searchParametersButton.TabIndex = 6;
            this.searchParametersButton.Text = "Поиск";
            this.searchParametersButton.UseVisualStyleBackColor = true;
            this.searchParametersButton.Click += new System.EventHandler(this.searchButton_Click);

            // 
            // resetParametersButton
            // 
            this.resetParametersButton.Location = new System.Drawing.Point(280, 90);
            this.resetParametersButton.Name = "resetParametersButton";
            this.resetParametersButton.Size = new System.Drawing.Size(90, 30);
            this.resetParametersButton.TabIndex = 7;
            this.resetParametersButton.Text = "Сбросить";
            this.resetParametersButton.UseVisualStyleBackColor = true;
            this.resetParametersButton.Click += new System.EventHandler(this.resetFiltersButton_Click);

            // 
            // searchDateGroupBox
            // 
            this.searchDateGroupBox.Controls.Add(this.searchDateLabel);
            this.searchDateGroupBox.Controls.Add(this.searchDateFromPicker);
            this.searchDateGroupBox.Controls.Add(this.searchDateToPicker);
            this.searchDateGroupBox.Controls.Add(this.searchDateButton);
            this.searchDateGroupBox.Controls.Add(this.resetDateButton);
            this.searchDateGroupBox.Location = new System.Drawing.Point(430, 520);
            this.searchDateGroupBox.Name = "searchDateGroupBox";
            this.searchDateGroupBox.Size = new System.Drawing.Size(400, 150);
            this.searchDateGroupBox.TabIndex = 5;
            this.searchDateGroupBox.TabStop = false;
            this.searchDateGroupBox.Text = "Поиск по дате";

            // 
            // searchDateLabel
            // 
            this.searchDateLabel.AutoSize = true;
            this.searchDateLabel.Location = new System.Drawing.Point(10, 20);
            this.searchDateLabel.Name = "searchDateLabel";
            this.searchDateLabel.Size = new System.Drawing.Size(80, 13);
            this.searchDateLabel.TabIndex = 0;
            this.searchDateLabel.Text = "Поиск по дате";

            // 
            // searchDateFromPicker
            // 
            this.searchDateFromPicker.Location = new System.Drawing.Point(10, 40);
            this.searchDateFromPicker.Name = "searchDateFromPicker";
            this.searchDateFromPicker.Size = new System.Drawing.Size(150, 20);
            this.searchDateFromPicker.TabIndex = 1;

            // 
            // searchDateToPicker
            // 
            this.searchDateToPicker.Location = new System.Drawing.Point(10, 70);
            this.searchDateToPicker.Name = "searchDateToPicker";
            this.searchDateToPicker.Size = new System.Drawing.Size(150, 20);
            this.searchDateToPicker.TabIndex = 2;

            // 
            // searchDateButton
            // 
            this.searchDateButton.Location = new System.Drawing.Point(180, 40);
            this.searchDateButton.Name = "searchDateButton";
            this.searchDateButton.Size = new System.Drawing.Size(90, 30);
            this.searchDateButton.TabIndex = 3;
            this.searchDateButton.Text = "Поиск";
            this.searchDateButton.UseVisualStyleBackColor = true;
            this.searchDateButton.Click += new System.EventHandler(this.searchDateButton_Click);

            // 
            // resetDateButton
            // 
            this.resetDateButton.Location = new System.Drawing.Point(280, 40);
            this.resetDateButton.Name = "resetDateButton";
            this.resetDateButton.Size = new System.Drawing.Size(90, 30);
            this.resetDateButton.TabIndex = 4;
            this.resetDateButton.Text = "Сбросить";
            this.resetDateButton.UseVisualStyleBackColor = true;
            this.resetDateButton.Click += new System.EventHandler(this.resetDateButton_Click);

            // 
            // referenceManagementGroupBox
            // 
            this.referenceManagementGroupBox.Controls.Add(this.addCategoryButton);
            this.referenceManagementGroupBox.Controls.Add(this.editCategoryButton);
            this.referenceManagementGroupBox.Controls.Add(this.deleteCategoryButton);
            this.referenceManagementGroupBox.Controls.Add(this.addMaterialButton);
            this.referenceManagementGroupBox.Controls.Add(this.editMaterialButton);
            this.referenceManagementGroupBox.Controls.Add(this.deleteMaterialButton);
            this.referenceManagementGroupBox.Location = new System.Drawing.Point(12, 240);
            this.referenceManagementGroupBox.Name = "referenceManagementGroupBox";
            this.referenceManagementGroupBox.Size = new System.Drawing.Size(800, 150);
            this.referenceManagementGroupBox.TabIndex = 6;
            this.referenceManagementGroupBox.TabStop = false;
            this.referenceManagementGroupBox.Text = "Управление справочниками";

            // 
            // addCategoryButton
            // 
            this.addCategoryButton.Location = new System.Drawing.Point(10, 30);
            this.addCategoryButton.Name = "addCategoryButton";
            this.addCategoryButton.Size = new System.Drawing.Size(150, 50);
            this.addCategoryButton.TabIndex = 0;
            this.addCategoryButton.Text = "Добавить категорию";
            this.addCategoryButton.UseVisualStyleBackColor = true;
            this.addCategoryButton.Click += new System.EventHandler(this.addCategoryButton_Click);
    this.sortGroupBox = new System.Windows.Forms.GroupBox();
    this.sortGroupBox.Location = new System.Drawing.Point(12, 680); // Расположение группы
    this.sortGroupBox.Size = new System.Drawing.Size(800, 100);
    this.sortGroupBox.Text = "Сортировка";
    this.Controls.Add(this.sortGroupBox);

    // CheckBox для выбора полей сортировки
    this.sortCategoryCheckBox = new System.Windows.Forms.CheckBox();
    this.sortCategoryCheckBox.Location = new System.Drawing.Point(10, 20);
    this.sortCategoryCheckBox.Text = "Категория";
    this.sortGroupBox.Controls.Add(this.sortCategoryCheckBox);

    this.sortMaterialCheckBox = new System.Windows.Forms.CheckBox();
    this.sortMaterialCheckBox.Location = new System.Drawing.Point(120, 20);
    this.sortMaterialCheckBox.Text = "Наименование";
    this.sortGroupBox.Controls.Add(this.sortMaterialCheckBox);

    this.sortDateCheckBox = new System.Windows.Forms.CheckBox();
    this.sortDateCheckBox.Location = new System.Drawing.Point(230, 20);
    this.sortDateCheckBox.Text = "Дата покупки";
    this.sortGroupBox.Controls.Add(this.sortDateCheckBox);

    this.sortCustomerCheckBox = new System.Windows.Forms.CheckBox();
    this.sortCustomerCheckBox.Location = new System.Drawing.Point(340, 20);
    this.sortCustomerCheckBox.Text = "ФИО покупателя";
    this.sortGroupBox.Controls.Add(this.sortCustomerCheckBox);

    // RadioButton для выбора направления сортировки
    this.sortAscendingRadioButton = new System.Windows.Forms.RadioButton();
    this.sortAscendingRadioButton.Location = new System.Drawing.Point(10, 50);
    this.sortAscendingRadioButton.Text = "Возрст";
    this.sortAscendingRadioButton.Checked = true; // По умолчанию выбрано
    this.sortGroupBox.Controls.Add(this.sortAscendingRadioButton);

    this.sortDescendingRadioButton = new System.Windows.Forms.RadioButton();
    this.sortDescendingRadioButton.Location = new System.Drawing.Point(120, 50);
    this.sortDescendingRadioButton.Text = "Убыв";
    this.sortGroupBox.Controls.Add(this.sortDescendingRadioButton);

    // Кнопка для выполнения сортировки
    this.sortButton = new System.Windows.Forms.Button();
    this.sortButton.Location = new System.Drawing.Point(230, 50);
    this.sortButton.Size = new System.Drawing.Size(120, 30);
    this.sortButton.Text = "Сортировать";
    this.sortButton.Click += new System.EventHandler(this.sortButton_Click); // Подключите обработчик события
    this.sortGroupBox.Controls.Add(this.sortButton);
            // 
            // editCategoryButton
            // 
            this.editCategoryButton.Location = new System.Drawing.Point(170, 30);
            this.editCategoryButton.Name = "editCategoryButton";
            this.editCategoryButton.Size = new System.Drawing.Size(150, 50);
            this.editCategoryButton.TabIndex = 1;
            this.editCategoryButton.Text = "Редактировать категорию";
            this.editCategoryButton.UseVisualStyleBackColor = true;
            this.editCategoryButton.Click += new System.EventHandler(this.editCategoryButton_Click);

            // 
            // deleteCategoryButton
            // 
            this.deleteCategoryButton.Location = new System.Drawing.Point(330, 30);
            this.deleteCategoryButton.Name = "deleteCategoryButton";
            this.deleteCategoryButton.Size = new System.Drawing.Size(150, 50);
            this.deleteCategoryButton.TabIndex = 2;
            this.deleteCategoryButton.Text = "Удалить категорию";
            this.deleteCategoryButton.UseVisualStyleBackColor = true;
            this.deleteCategoryButton.Click += new System.EventHandler(this.deleteCategoryButton_Click);

            // 
            // addMaterialButton
            // 
            this.addMaterialButton.Location = new System.Drawing.Point(10, 70);
            this.addMaterialButton.Name = "addMaterialButton";
            this.addMaterialButton.Size = new System.Drawing.Size(150, 50);
            this.addMaterialButton.TabIndex = 3;
            this.addMaterialButton.Text = "Добавить материал";
            this.addMaterialButton.UseVisualStyleBackColor = true;
            this.addMaterialButton.Click += new System.EventHandler(this.addMaterialButton_Click);
            this.addMaterialButton.Margin = new  System.Windows.Forms.Padding(0, 10, 0, 0);

            // 
            // editMaterialButton
            // 
            this.editMaterialButton.Location = new System.Drawing.Point(170, 70);
            this.editMaterialButton.Name = "editMaterialButton";
            this.editMaterialButton.Size = new System.Drawing.Size(150, 50);
            this.editMaterialButton.TabIndex = 4;
            this.editMaterialButton.Text = "Редактировать материал";
            this.editMaterialButton.UseVisualStyleBackColor = true;
            this.editMaterialButton.Click += new System.EventHandler(this.editMaterialButton_Click);
            this.editMaterialButton.Margin = new  System.Windows.Forms.Padding(0, 10, 0, 0);

            // 
            // deleteMaterialButton
            // 
            this.deleteMaterialButton.Location = new System.Drawing.Point(330, 70);
            this.deleteMaterialButton.Name = "deleteMaterialButton";
            this.deleteMaterialButton.Size = new System.Drawing.Size(150, 50);
            this.deleteMaterialButton.TabIndex = 5;
            this.deleteMaterialButton.Text = "Удалить материал";
            this.deleteMaterialButton.UseVisualStyleBackColor = true;
            this.deleteMaterialButton.Click += new System.EventHandler(this.deleteMaterialButton_Click);
            this.deleteMaterialButton.Margin = new  System.Windows.Forms.Padding(0, 10, 0, 0);

            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(900, 700);
            this.Controls.Add(this.referenceManagementGroupBox);
            this.Controls.Add(this.searchDateGroupBox);
            this.Controls.Add(this.searchParametersGroupBox);
            this.Controls.Add(this.buttonsFlowLayoutPanel);
            this.Controls.Add(this.salesDataGridView);
            this.Name = "MainForm";
            this.Text = "Магазин-склад 'Все для стройки'";
            ((System.ComponentModel.ISupportInitialize)(this.salesDataGridView)).EndInit();
            this.buttonsFlowLayoutPanel.ResumeLayout(false);
            this.searchParametersGroupBox.ResumeLayout(false);
            this.searchParametersGroupBox.PerformLayout();
            this.searchDateGroupBox.ResumeLayout(false);
            this.searchDateGroupBox.PerformLayout();
            this.referenceManagementGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
        }
    }
}