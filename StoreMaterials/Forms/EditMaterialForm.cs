using StoreMaterials.Models;
using StoreMaterials.DataService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace StoreMaterials.Forms
{
    public partial class EditMaterialForm : Form
    {
        public Material Material { get; private set; }
        private List<Category> _categories; // Список категорий
        private List<Material> _materials; // Список материалов
        private readonly DataService.DataService _dataService; // Сервис для работы с данными

        public EditMaterialForm(Material material = null, List<Category> categories = null, List<Material> materials = null, DataService.DataService dataService = null)
        {
            InitializeComponent();
            Material = material ?? new Material();
            _categories = categories ?? new List<Category>();
            _materials = materials ?? new List<Material>();
            _dataService = dataService ?? new DataService.DataService(); // Инициализация сервиса

            // Заполняем ComboBox материалами (исключаем пустые значения)
            if (_materials != null && _materials.Any())
            {
                var materialDisplayList = _materials
                    .Where(m => m.Id != -1) // Исключаем материал с Id = -1
                    .Select(m => new
                    {
                        Id = m.Id,
                        DisplayText = $"{m.Id} - {m.MaterialName}" // Формат отображения
                    }).ToList();

                materialIdComboBox.DataSource = materialDisplayList;
                materialIdComboBox.DisplayMember = "DisplayText"; // Отображаемое поле
                materialIdComboBox.ValueMember = "Id"; // Значение, которое будет выбрано
                materialIdComboBox.SelectedIndex = -1; // Ничего не выбрано по умолчанию
            }

            // Заполняем ComboBox категориями (исключаем пустые значения)
            var filteredCategories = _categories
                .Where(c => c.Id != -1) // Исключаем категории с Id = -1
                .ToList();

            categoryComboBox.DataSource = filteredCategories;
            categoryComboBox.DisplayMember = "CategoryName";
            categoryComboBox.ValueMember = "Id";
            categoryComboBox.SelectedIndex = -1; // Ничего не выбрано по умолчанию

            // Если редактируем существующий материал, заполняем поля
            if (Material.Id > 0)
            {
                materialIdComboBox.SelectedValue = Material.Id;
                materialNameTextBox.Text = Material.MaterialName;
                categoryComboBox.SelectedValue = Material.CategoryId;
            }
        }

        private void materialIdComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (materialIdComboBox.SelectedIndex == -1)
                return;

            // Получаем выбранный ID материала
            int selectedId = (int)materialIdComboBox.SelectedValue;
            var selectedMaterial = _materials.FirstOrDefault(m => m.Id == selectedId);

            if (selectedMaterial != null)
            {
                // Заполняем поля данными выбранного материала
                materialNameTextBox.Text = selectedMaterial.MaterialName;
                categoryComboBox.SelectedValue = selectedMaterial.CategoryId;
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (materialIdComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Выберите материал для редактирования.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(materialNameTextBox.Text))
            {
                MessageBox.Show("Название материала не может быть пустым!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (categoryComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Выберите категорию для материала.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Получаем выбранный ID материала
            int selectedId = (int)materialIdComboBox.SelectedValue;
            var existingMaterial = _materials.FirstOrDefault(m => m.Id == selectedId);

            if (existingMaterial == null)
            {
                MessageBox.Show("Материал с таким ID не найден!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Обновляем свойства материала
            existingMaterial.MaterialName = materialNameTextBox.Text;
            existingMaterial.CategoryId = (int)categoryComboBox.SelectedValue;

            // Сохраняем изменения в JSON
            try
            {
                _dataService.SaveMaterials(_materials);
                MessageBox.Show("Материал успешно обновлен!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
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