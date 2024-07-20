public class Event
{
    private string _eventName;
    private string _eventDescription;
    private string _eventDate;
    private string _eventTime;
    private Address _eventAddress;
    
    public Event(string eventName, string eventDescription, string eventDate, string eventTime, Address eventAddress)
    {
        _eventName = eventName;
        _eventDescription = eventDescription;
        _eventDate = eventDate;
        _eventTime = eventTime;
        _eventAddress = eventAddress;

    }

    public virtual string GetStandardDetails()
    {
        return $"{_eventName}\n Description: {_eventDescription}\n Date: {_eventDate}, {_eventTime}\n Address: {_eventAddress.GetAddress()}";
    }

    public virtual string GetFullDetails()
    {
        return $"";
    }

    public virtual string GetShortDetails()
    {
        return $"{_eventName}: {_eventDate}, {_eventTime}";
    }


}