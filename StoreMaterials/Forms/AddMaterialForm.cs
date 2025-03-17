using StoreMaterials.Models;
using StoreMaterials.DataService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace StoreMaterials.Forms
{
public partial class AddMaterialForm : Form
{
    public Material Material { get; private set; }
    private List<Category> _categories; // Список существующих категорий
    private readonly DataService.DataService _dataService; // Сервис для работы с данными

    public AddMaterialForm(List<Category> categories = null, DataService.DataService dataService = null)
    {
        InitializeComponent();
        Material = new Material();
        _categories = categories ?? new List<Category>();
        _dataService = dataService ?? new DataService.DataService(); // Инициализация сервиса

        // Заполняем ComboBox категориями (исключаем пустые значения)
        var filteredCategories = _categories
            .Where(c => c.Id != -1) // Исключаем категории с Id = -1
            .ToList();

        categoryComboBox.DataSource = filteredCategories;
        categoryComboBox.DisplayMember = "CategoryName";
        categoryComboBox.ValueMember = "Id";
        categoryComboBox.SelectedIndex = 0;
    }

   private void saveButton_Click(object sender, EventArgs e)
{
    if (string.IsNullOrEmpty(materialNameTextBox.Text))
    {
        MessageBox.Show("Название материала не может быть пустым!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        return;
    }

    // Перезагружаем данные из JSON-файла, чтобы убедиться, что список актуален
    List<Material> materials;
    try
    {
        materials = _dataService.LoadMaterials();
    }
    catch (Exception ex)
    {
        MessageBox.Show($"Ошибка при загрузке данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        return;
    }

    // Логируем существующие ID
    Console.WriteLine("Существующие ID:");
    foreach (var mat in materials)
    {
        Console.Write($"{mat.Id} ");
    }
    Console.WriteLine();

    // Собираем все существующие ID
    HashSet<int> existingIds = materials.Select(m => m.Id).ToHashSet();

    // Ищем первый свободный ID
    int newId = 1;
    while (existingIds.Contains(newId))
    {
        newId++;
    }

    Console.WriteLine($"Сгенерирован новый ID: {newId}");

    // Проверяем, что новый ID уникален
    if (existingIds.Contains(newId))
    {
        MessageBox.Show("Ошибка: сгенерированный ID уже существует!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        return;
    }

    // Создаем новый материал
    var newMaterial = new Material
    {
        Id = newId,
        MaterialName = materialNameTextBox.Text,
        CategoryId = (int)categoryComboBox.SelectedValue
    };

    // Логируем данные нового материала
    Console.WriteLine($"Новый материал: Id = {newMaterial.Id}, Name = {newMaterial.MaterialName}, CategoryId = {newMaterial.CategoryId}");

    // Проверяем, существует ли материал с таким же ID перед добавлением
    if (materials.Any(m => m.Id == newMaterial.Id))
    {
        MessageBox.Show("Материал с таким ID уже существует!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        return;
    }

    // Добавляем новый материал в список
    materials.Add(newMaterial);

    // Логируем список после добавления
    Console.WriteLine("После добавления нового материала:");
    foreach (var mat in materials)
    {
        Console.WriteLine($"Id: {mat.Id}, Name: {mat.MaterialName}, CategoryId: {mat.CategoryId}");
    }

    // Сохраняем изменения в JSON
    try
    {
        _dataService.SaveMaterials(materials);
        MessageBox.Show("Материал успешно добавлен!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
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