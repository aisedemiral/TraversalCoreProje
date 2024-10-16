namespace TraversalCoreProje.CQRS.Commands.DestinationCommands;

public class UpdateDestinationCommands
{
    public int DestinationID;
    public int DestinationId { get; set; }
    public string City { get; set; }
    public string DayNight { get; set; }
    public double Price { get; set; }
}