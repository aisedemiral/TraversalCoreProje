namespace TraversalCoreProje.CQRS.Commands.DestinationCommands;

public class CreateDestinationCommands
{
    public string City { get; set; }
    public string DayNight { get; set; }
    public float Price { get; set; }
    public int Capacity { get; set; }
    public bool Status { get; set; }
}