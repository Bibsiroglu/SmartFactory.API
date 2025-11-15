namespace SmartFactory.API.Models
{
    public class ProductionOrder
    {
        public int Id { get; set; }
        public string? ProductCode { get; set; } // Üretilecek ürünün kodu (Örn: PROD-100)
        public int Quantity { get; set; } // İstenen üretim miktarı

        public string Status { get; set; } = "New"; // Siparişin durumu (New, Processing, Completed, Cancelled)
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow; // Siparişin oluşturulma zamanı

        // İlişki (Foreign Key): Hangi makineye atandığı
        public int? MachineId { get; set; }
    }
}