using Microsoft.AspNetCore.Mvc;
using TraversalCoreProje.CQRS.Handlers.DestinationHandlers;
using TraversalCoreProje.CQRS.Queries.DestinationQueries;

namespace TraversalCoreProje.Areas.Admin.Controllers;

public class DestinationCQRSController : Controller
{
    private readonly GetAllDestinationQueriesHandler _getAllDestinationQueriesHandler;
    private readonly GetDestinationByIdQueryHandler _getDestinationByIdQueryHandler;
   
    public DestinationCQRSController(GetAllDestinationQueriesHandler getAllDestinationQueriesHandler, GetDestinationByIdQueryHandler getDestinationByIdQueryHandler)
    {
        _getAllDestinationQueriesHandler = getAllDestinationQueriesHandler;
        _getDestinationByIdQueryHandler = getDestinationByIdQueryHandler;
    }

    public IActionResult Index()
    {
        var values = _getAllDestinationQueriesHandler.Handle(new GetAllDestinationQueries());
        return View(values);
    }

    public IActionResult GetDestination(int id)
    {
        var values = _getAllDestinationQueriesHandler.Handle(new GetAllDestinationQueries() );
        return View(values);
    }
}