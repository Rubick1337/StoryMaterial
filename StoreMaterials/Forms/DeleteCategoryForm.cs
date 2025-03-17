using StoreMaterials.Models;
using StoreMaterials.DataService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace StoreMaterials.Forms
{
    public partial class DeleteCategoryForm : Form
    {
        public List<Category> Categories { get; private set; } // Список категорий
        private readonly DataService.DataService _dataService; // Сервис для работы с данными

        public DeleteCategoryForm(List<Category> categories = null, DataService.DataService dataService = null)
        {
            InitializeComponent();
            Categories = categories ?? new List<Category>();
            _dataService = dataService ?? new DataService.DataService(); // Инициализация сервиса

            // Заполняем ComboBox существующими категориями (исключаем категорию с Id = -1)
            if (Categories != null && Categories.Any())
            {
                // Фильтруем категории, исключая Id = -1
                var categoryDisplayList = Categories
                    .Where(c => c.Id != -1) // Исключаем категорию с Id = -1
                    .Select(c => new
                    {
                        Id = c.Id,
                        DisplayText = $"{c.Id} - {c.CategoryName}" // Отображаем ID и название
                    }).ToList();

                categoryIdComboBox.DataSource = categoryDisplayList;
                categoryIdComboBox.DisplayMember = "DisplayText"; // Отображаемое поле
                categoryIdComboBox.ValueMember = "Id"; // Значение, которое будет выбрано
                categoryIdComboBox.SelectedIndex = -1; // Ничего не выбрано по умолчанию
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (categoryIdComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Выберите категорию для удаления.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Получаем выбранный ID
            int selectedId = (int)categoryIdComboBox.SelectedValue;
            var categoryToDelete = Categories.FirstOrDefault(c => c.Id == selectedId);

            if (categoryToDelete == null)
            {
                MessageBox.Show("Категория с таким ID не найдена!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Подтверждение удаления
            var result = MessageBox.Show(
                $"Вы уверены, что хотите удалить категорию \"{categoryToDelete.CategoryName}\"?",
                "Подтверждение удаления",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.Yes)
            {
                // Удаляем категорию
                Categories.Remove(categoryToDelete);

                // Сохраняем изменения в JSON
                try
                {
                    _dataService.SaveCategories(Categories);
                    MessageBox.Show($"Категория с ID {selectedId} удалена.", "Удаление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK; // Закрываем форму с результатом OK
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при сохранении данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel; // Закрываем форму с результатом Cancel
            this.Close();
        }
    }
}