using System;
delegate void MessageHandler(string message);

class Publisher
{
    public event MessageHandler MessagePublished;
    public void Dispatch(string message)
    {
        Delegate[] invocationList = MessagePublished.GetInvocationList();
        if (invocationList != null)
        {
            foreach (Delegate handler in invocationList)
            {
                MessageHandler messageHandler = (MessageHandler)handler;
                messageHandler(message);
            }
        }
    }
    public void InvokeEvent(string message)
    {
        MessagePublished.Invoke(message);
    }
}
class Subscriber
{
    public void CallMe(string message)
    {
        Console.WriteLine("CallMe received message: " + message);
    }
    public void MeToo(string message)
    {
        Console.WriteLine("MeToo received message: " + message);
    }
    public static void AndMe(string message)
    {
        Console.WriteLine("AndMe received message: " + message);
    }
}

class Driver
{
    static void Main(string[] args)
    {
        Publisher publisher = new Publisher();
        Subscriber subscriber = new Subscriber();
        MessageHandler handler = new MessageHandler(subscriber.CallMe);
        publisher.MessagePublished += handler;
        publisher.MessagePublished += new MessageHandler(subscriber.MeToo);
        publisher.MessagePublished += new MessageHandler(Subscriber.AndMe);
        publisher.Dispatch("Hello, subscribers!");
        publisher.InvokeEvent("Invoking event from inside the Publisher class.");
    }
}
