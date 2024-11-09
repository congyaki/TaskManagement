namespace TaskManagement.Models.Requests.Task.Command
{
    public class TaskCommandDto
    {
        public IEnumerable<int> UserIds { get; set; }
        public IEnumerable<int> LabelIds { get; set; }
    }
}
