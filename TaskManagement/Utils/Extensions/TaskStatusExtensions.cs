using TaskManagement.enums;
using TaskStatus = TaskManagement.enums.TaskStatus;

namespace TaskManagement.Utils.Extensions
{
    public static class TaskStatusExtensions
    {
        public static string GetStatusColor(this TaskStatus status)
        {
            switch (status)
            {
                case TaskStatus.NotAssigned:
                    return "#D3D3D3"; // Light Gray
                case TaskStatus.Assigned:
                    return "#ADD8E6"; // Light Blue
                case TaskStatus.Received:
                    return "#90EE90"; // Light Green
                case TaskStatus.InProgress:
                    return "#FFA07A"; // Light Salmon
                case TaskStatus.Completed:
                    return "#32CD32"; // Lime Green
                case TaskStatus.InCompleted:
                    return "#FF6347"; // Tomato
                case TaskStatus.Confirmed:
                    return "#00BFFF"; // Deep Sky Blue
                case TaskStatus.UnStatisfactory:
                    return "#B22222"; // Firebrick
                default:
                    return "black"; // Default color
            }
        }
    }
}
