using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP.Right
{
    public class Project : IProject
    {
        ILogger _logger;
        IMessageSender _messageSender;

        public string ProjectName { get; set; }
        public IPerson Owner { get; set; }
        public double HoursWorked { get; private set; }
        public bool IsComplete { get; private set; }

        public Project(ILogger logger, IMessageSender messageSender)
        {
            _logger = logger;
            _messageSender = messageSender;
        }

        public void WorkOnproject(double hours)
        {
            HoursWorked += hours;
            _logger.Log($"Performed work on { ProjectName }");
        }

        public void CompleteProject()
        {
            IsComplete = true;
            _logger.Log($"Completed { ProjectName }");
            _messageSender.SendMessage(Owner, $"The project { ProjectName } is complete.");
        }
    }
}
