using DataAccessLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using TraversalCoreProje.CQRS.Queries.DestinationQueries;
using TraversalCoreProje.CQRS.Results.DestinationResults;

namespace TraversalCoreProje.CQRS.Handlers.DestinationHandlers;

public class GetAllDestinationQueriesHandler
{
    private readonly Context _context;

    public GetAllDestinationQueriesHandler(Context context)
    {
        _context = context;
    }

    public List<GetAllDestinationQueryResult> Handle(GetAllDestinationQueries query)
    {
        var values = _context.Destinations.Select(x => new GetAllDestinationQueryResult
        {
            id = x.DestinationID,
            capacity = x.Capacity,
            city = x.City,
            daynight = x.DayNight,
            price = x.Price
        }).AsNoTracking().ToList();
        return values;
    }
}