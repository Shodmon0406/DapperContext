using Domain.Models;
using Infrastructure.Services;

var service = new CategoryService();

var category = service.GetCategoryById(1);
Console.WriteLine($"{category.Id} {category.CategoryName}");