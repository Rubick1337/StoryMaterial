using StoreMaterials.Models;
using Xceed.Words.NET;
using Xceed.Document.NET;
using StoreMaterials.DataService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace StoreMaterials.Forms
{
    public class EmptyCategory : Category
    {
        public EmptyCategory()
        {
            Id = -1;
            CategoryName = "";
        }
    }

    public class EmptyMaterial : Material
    {
        public EmptyMaterial()
        {
            Id = -1;
            MaterialName = "";
        }
    }

    public partial class MainForm : Form
    {
        private readonly DataService.DataService _dataService;
        private List<Sale> _sales;
        private List<Category> _categories;
        private List<Material> _materials;

        // Элементы для сортировки
        private System.Windows.Forms.GroupBox sortGroupBox;
        private System.Windows.Forms.CheckBox sortCategoryCheckBox;
        private System.Windows.Forms.CheckBox sortMaterialCheckBox;
        private System.Windows.Forms.CheckBox sortDateCheckBox;
        private System.Windows.Forms.CheckBox sortCustomerCheckBox;
        private System.Windows.Forms.RadioButton sortAscendingRadioButton;
        private System.Windows.Forms.RadioButton sortDescendingRadioButton;
        private System.Windows.Forms.Button sortButton;

        public MainForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle; // Запрет изменения размеров
            this.MaximizeBox = false; // Отключение кнопки "Развернуть"
            this.Width = 850; // Фиксированная ширина
            this.Height = 920; // Фиксированная высота
            _dataService = new DataService.DataService();
            LoadData();
            InitializeDataGridViews();
        }

        private void LoadData()
        {
            try
            {
                _sales = _dataService.LoadSales();
                _categories = _dataService.LoadCategories();
                _materials = _dataService.LoadMaterials();

                if (_sales == null || _categories == null || _materials == null)
                {
                    MessageBox.Show("Ошибка загрузки данных. Проверьте JSON-файлы.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Связываем данные
                foreach (var sale in _sales)
                {
                    var material = _materials.FirstOrDefault(m => m.Id == sale.MaterialId);
                    if (material != null)
                    {
                        sale.MaterialName = material.MaterialName; // Заполняем название материала
                        var category = _categories.FirstOrDefault(c => c.Id == material.CategoryId);
                        if (category != null)
                        {
                            sale.CategoryName = category.CategoryName; // Заполняем название категории
                        }
                        else
                        {
                            sale.CategoryName = "Данные удалены"; // Если категория не найдена
                        }
                    }
                    else
                    {
                        sale.MaterialName = "Данные удалены"; // Если материал не найден
                        sale.CategoryName = "Данные удалены"; // Если категория не найдена
                    }
                }

                // Создаем список для ComboBox с пустым значением
                var categoriesWithEmpty = new List<Category> { new EmptyCategory() };
                categoriesWithEmpty.AddRange(_categories);

                var materialsWithEmpty = new List<Material> { new EmptyMaterial() };
                materialsWithEmpty.AddRange(_materials);

                // Заполняем ComboBox для категорий и материалов
                searchCategoryComboBox.DataSource = categoriesWithEmpty;
                searchCategoryComboBox.DisplayMember = "CategoryName";
                searchCategoryComboBox.ValueMember = "Id";
                searchCategoryComboBox.SelectedIndex = 0;

                searchMaterialComboBox.DataSource = materialsWithEmpty;
                searchMaterialComboBox.DisplayMember = "MaterialName";
                searchMaterialComboBox.ValueMember = "Id";
                searchMaterialComboBox.SelectedIndex = 0;

                // Устанавливаем начальные даты для фильтров
                searchDateFromPicker.Value = DateTime.Now.AddMonths(-1);
                searchDateToPicker.Value = DateTime.Now;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void refreshDataButton_Click(object sender, EventArgs e)
        {
            LoadData(); // Перезагружаем данные
            InitializeDataGridViews(); // Обновляем таблицу
            UpdateCategoryComboBox(); // Обновляем ComboBox для категорий
            UpdateMaterialComboBox(); // Обновляем ComboBox для материалов
            MessageBox.Show("Данные успешно обновлены!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void InitializeDataGridViews()
        {
            // Настройка DataGridView для продаж
            salesDataGridView.AutoGenerateColumns = false;
            salesDataGridView.Columns.Clear();
            salesDataGridView.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "SaleId", HeaderText = "Учетный номер продажи" });
            salesDataGridView.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "SaleDate", HeaderText = "Дата продажи" });
            salesDataGridView.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "MaterialName", HeaderText = "Наименование материала" });
            salesDataGridView.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "CategoryName", HeaderText = "Категория" });
            salesDataGridView.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Unit", HeaderText = "Единицы измерения" });
            salesDataGridView.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "UnitPrice", HeaderText = "Цена за единицу" });
            salesDataGridView.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "DeliveryCost", HeaderText = "Стоимость доставки" });
            salesDataGridView.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Discount", HeaderText = "Скидка" });
            salesDataGridView.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "CustomerName", HeaderText = "ФИО покупателя" });

            salesDataGridView.DataSource = _sales;
        }

        private void resetFiltersButton_Click(object sender, EventArgs e)
        {
            // Сброс всех фильтров
            searchCustomerTextBox.Text = string.Empty;
            searchCategoryComboBox.SelectedIndex = 0;
            searchMaterialComboBox.SelectedIndex = 0;
            searchDateFromPicker.Value = DateTime.Now.AddMonths(-1);
            searchDateToPicker.Value = DateTime.Now;

            // Обновление DataGridView
            salesDataGridView.DataSource = null;
            salesDataGridView.DataSource = _sales;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            // Поиск по ФИО покупателя, категории и наименованию материала
            var searchCustomer = searchCustomerTextBox.Text.ToLower();
            var searchCategory = searchCategoryComboBox.SelectedItem as Category;
            var searchMaterial = searchMaterialComboBox.SelectedItem as Material;

            var filteredSales = _sales.FindAll(s =>
                (string.IsNullOrEmpty(searchCustomer) || s.CustomerName.ToLower().Contains(searchCustomer)) &&
                (searchCategory == null || searchCategory.Id == -1 || s.CategoryName == searchCategory.CategoryName) &&
                (searchMaterial == null || searchMaterial.Id == -1 || s.MaterialName == searchMaterial.MaterialName)
            );

            salesDataGridView.DataSource = null;
            salesDataGridView.DataSource = filteredSales;
        }

        private void searchDateButton_Click(object sender, EventArgs e)
        {
            // Поиск по дате (период или конкретная дата)
            var dateFrom = searchDateFromPicker.Value.Date;
            var dateTo = searchDateToPicker.Value.Date;

            var filteredSales = _sales.FindAll(s =>
                s.SaleDate.Date >= dateFrom && s.SaleDate.Date <= dateTo
            );

            salesDataGridView.DataSource = null;
            salesDataGridView.DataSource = filteredSales;
        }

        private void resetDateButton_Click(object sender, EventArgs e)
        {
            // Сброс фильтров по дате
            searchDateFromPicker.Value = DateTime.Now.AddMonths(-1);
            searchDateToPicker.Value = DateTime.Now;

            // Обновление DataGridView
            salesDataGridView.DataSource = null;
            salesDataGridView.DataSource = _sales;
        }

        private void addSaleButton_Click(object sender, EventArgs e)
        {
            var addForm = new AddSaleForm(_materials);
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                // Устанавливаем уникальный ID для новой записи
                addForm.NewSale.SaleId = _sales.Count + 1;

                // Добавляем новую запись в список
                _sales.Add(addForm.NewSale);

                // Сохраняем изменения в JSON
                _dataService.SaveSales(_sales);

                // Обновляем DataGridView
                salesDataGridView.DataSource = null;
                salesDataGridView.DataSource = _sales;
                LoadData();
                InitializeDataGridViews();
            }
        }

        private void editSaleButton_Click(object sender, EventArgs e)
        {
            if (salesDataGridView.SelectedRows.Count > 0)
            {
                var selectedSale = salesDataGridView.SelectedRows[0].DataBoundItem as Sale;
                var editForm = new EditSaleForm(selectedSale, _materials);
                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    _dataService.SaveSales(_sales);
                    salesDataGridView.DataSource = null;
                    salesDataGridView.DataSource = _sales;
                    LoadData();
                    InitializeDataGridViews();
                }
            }
        }

        private void deleteSaleButton_Click(object sender, EventArgs e)
        {
            if (salesDataGridView.SelectedRows.Count > 0)
            {
                var selectedSale = salesDataGridView.SelectedRows[0].DataBoundItem as Sale;
                var result = MessageBox.Show(
                    "Вы уверены, что хотите удалить эту запись?",
                    "Подтверждение удаления",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (result == DialogResult.Yes)
                {
                    _sales.Remove(selectedSale);
                    _dataService.SaveSales(_sales);
                    salesDataGridView.DataSource = null;
                    salesDataGridView.DataSource = _sales;
                    LoadData();
                    InitializeDataGridViews();
                }
            }
        }

        private void addCategoryButton_Click(object sender, EventArgs e)
        {
            var addForm = new AddCategoryForm();
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                _categories.Add(addForm.Category);
                _dataService.SaveCategories(_categories);
                UpdateCategoryComboBox();
                LoadData();
                InitializeDataGridViews();
            }
        }

        private void editCategoryButton_Click(object sender, EventArgs e)
        {
            if (searchCategoryComboBox.SelectedItem is Category selectedCategory)
            {
                var editForm = new EditCategoryForm(selectedCategory, _categories);
                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    // Обновляем данные в списке категорий
                    var updatedCategory = _categories.FirstOrDefault(c => c.Id == selectedCategory.Id);
                    if (updatedCategory != null)
                    {
                        updatedCategory.CategoryName = editForm.Category.CategoryName;
                    }

                    _dataService.SaveCategories(_categories);
                    UpdateCategoryComboBox();
                    LoadData();
                    InitializeDataGridViews();
                }
            }
            else
            {
                MessageBox.Show("Выберите категорию для редактирования.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void deleteCategoryButton_Click(object sender, EventArgs e)
        {
            // Открываем форму удаления категории
            var deleteForm = new DeleteCategoryForm(_categories);
            var result = deleteForm.ShowDialog();

            // Если пользователь подтвердил удаление
            if (result == DialogResult.OK)
            {
                // Обновляем список категорий и сохраняем изменения
                _categories = deleteForm.Categories; // Обновляем список категорий
                _dataService.SaveCategories(_categories); // Сохраняем изменения
                UpdateCategoryComboBox(); // Обновляем ComboBox
                LoadData();
                InitializeDataGridViews();
            }
        }

        private void addMaterialButton_Click(object sender, EventArgs e)
        {
            var addForm = new AddMaterialForm(_categories);
            if (addForm.ShowDialog() == DialogResult.OK)
            {

                // Обновляем ComboBox
                UpdateMaterialComboBox();
                LoadData();
                InitializeDataGridViews();
            }
        }

        private void editMaterialButton_Click(object sender, EventArgs e)
        {
            if (searchMaterialComboBox.SelectedItem is Material selectedMaterial)
            {
                var editForm = new EditMaterialForm(selectedMaterial, _categories, _materials);
                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    // Сохраняем изменения в JSON
                    _dataService.SaveMaterials(_materials);

                    // Обновляем ComboBox
                    UpdateMaterialComboBox();
                    LoadData();
                    InitializeDataGridViews();
                }
            }
            else
            {
                MessageBox.Show("Выберите материал для редактирования.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void deleteMaterialButton_Click(object sender, EventArgs e)
        {
            var deleteForm = new DeleteMaterialForm(_materials, _categories);
            if (deleteForm.ShowDialog() == DialogResult.OK)
            {
                // Обновляем список материалов
                _materials = deleteForm.Materials;

                // Сохраняем изменения в JSON
                _dataService.SaveMaterials(_materials);

                // Обновляем ComboBox
                UpdateMaterialComboBox();
                LoadData();
                InitializeDataGridViews();
            }
        }

        private void UpdateCategoryComboBox()
        {
            var categoriesWithEmpty = new List<Category> { new EmptyCategory() };
            categoriesWithEmpty.AddRange(_categories);

            searchCategoryComboBox.DataSource = null;
            searchCategoryComboBox.DataSource = categoriesWithEmpty;
            searchCategoryComboBox.DisplayMember = "CategoryName";
            searchCategoryComboBox.ValueMember = "Id";
            searchCategoryComboBox.SelectedIndex = 0;
        }

        private void UpdateMaterialComboBox()
        {
            var materialsWithEmpty = new List<Material> { new EmptyMaterial() };
            materialsWithEmpty.AddRange(_materials);

            searchMaterialComboBox.DataSource = null;
            searchMaterialComboBox.DataSource = materialsWithEmpty;
            searchMaterialComboBox.DisplayMember = "MaterialName";
            searchMaterialComboBox.ValueMember = "Id";
            searchMaterialComboBox.SelectedIndex = 0;
        }

        private void generateReportButton_Click(object sender, EventArgs e)
        {
            // Открываем модальное окно для выбора типа отчета и диапазона дат
            var reportForm = new ReportForm();
            if (reportForm.ShowDialog() == DialogResult.OK)
            {
                // Получаем выбранные данные
                string reportType = reportForm.SelectedReportType;
                DateTime dateFrom = reportForm.SelectedDateFrom; // Начальная дата
                DateTime dateTo = reportForm.SelectedDateTo;   // Конечная дата

                // Генерация отчета в зависимости от выбранного типа
                switch (reportType)
                {
                    case "Отчет по продажам":
                        GenerateSalesReport(dateFrom, dateTo); // Передаем диапазон дат
                        break;
                    case "Отчет по покупателям":
                        GenerateCustomersReport(dateFrom, dateTo); // Передаем диапазон дат
                        break;
                    case "Отчет по категориям":
                        GenerateCategoriesReport(dateFrom, dateTo); // Передаем диапазон дат
                        break;
                    default:
                        MessageBox.Show("Неизвестный тип отчета.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }
            }
        }
private void GenerateSalesReport(DateTime dateFrom, DateTime dateTo)
{
    // Фильтруем продажи по диапазону дат
    var filteredSales = _sales
        .Where(s => s.SaleDate.Date >= dateFrom.Date && s.SaleDate.Date <= dateTo.Date)
        .OrderBy(s => s.SaleDate)
        .ThenBy(s => s.CustomerName)
        .ToList();

    // Создаем новый документ Word
    var doc = DocX.Create(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), $"SalesReport_{dateFrom:yyyyMMdd}_to_{dateTo:yyyyMMdd}.docx"));

    // Добавляем заголовок отчета
    var title = doc.InsertParagraph("Отчет по продажам");
    title.FontSize(14).Bold().Alignment = Alignment.center;
    doc.InsertParagraph($"Период: с {dateFrom:dd.MM.yyyy} по {dateTo:dd.MM.yyyy}").FontSize(12).Alignment = Alignment.center;

    // Создаем таблицу
    var table = doc.AddTable(filteredSales.Count + 1, 8);
    table.Design = TableDesign.LightGrid;

    // Заголовки таблицы
    table.Rows[0].Cells[0].Paragraphs.First().Append("№");
    table.Rows[0].Cells[1].Paragraphs.First().Append("Дата");
    table.Rows[0].Cells[2].Paragraphs.First().Append("ФИО покупателя");
    table.Rows[0].Cells[3].Paragraphs.First().Append("Категория");
    table.Rows[0].Cells[4].Paragraphs.First().Append("Наименование");
    table.Rows[0].Cells[5].Paragraphs.First().Append("Цена с учетом скидки");
    table.Rows[0].Cells[6].Paragraphs.First().Append("Доставка");
    table.Rows[0].Cells[7].Paragraphs.First().Append("Общая стоимость");

    // Заполняем таблицу данными
    for (int i = 0; i < filteredSales.Count; i++)
    {
        var sale = filteredSales[i];
        decimal totalCost = (sale.UnitPrice * (1 - sale.Discount / 100)) + sale.DeliveryCost;

        table.Rows[i + 1].Cells[0].Paragraphs.First().Append((i + 1).ToString());
        table.Rows[i + 1].Cells[1].Paragraphs.First().Append(sale.SaleDate.ToString("dd.MM.yyyy"));
        table.Rows[i + 1].Cells[2].Paragraphs.First().Append(sale.CustomerName);
        table.Rows[i + 1].Cells[3].Paragraphs.First().Append(sale.CategoryName);
        table.Rows[i + 1].Cells[4].Paragraphs.First().Append(sale.MaterialName);
        table.Rows[i + 1].Cells[5].Paragraphs.First().Append((sale.UnitPrice * (1 - sale.Discount / 100)).ToString("F2"));
        table.Rows[i + 1].Cells[6].Paragraphs.First().Append(sale.DeliveryCost.ToString("F2"));
        table.Rows[i + 1].Cells[7].Paragraphs.First().Append(totalCost.ToString("F2"));
    }

    // Вставляем таблицу в документ
    doc.InsertTable(table);

    // Сохраняем документ
    doc.Save();
    MessageBox.Show($"Отчет по продажам за период с {dateFrom:dd.MM.yyyy} по {dateTo:dd.MM.yyyy} сохранен на рабочем столе.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
}

 private void GenerateCustomersReport(DateTime dateFrom, DateTime dateTo)
{
    // Фильтруем продажи по диапазону дат
    var filteredSales = _sales
        .Where(s => s.SaleDate.Date >= dateFrom.Date && s.SaleDate.Date <= dateTo.Date)
        .ToList();

    // Группируем по покупателю
    var reportData = filteredSales
        .GroupBy(s => s.CustomerName)
        .Select(g => new
        {
            CustomerName = g.Key,
            PurchaseCount = g.Count(),
            TotalAmount = g.Sum(s => (decimal)(s.UnitPrice * (1 - s.Discount / 100) + s.DeliveryCost))
        })
        .OrderBy(r => r.CustomerName)
        .ToList();

    // Создаем новый документ Word
    var doc = DocX.Create(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), $"CustomersReport_{dateFrom:yyyyMMdd}_to_{dateTo:yyyyMMdd}.docx"));

    // Добавляем заголовок отчета
    var title = doc.InsertParagraph("Отчет по покупателям");
    title.FontSize(14).Bold().Alignment = Alignment.center;
    doc.InsertParagraph($"Период: с {dateFrom:dd.MM.yyyy} по {dateTo:dd.MM.yyyy}").FontSize(12).Alignment = Alignment.center;

    // Создаем таблицу
    var table = doc.AddTable(reportData.Count + 1, 4);
    table.Design = TableDesign.LightGrid;

    // Заголовки таблицы
    table.Rows[0].Cells[0].Paragraphs.First().Append("№");
    table.Rows[0].Cells[1].Paragraphs.First().Append("ФИО покупателя");
    table.Rows[0].Cells[2].Paragraphs.First().Append("Количество покупок");
    table.Rows[0].Cells[3].Paragraphs.First().Append("Общая сумма");

    // Заполняем таблицу данными
    for (int i = 0; i < reportData.Count; i++)
    {
        var item = reportData[i];
        table.Rows[i + 1].Cells[0].Paragraphs.First().Append((i + 1).ToString());
        table.Rows[i + 1].Cells[1].Paragraphs.First().Append(item.CustomerName);
        table.Rows[i + 1].Cells[2].Paragraphs.First().Append(item.PurchaseCount.ToString());
        table.Rows[i + 1].Cells[3].Paragraphs.First().Append(item.TotalAmount.ToString("F2"));
    }

    // Вставляем таблицу в документ
    doc.InsertTable(table);

    // Сохраняем документ
    doc.Save();
    MessageBox.Show($"Отчет по покупателям за период с {dateFrom:dd.MM.yyyy} по {dateTo:dd.MM.yyyy} сохранен на рабочем столе.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
}

 private void GenerateCategoriesReport(DateTime dateFrom, DateTime dateTo)
{
    // Фильтруем продажи по диапазону дат
    var filteredSales = _sales
        .Where(s => s.SaleDate.Date >= dateFrom.Date && s.SaleDate.Date <= dateTo.Date)
        .ToList();

    // Группируем по месяцам, категории и наименованию
    var reportData = filteredSales
        .GroupBy(s => new { s.SaleDate.Month, s.CategoryName, s.MaterialName })
        .Select(g => new
        {
            Month = g.Key.Month,
            CategoryName = g.Key.CategoryName,
            MaterialName = g.Key.MaterialName,
            TotalSales = g.Count(),
            TotalAmount = g.Sum(s => (decimal)(s.UnitPrice * (1 - s.Discount / 100) + s.DeliveryCost))
        })
        .OrderBy(r => r.Month)
        .ThenBy(r => r.CategoryName)
        .ThenBy(r => r.MaterialName)
        .ToList();

    // Создаем новый документ Word
    var doc = DocX.Create(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), $"CategoriesReport_{dateFrom:yyyyMMdd}_to_{dateTo:yyyyMMdd}.docx"));

    // Добавляем заголовок отчета
    var title = doc.InsertParagraph("Отчет по категориям");
    title.FontSize(14).Bold().Alignment = Alignment.center;
    doc.InsertParagraph($"Период: с {dateFrom:dd.MM.yyyy} по {dateTo:dd.MM.yyyy}").FontSize(12).Alignment = Alignment.center;

    // Создаем таблицу
    var table = doc.AddTable(reportData.Count + 1, 5);
    table.Design = TableDesign.LightGrid;

    // Заголовки таблицы
    table.Rows[0].Cells[0].Paragraphs.First().Append("Месяц");
    table.Rows[0].Cells[1].Paragraphs.First().Append("Категория");
    table.Rows[0].Cells[2].Paragraphs.First().Append("Наименование");
    table.Rows[0].Cells[3].Paragraphs.First().Append("Кол-во единиц");
    table.Rows[0].Cells[4].Paragraphs.First().Append("Общая сумма");

    // Заполняем таблицу данными
    for (int i = 0; i < reportData.Count; i++)
    {
        var item = reportData[i];
        table.Rows[i + 1].Cells[0].Paragraphs.First().Append(new DateTime(2023, item.Month, 1).ToString("MMMM yyyy"));
        table.Rows[i + 1].Cells[1].Paragraphs.First().Append(item.CategoryName);
        table.Rows[i + 1].Cells[2].Paragraphs.First().Append(item.MaterialName);
        table.Rows[i + 1].Cells[3].Paragraphs.First().Append(item.TotalSales.ToString());
        table.Rows[i + 1].Cells[4].Paragraphs.First().Append(item.TotalAmount.ToString("F2"));
    }

    // Вставляем таблицу в документ
    doc.InsertTable(table);

    // Сохраняем документ
    doc.Save();
    MessageBox.Show($"Отчет по категориям за период с {dateFrom:dd.MM.yyyy} по {dateTo:dd.MM.yyyy} сохранен на рабочем столе.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
}

        // Метод для сортировки данных
        private void SortData(List<string> sortFields, ListSortDirection direction)
        {
            var sortedSales = new List<Sale>(_sales);

            if (direction == ListSortDirection.Ascending)
            {
                // Сортировка по возрастанию
                sortedSales = sortedSales
                    .OrderBy(s => sortFields.Contains("Категория") ? s.CategoryName : null)
                    .ThenBy(s => sortFields.Contains("Наименование") ? s.MaterialName : null)
                    .ThenBy(s => sortFields.Contains("Дата покупки") ? s.SaleDate : (DateTime?)null)
                    .ThenBy(s => sortFields.Contains("ФИО покупателя") ? s.CustomerName : null)
                    .ToList();
            }
            else
            {
                // Сортировка по убыванию
                sortedSales = sortedSales
                    .OrderByDescending(s => sortFields.Contains("Категория") ? s.CategoryName : null)
                    .ThenByDescending(s => sortFields.Contains("Наименование") ? s.MaterialName : null)
                    .ThenByDescending(s => sortFields.Contains("Дата покупки") ? s.SaleDate : (DateTime?)null)
                    .ThenByDescending(s => sortFields.Contains("ФИО покупателя") ? s.CustomerName : null)
                    .ToList();
            }

            // Обновляем DataGridView
            salesDataGridView.DataSource = null;
            salesDataGridView.DataSource = sortedSales;
        }
        private void aboutButton_Click(object sender, EventArgs e)
        {
            // Создаем сообщение с информацией о программе
            string aboutMessage = "Программа: Стройматериалы\n\n" +
                                  "Разработчик: Кирилл Бурый\n" +
                                  "Тема: Стройматериалы\n" ;

            // Отображаем сообщение
            MessageBox.Show(aboutMessage, "О программе", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        // Обработчик кнопки сортировки
        private void sortButton_Click(object sender, EventArgs e)
        {
            // Получаем выбранные поля для сортировки
            var sortFields = new List<string>();
            if (sortCategoryCheckBox.Checked) sortFields.Add("Категория");
            if (sortMaterialCheckBox.Checked) sortFields.Add("Наименование");
            if (sortDateCheckBox.Checked) sortFields.Add("Дата покупки");
            if (sortCustomerCheckBox.Checked) sortFields.Add("ФИО покупателя");

            // Определяем направление сортировки
            var direction = sortAscendingRadioButton.Checked ? ListSortDirection.Ascending : ListSortDirection.Descending;

            // Выполняем сортировку
            SortData(sortFields, direction);
        }
    }
}