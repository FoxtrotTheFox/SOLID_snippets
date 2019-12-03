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

            owner.FirstName = "Tim";
            owner.LastName = "Corey";
            owner.EmailAddress = "tim@iamtimcorey.com";
            owner.PhoneNumber = "555-1212";

            IProject chore = Factory.CreateChore();
            chore.ProjectName = "Take out the trash";
            chore.Owner = owner;

            chore.WorkOnproject(3);
            chore.WorkOnproject(1.5);
            chore.CompleteProject();

            Console.ReadLine();
        }
    }
}
