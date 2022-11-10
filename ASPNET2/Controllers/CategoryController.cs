using System;
namespace ASPNET2.Controllers;

public class CategoryController
{
    private ICategoryRepository CategoryRepo;


    public CategoryController(ICategoryRepository categoryRepository)
    {
        CategoryRepo = categoryRepository;
    }

    // FindByMinAge - Dani
    [HttpGet("/min-age/{age}")]
    public List<Category> FindByMinAge(int age)
    {
        return CategoryRepo.FindByMinAge(age);
    }


}

