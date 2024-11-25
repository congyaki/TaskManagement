using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TaskManagement.enums
{
    public enum TaskStatus
    {
        [Display(Name = "Chưa phân công")]
        NotAssigned,

        [Display(Name = "Đã phân công")]
        Assigned,

        [Display(Name = "Đã tiếp nhận")]
        Received,

        [Display(Name = "Đang thực hiện")]
        InProgress,

        [Display(Name = "Đã hoàn thành")]
        Completed,

        [Display(Name = "Chưa hoàn thành")]
        InCompleted,

        [Display(Name = "Đã xác nhận")]
        Confirmed,

        [Display(Name = "Chưa đạt yêu cầu")]
        UnStatisfactory

    }
}
