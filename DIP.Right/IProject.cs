namespace DIP.Right
{
    public interface IProject
    {
        string ProjectName { get; set; }
        double HoursWorked { get; }
        bool IsComplete { get; }
        IPerson Owner { get; set; }

        void CompleteProject();
        void WorkOnproject(double hours);
    }
}