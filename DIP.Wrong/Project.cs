
namespace DIP.Wrong
{
    public class Project
    {
        public string ProjectName { get; set; }
        public Person Owner { get; set; }
        public double HoursWorked { get; private set; }
        public bool IsComplete { get; private set; }

        public void WorkOnProject(double hours)
        {
            HoursWorked += hours;
            Logger log = new Logger();
            log.Log($"Performed work on { ProjectName }");
        }

        public void CompleteProject()

        {
            IsComplete = true;

            Logger log = new Logger();
            log.Log($"Completed { ProjectName }");

            Emailer emailer = new Emailer();
            emailer.SendEmail(Owner, $"The project { ProjectName } is complete.");
        }
    }
}
