using System;

namespace DIP.Wrong
{
    class Program
    {
        static void Main(string[] args)
        {
            Person owner = new Person
            {
                FirstName = "Bob",
                LastName = "Martin",
                EmailAddress = "bob@martin.com",
                PhoneNumber = "111-222-333"
            };

            Project androidApp = new Project
            {
                ProjectName = "android app",
                Owner = owner
            };

            androidApp.WorkOnProject(3);
            androidApp.WorkOnProject(1.5);
            androidApp.CompleteProject();

            Console.ReadLine();
        }
    }
}
