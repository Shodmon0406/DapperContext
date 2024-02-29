namespace Domain.Models;

public class Book
{
    public int Id { get; set; }
    public string Title { get; set; }
    public int CategoryId { get; set; }
}