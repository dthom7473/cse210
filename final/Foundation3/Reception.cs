public class Reception : Event
{
    private string _rsvpEmail;

    public Reception(string eventName, string eventDescription, string eventDate, string eventTime, Address eventAddress, string rsvpEmail)
        : base(eventName, eventDescription, eventDate, eventTime, eventAddress)
    {
            _rsvpEmail = rsvpEmail;
    }

    public override string GetFullDetails()
    {
        return $"{GetStandardDetails()}\n Type: Lecture\n RSVP Email: {_rsvpEmail}\n";
    }
}