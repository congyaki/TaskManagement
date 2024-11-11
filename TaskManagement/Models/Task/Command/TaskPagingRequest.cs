using TaskManagement.Models.Common;

namespace TaskManagement.Models.Task.Command
{
    public class TaskPagingRequest : PagingRequestBase
    {
        public string Keyword { get; set; }
        public int? LabelId { get; set; }
        public int? UserId { get; set; }
        public int? Priority { get; set; }
        public TaskStatus? Status { get; set; }

    }
}
