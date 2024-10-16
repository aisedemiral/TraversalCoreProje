using Microsoft.AspNetCore.Mvc;
using TraversalCoreProje.CQRS.Commands.DestinationCommands;
using TraversalCoreProje.CQRS.Handlers.DestinationHandlers;
using TraversalCoreProje.CQRS.Queries.DestinationQueries;

namespace TraversalCoreProje.Areas.Admin.Controllers;
[Area("Admin")]

public class DestinationCQRSController : Controller
{
    private readonly GetAllDestinationQueriesHandler _getAllDestinationQueriesHandler;
    private readonly GetDestinationByIdQueryHandler _getDestinationByIdQueryHandler;
    private readonly CreateDestinationCommandHandler _createDestinationCommandHandler;
    private readonly RemoveDestinationCommandHandler _removeDestinationCommandHandler;
    private readonly UpdateDestinationCommandHandler _updateDestinationCommandHandler;
    public DestinationCQRSController(GetAllDestinationQueriesHandler getAllDestinationQueriesHandler, GetDestinationByIdQueryHandler getDestinationByIdQueryHandler, CreateDestinationCommandHandler createDestinationCommandHandler, RemoveDestinationCommandHandler removeDestinationCommandHandler, UpdateDestinationCommandHandler updateDestinationCommandHandler)
    {
        _getAllDestinationQueriesHandler = getAllDestinationQueriesHandler;
        _getDestinationByIdQueryHandler = getDestinationByIdQueryHandler;
        _createDestinationCommandHandler = createDestinationCommandHandler;
        _removeDestinationCommandHandler = removeDestinationCommandHandler;
        _updateDestinationCommandHandler = updateDestinationCommandHandler;
    }

    public IActionResult Index()
    {
        var values = _getAllDestinationQueriesHandler.Handle(new GetAllDestinationQueries());
        return View(values);
    }
    //[HttpGet]
   // public IActionResult GetDestination(int id)
    //{
    //    var values = _getAllDestinationQueriesHandler.Handle(new GetAllDestinationQueries() );
    //    return View(values);
    //}
    //[HttpPost]
   // public IActionResult GetDestination(UpdateDestinationCommands commands)
   // {
    //    _updateDestinationCommandHandler.Handle(commands);
     //   return RedirectToAction("Index");
   // }
    [HttpGet]
    public IActionResult AddDestination()
    {
        return View();
    }

    [HttpPost]
    public IActionResult AddDestination(CreateDestinationCommands commands)
    {
        try
        {
            _createDestinationCommandHandler.Handle(commands);
            return RedirectToAction("Index");
        }
        catch (Exception ex)
        {
            // Hatanın loglanması ve kullanıcıya hata mesajı gösterilmesi
            ModelState.AddModelError("", "Destinasyon ekleme sırasında bir hata oluştu: " + ex.Message);
            return View(commands);
        }
    }

    public IActionResult DeleteDestination(int id)
    {
        _removeDestinationCommandHandler.Handle(new RemoveDestinationCommand(id));
        return RedirectToAction("Index");

    }
}