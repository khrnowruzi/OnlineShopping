namespace OnlineShopping.Application.Models
{
    public class RegisterProductDto
    {
        public string Title { get; set; }
        public string Code { get; set; }
        public int MinimumInventory { get; set; }
        public int CategoryId { get; set; }
    }
}