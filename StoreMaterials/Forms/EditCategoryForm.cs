using StoreMaterials.Models;
using StoreMaterials.DataService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace StoreMaterials.Forms
{
    public partial class EditCategoryForm : Form
    {
        public Category Category { get; private set; }
        private List<Category> _categories; // Список существующих категорий
        private readonly DataService.DataService _dataService; // Сервис для работы с данными

        public EditCategoryForm(Category category = null, List<Category> categories = null, DataService.DataService dataService = null)
        {
            InitializeComponent();
            Category = category ?? new Category();
            _categories = categories ?? new List<Category>();
            _dataService = dataService ?? new DataService.DataService(); // Инициализация сервиса

            // Заполняем ComboBox существующими ID (исключаем категорию с Id = -1)
            if (_categories != null && _categories.Any())
            {
                // Фильтруем категории, исключая Id = -1
                var categoryDisplayList = _categories
                    .Where(c => c.Id != -1) // Исключаем категорию с Id = -1
                    .Select(c => new
                    {
                        Id = c.Id,
                        DisplayText = $"{c.Id} - {c.CategoryName}" // Формат отображения
                    }).ToList();

                categoryIdComboBox.DataSource = categoryDisplayList;
                categoryIdComboBox.DisplayMember = "DisplayText"; // Отображаемое поле
                categoryIdComboBox.ValueMember = "Id"; // Значение, которое будет выбрано
                categoryIdComboBox.SelectedIndex = -1; // Ничего не выбрано по умолчанию
            }

            // Если редактируем существующую категорию, заполняем поля
            if (Category.Id > 0)
            {
                categoryIdComboBox.SelectedValue = Category.Id;
                categoryNameTextBox.Text = Category.CategoryName;
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (categoryIdComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Выберите ID категории для редактирования.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(categoryNameTextBox.Text))
            {
                MessageBox.Show("Название категории не может быть пустым!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int selectedId = (int)categoryIdComboBox.SelectedValue;
            var existingCategory = _categories.FirstOrDefault(c => c.Id == selectedId);

            if (existingCategory == null)
            {
                MessageBox.Show("Категория с таким ID не найдена!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Обновляем данные категории
            existingCategory.CategoryName = categoryNameTextBox.Text;

            // Сохраняем изменения в JSON
            try
            {
                _dataService.SaveCategories(_categories);
                MessageBox.Show("Категория успешно обновлена!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сохранении данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}