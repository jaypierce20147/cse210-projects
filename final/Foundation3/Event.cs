using System;

public class Event
{
    private string _title;
    private string _description;
    private string _date;
    private string _time;
    private Address _address;
    private string _eventType;
    
    public Event(string title, string description, string date, string time, Address address, string eventType)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
        _eventType = eventType;
    }

    public string GetStandardDetails()
    {
        return $"Title: {_title} \n Description: {_description} \n Date: {_date} \n Time: {_time} \n Address: {_address.GetFullAddress()}";
    }

    public string GetFullDetails(string extraInfo)
    {
        return $"{GetStandardDetails()} \n Event Type: {_eventType} \n {extraInfo}";
    }

    public string GetShortDescription()
    {
        return $"Event Type: {_eventType} \n Title: {_title} \n Date: {_date}";
    }
}