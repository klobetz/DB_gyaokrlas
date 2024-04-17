namespace Egy_tablas_DB.Model
{
    public class Product
    {
        public int ProductId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public decimal Peice { get; set; }

        public int StockQuantity { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        
        public DateTime LastModifiedAt { get; set; }

        public bool IsActive { get; set; }

        public bool ShowData { get; set; } = true;

        public bool GetData()
        {
            return ShowData;
        }
    }
}
