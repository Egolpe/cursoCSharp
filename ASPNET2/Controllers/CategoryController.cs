using System;
namespace ASPNET2.Controllers;

public class CategoryController
{
    private ICategoryRepository CategoryRepo;


    public CategoryController(ICategoryRepository categoryRepository)
    {
        CategoryRepo = categoryRepository;
    }
}

