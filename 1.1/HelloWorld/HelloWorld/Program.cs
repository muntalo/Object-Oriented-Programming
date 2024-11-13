using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Message myMessage;
            Message[] messages = new Message[4];
            String name;

            myMessage = new Message("Hello World...");
            myMessage.Print();

            messages[0] = new Message("Welcome back oh great educator!");
            messages[1] = new Message("What a lovely name!");
            messages[2] = new Message("Great name.");
            messages[3] = new Message("That is a silly name.");
            //messages = new Message[] {"testing", "d", "a", "g"};
            Console.WriteLine("Enter name: ");
            name = Console.ReadLine();

            if (name.ToLower() == "muntazar")    {
                messages[0].Print();
            } else if (name.ToLower() == "amir") {
                messages[1].Print();
            } else if (name.ToLower() == "zein") {
                messages[2].Print();
            } else {
                messages[3].Print();
            }
        }   
    }
}
