using System;

public class Lecture : Event
{
    private string _speaker;
    private int _capacity;

    // Inherit from Event
    public Lecture(string title, string description, string date, string time, Address address, string speaker, int capacity)
        : base(title, description, date, time, address, "Lecture")
    {
        _speaker = speaker;
        _capacity = capacity;
    }

    // Grab the lecture details
    public string GetLectureDetails()
    {
        return $"Capacity: {_capacity}\nSpeaker: {_speaker}.";
    }
}