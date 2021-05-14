namespace OnlineShopping.Domain.Model.Goods
{
    public class Category : Entity<int>
    {
        public string Title { get; set; }
        public Category(string title)
        {
            Title = title;
        }
    }
}
