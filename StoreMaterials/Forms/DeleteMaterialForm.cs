using StoreMaterials.Models;
using StoreMaterials.DataService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace StoreMaterials.Forms
{
    public partial class DeleteMaterialForm : Form
    {
        public List<Material> Materials { get; private set; } // Список материалов
        private readonly DataService.DataService _dataService; // Сервис для работы с данными
        private List<Category> _categories; // Список категорий (для отображения названия категории)

        public DeleteMaterialForm(List<Material> materials = null, List<Category> categories = null, DataService.DataService dataService = null)
        {
            InitializeComponent();
            Materials = materials ?? new List<Material>();
            _categories = categories ?? new List<Category>();
            _dataService = dataService ?? new DataService.DataService(); // Инициализация сервиса

            // Заполняем ComboBox материалами (исключаем материал с Id = -1)
            if (Materials != null && Materials.Any())
            {
                // Фильтруем материалы, исключая Id = -1
                var materialDisplayList = Materials
                    .Where(m => m.Id != -1) // Исключаем материал с Id = -1
                    .Select(m => new
                    {
                        Id = m.Id,
                        DisplayText = $"{m.Id} - {m.MaterialName} (Категория: {_categories.FirstOrDefault(c => c.Id == m.CategoryId)?.CategoryName ?? "Неизвестно"})"
                    }).ToList();

                materialComboBox.DataSource = materialDisplayList;
                materialComboBox.DisplayMember = "DisplayText"; // Отображаемое поле
                materialComboBox.ValueMember = "Id"; // Значение, которое будет выбрано
                materialComboBox.SelectedIndex = -1; // Ничего не выбрано по умолчанию
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (materialComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Выберите материал для удаления.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Получаем выбранный ID
            int selectedId = (int)materialComboBox.SelectedValue;
            var materialToDelete = Materials.FirstOrDefault(m => m.Id == selectedId);

            if (materialToDelete == null)
            {
                MessageBox.Show("Материал с таким ID не найден!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Подтверждение удаления
            var result = MessageBox.Show(
                $"Вы уверены, что хотите удалить материал \"{materialToDelete.MaterialName}\"?",
                "Подтверждение удаления",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.Yes)
            {
                // Удаляем материал
                Materials.Remove(materialToDelete);

                // Сохраняем изменения в JSON
                try
                {
                    _dataService.SaveMaterials(Materials);
                    MessageBox.Show($"Материал с ID {selectedId} удален.", "Удаление", MessageBoxButtons.OK, MessageBoxIcon.Information);
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