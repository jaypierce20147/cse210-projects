using System;

public class Reception : Event
{
    private string _rsvpEmail;

    public Reception(string title, string description, string date, string time, Address address, string rsvpEmail)
        : base(title, description, date, time, address, "Reception")
    {
        _rsvpEmail = rsvpEmail;
    }

    public string GetReceptionDetails()
    {
        return $"RSVP Email: {_rsvpEmail}.";
    }
}