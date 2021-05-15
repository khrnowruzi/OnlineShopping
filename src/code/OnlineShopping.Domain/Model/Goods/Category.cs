namespace OnlineShopping.Domain.Model.Goods
{
    public class Category : Entity<int>
    {
        public string Title { get; set; }
        public Category(int id, string title) : base(id)
        {
            Title = title;
        }
    }
}
