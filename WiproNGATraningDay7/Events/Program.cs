using System;

class Publisher
{
    // Step 1: Declare an event using a delegate
    public event Action<string> OnMessageReceived;

    public void SendMessage(string message)
    {
        Console.WriteLine("Publisher: Sending message...");

        // Step 3: Raise the event (Notify subscribers)
        OnMessageReceived?.Invoke(message);
    }
}

class Subscriber
{
    public void DisplayMessage(string message)
    {
        Console.WriteLine("Subscriber received: " + message);
    }
}

internal class Program
{
    private static void Main(string[] args)
    {
        Publisher publisher = new Publisher();
        Subscriber subscriber = new Subscriber();

        // Step 2: Subscribe to the event
        publisher.OnMessageReceived += subscriber.DisplayMessage;

        // Trigger event
        publisher.SendMessage("Hello, Events in C#!");

        // Unsubscribe from the event
        publisher.OnMessageReceived -= subscriber.DisplayMessage;
    }
}
