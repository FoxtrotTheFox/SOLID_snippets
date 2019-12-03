using System;

namespace DIP.Wrong
{
    class Program
    {
        static void Main(string[] args)
        {
            Person owner = new Person
            {
                FirstName = "Tim",
                LastName = "Corey",
                EmailAddress = "tim@iamtimcorey.com",
                PhoneNumber = "555-1212"
            };

            Project androidApp = new Project
            {
                ProjectName = "Take out the trash",
                Owner = owner
            };

            androidApp.WorkOnProject(3);
            androidApp.WorkOnProject(1.5);
            androidApp.CompleteProject();

            Console.ReadLine();
        }
    }
}
