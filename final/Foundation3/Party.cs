public class Party : Event
{
    private string _weatherForcast;

    public Party(string eventName, string eventDescription, string eventDate, string eventTime, Address eventAddress, string weatherForcast)
        : base(eventName, eventDescription, eventDate, eventTime, eventAddress)
    {
            _weatherForcast = weatherForcast;
    }

    public override string GetFullDetails()
    {
        return $"{GetStandardDetails()}\n Type: Party\n Projected Forcast: {_weatherForcast}\n";
    }
}