﻿namespace BookStore.Api.Model
{
    public class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        public decimal Price { get; set; }
        public int Pages { get; set; }
        public string Publisher { get; set; }
    }
}
