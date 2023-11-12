﻿public class Book
{
    public int Id { get; set; }
    public string Title { get; set; }
    public int Chapters { get; set; }
    public int Pages { get; set; }
    public decimal Price { get; set; }
    public int AuthorId { get; set; }
    public Author Author { get; set; }
}
