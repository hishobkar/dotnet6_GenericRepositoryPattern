using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using GenericRepositoryPattern.Web.Models;
using GenericRepositoryPattern.Core.Repository;
using GenericRepositoryPattern.Data.Models;

namespace GenericRepositoryPattern.Web.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly IRepository<Category> _categoryRepo;
    private readonly IRepository<Product> _productRepo;

    public HomeController(ILogger<HomeController> logger, IRepository<Product> productRepo,IRepository<Category> categoryRepo)
    {
        _logger = logger;
        _productRepo = productRepo;
        _categoryRepo = categoryRepo;
    }

    public IActionResult Index()
    {
        var viewmodel = _productRepo.GetAll();

        return View(viewmodel);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
