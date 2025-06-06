using System.Reflection;

namespace EventsImplementation
{
    public delegate void Notify(string message);

    // publisher class
    class User
    {
        // declare event
        public event Notify? UserLoggedIn;

        public void Login(string username)
        {
            Console.WriteLine($"{username} logged in successfully !!");

            // trigger event
            UserLoggedIn?.Invoke(username);
        }
    }

    // subscriber class
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User();

            // subscribe to the event
            user.UserLoggedIn += DisplayMessage;
            user.UserLoggedIn += DeleteUser;

            // simulate login
            user.Login("vinayak");
        }

        // event handler method
        static void DisplayMessage(string username)
        {
            Console.WriteLine($"Notification: {username} has logged in.");
        }

        static void DeleteUser(string username)
        {
            Console.WriteLine($"Notification: {username} has logged out");
        }
    }
}