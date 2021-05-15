namespace OnlineShopping.Domain.Model.Goods
{
    public class Product : Entity<long>
    {
        public string Title { get; set; }
        public string Code { get; set; }
        public int MinimumInventory { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
        public Product(long id, string title, string code, int minimumInventory, int categoryId) : base(id)
        {
            Title = title;
            Code = code;
            MinimumInventory = minimumInventory;
            CategoryId = categoryId;
        }
    }
}
