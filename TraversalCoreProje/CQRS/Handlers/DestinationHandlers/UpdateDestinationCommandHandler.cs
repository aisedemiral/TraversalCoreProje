using DataAccessLayer.Concrete;
using DocumentFormat.OpenXml.Spreadsheet;
using TraversalCoreProje.CQRS.Commands.DestinationCommands;

namespace TraversalCoreProje.CQRS.Handlers.DestinationHandlers;

public class UpdateDestinationCommandHandler
{
    private readonly Context _context;

    public UpdateDestinationCommandHandler(Context context)
    {
        _context = context;
    }

    public void Handle(UpdateDestinationCommands commands)
    {
        var values = _context.Destinations.Find(commands.DestinationID);
        values.City = commands.City;
        values.DayNight = commands.DayNight;
        values.Price = (float)commands.Price;
        _context.SaveChanges();
    }
}