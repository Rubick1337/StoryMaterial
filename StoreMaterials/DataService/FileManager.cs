using StoreMaterials.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace StoreMaterials.DataService
{
    public class DataService
    {
        private readonly string _dataPath = Path.Combine(Directory.GetCurrentDirectory(), "Data");

        public List<Category> LoadCategories()
        {
            var filePath = Path.Combine(_dataPath, "categories.json");
            var json = File.ReadAllText(filePath);
            return JsonConvert.DeserializeObject<List<Category>>(json);
        }

        public List<Material> LoadMaterials()
        {
            var filePath = Path.Combine(_dataPath, "materials.json");
            var json = File.ReadAllText(filePath);
            return JsonConvert.DeserializeObject<List<Material>>(json);
        }

        public List<Sale> LoadSales()
        {
            var filePath = Path.Combine(_dataPath, "sales.json");
            var json = File.ReadAllText(filePath);
            return JsonConvert.DeserializeObject<List<Sale>>(json);
        }

        public void SaveSales(List<Sale> sales)
        {
            var filePath = Path.Combine(_dataPath, "sales.json");
            var json = JsonConvert.SerializeObject(sales, Formatting.Indented);
            File.WriteAllText(filePath, json);
        }

        public void SaveCategories(List<Category> categories)
        {
            var filePath = Path.Combine(_dataPath, "categories.json");
            var json = JsonConvert.SerializeObject(categories, Formatting.Indented);
            File.WriteAllText(filePath, json);
        }

        public void SaveMaterials(List<Material> materials)
        {
            var filePath = Path.Combine(_dataPath, "materials.json");

            // Логируем данные перед записью
            Console.WriteLine("Сохраняем материалы:");
            foreach (var material in materials)
            {
                Console.WriteLine($"Id: {material.Id}, Name: {material.MaterialName}, CategoryId: {material.CategoryId}");
            }

            var json = JsonConvert.SerializeObject(materials, Formatting.Indented);
    
            try
            {
                File.WriteAllText(filePath, json);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сохранении данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}