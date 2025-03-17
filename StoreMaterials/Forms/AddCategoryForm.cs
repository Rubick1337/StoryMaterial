using StoreMaterials.Models;
using StoreMaterials.DataService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace StoreMaterials.Forms
{
   public partial class AddCategoryForm : Form
{
    public Category Category { get; private set; }
    private List<Category> _categories; // Список существующих категорий
    private readonly DataService.DataService _dataService; // Сервис для работы с данными

    public AddCategoryForm(List<Category> categories = null, DataService.DataService dataService = null)
    {
        InitializeComponent();
        Category = new Category();
        _categories = categories ?? new List<Category>();
        _dataService = dataService ?? new DataService.DataService(); // Инициализация сервиса
    }

    private void saveButton_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(categoryNameTextBox.Text))
        {
            MessageBox.Show("Название категории не может быть пустым!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        // Перезагружаем данные из JSON-файла, чтобы убедиться, что список актуален
        try
        {
            _categories = _dataService.LoadCategories();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Ошибка при загрузке данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        // Генерируем новый ID (автоинкремент)
        int newId = _categories.Any() ? _categories.Max(c => c.Id) + 1 : 1;
        Category.Id = newId;
        Category.CategoryName = categoryNameTextBox.Text;

        // Добавляем новую категорию в список
        _categories.Add(Category);

        // Сохраняем изменения в JSON
        try
        {
            _dataService.SaveCategories(_categories);
            MessageBox.Show("Категория успешно добавлена!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.DialogResult = DialogResult.OK; // Закрываем форму с результатом OK
            this.Close();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Ошибка при сохранении данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void cancelButton_Click(object sender, EventArgs e)
    {
        this.DialogResult = DialogResult.Cancel; // Закрываем форму с результатом Cancel
        this.Close();
    }
}
}