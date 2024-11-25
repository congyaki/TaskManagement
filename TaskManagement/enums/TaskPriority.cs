using System.ComponentModel.DataAnnotations;

namespace TaskManagement.enums
{
    public enum TaskPriority
    {
        [Display(Name = "Thấp")]
        Low,

        [Display(Name = "Trung bình")]
        Medium,

        [Display(Name = "Khá cao")]
        Fairly,

        [Display(Name = "Cao")]
        High,

        [Display(Name = "Gấp")]
        Urgent,

    }
}
