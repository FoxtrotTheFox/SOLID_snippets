using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP.Right
{
    class Program
    {
        static void Main(string[] args)
        {
            IPerson owner = Factory.CreatePerson();
            owner.FirstName = "Bob";
            owner.LastName = "Martin";
            owner.EmailAddress = "bob@martin.com";
            owner.PhoneNumber = "1111-222";

            IProject project = Factory.CreateProject();
            project.ProjectName = "android app";
            project.Owner = owner;

            project.WorkOnproject(3);
            project.WorkOnproject(1.5);
            project.CompleteProject();
            Console.ReadLine();
        }
    }
}
