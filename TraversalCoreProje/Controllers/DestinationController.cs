using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ActionConstraints;

namespace TraversalCoreProje.Controllers;
[AllowAnonymous]
public class DestinationController : Controller
{
    private readonly IDestinationService _destinationService;

    public DestinationController(IDestinationService destinationService)
    {
        _destinationService = destinationService;
    }

    public IActionResult Index()
    {
        var values = _destinationService.TGetList();
        return View(values);
    }

    [HttpGet]
    public IActionResult DestinationDetails(int id)
    {
        ViewBag.i = id;
        var values = _destinationService.TGetByID(id);
        return View(values);
    }
    [HttpPost]
    public IActionResult destinationDetails(Destination p)
    {
        return View();
    }
    
}