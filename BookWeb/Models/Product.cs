using System.ComponentModel.DataAnnotations;

namespace BookWeb.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string ProductCategory { get; set; }
    }
}
