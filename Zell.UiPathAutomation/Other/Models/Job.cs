namespace Zell.UiPathAutomation.Other.Models
{
    public class Job
    {
        public enum Status
        {
            Pending, Running, Successful, Faulted,
            Stopping, Terminating, Stopped
        }

        public string Id { get; set; }
        public Status State { get; set; }
    }
}