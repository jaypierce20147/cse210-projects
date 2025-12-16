using System;

public class Event
{
    private string _title;
    private string _description;
    private string _date;
    private string _time;
    private Address _address;
    private string _eventType;
    
    // Store the event
    public Event(string title, string description, string date, string time, Address address, string eventType)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
        _eventType = eventType;
    }

    // Grab the standard details
    public string GetStandardDetails()
    {
        return $"Title: {_title} \n Description: {_description} \n Date: {_date} \n Time: {_time} \n Address: {_address.GetFullAddress()}";
    }

    // Grab the Full details
    public string GetFullDetails(string extraInfo)
    {
        return $"{GetStandardDetails()} \n Event Type: {_eventType} \n {extraInfo}";
    }


    // Grab the description
    public string GetShortDescription()
    {
        return $"Event Type: {_eventType} \n Title: {_title} \n Date: {_date}";
    }
}