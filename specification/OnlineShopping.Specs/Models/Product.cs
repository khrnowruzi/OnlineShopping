﻿namespace OnlineShopping.Specs.Models
{
    public class Product
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public string Code { get; set; }
        public int MinimumInventory { get; set; }
        public int CategoryId { get; set; }
    }
}