using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DojoSurveyModel.Models;

namespace DojoSurvey.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }


    [HttpPost("ProcesarDatos")]
    public IActionResult NewStudent(Survey newStudent)
    {
        Console.WriteLine($"{newStudent.Nombre} {newStudent.UbicacionDojo} {newStudent.FavoriteLanguage} {newStudent.Comment}");
        return View("SubmittedForm", newStudent);
    }



    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
