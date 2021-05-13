using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShopping.Domain.Model.Goods
{
    public class Category : Entity<int>
    {
        private ICollection<Product> _goods;

        public string Title { get; set; }
        public virtual ICollection<Product> Goods
        {
            get => _goods ??= new List<Product>();
            set => _goods = value;
        }
        public Category(string title)
        {
            Title = title;
        }
    }
}
