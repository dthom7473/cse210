public class Lecture : Event
{
    private string _speakerName;
    private int _eventCapacity;

    public Lecture(string eventName, string eventDescription, string eventDate, string eventTime, Address eventAddress, string speakerName, int eventCapacity)
        : base(eventName, eventDescription, eventDate, eventTime, eventAddress)
    {
            _speakerName = speakerName;
            _eventCapacity = eventCapacity;
    }

    public override string GetFullDetails()
    {
        return $"{GetStandardDetails()}\n Type: Lecture\n Speaker: {_speakerName}\n Capacity: {_eventCapacity}";
    }
}