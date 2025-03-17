namespace StoreMaterials.Models
{
    public class Sale
    {
        public int SaleId { get; set; }
        public DateTime SaleDate { get; set; }
        public int MaterialId { get; set; } // Ссылка на материал
        public string Unit { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal DeliveryCost { get; set; }
        public decimal Discount { get; set; }
        public string CustomerName { get; set; }

        // Дополнительные свойства для удобства
        public string MaterialName { get; set; } // Название материала
        public string CategoryName { get; set; } // Название категории
    }
}