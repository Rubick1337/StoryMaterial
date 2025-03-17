using Newtonsoft.Json;

namespace StoreMaterials.Models
{
    public class Material
    {
        [JsonProperty("Id")]  // Указание, что это поле будет сериализовано и десериализовано с именем "Id"
        public int Id { get; set; } // Уникальный идентификатор

        [JsonProperty("MaterialName")]  // Указание, что это поле будет сериализовано и десериализовано с именем "MaterialName"
        public string MaterialName { get; set; }

        [JsonProperty("CategoryId")]  // Указание, что это поле будет сериализовано и десериализовано с именем "CategoryId"
        public int CategoryId { get; set; } // Ссылка на категорию
    }
}