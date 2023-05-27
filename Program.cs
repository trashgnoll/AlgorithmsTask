using AlgorithmsTask.Controllers;
using AlgorithmsTask.Models;

namespace AlgorithmsTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User[] users = { new("First", "User #1", false),
                             new("Second", "User #2", true),
                             new("Third", "User #3", true),
                             new("Fourth", "User #4", false),
                             new("Fifth", "User #5", false) };
            foreach (User user in users)
            {
                Greetings.Greet(user);
                Console.WriteLine("");
            }
        }
    }
}