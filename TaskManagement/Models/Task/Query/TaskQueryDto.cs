using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TaskManagement.Entities;
using TaskManagement.Models.Comment.Query;
using TaskManagement.Models.Label.Query;
using TaskManagement.Models.User.Query;

namespace TaskManagement.Models.Task.Query
{
    public class TaskQueryDto
    {
        public int Id { get; set; }
        [Column("TITLE")]
        [Display(Name = "Tiêu đề")]
        public string Title { get; set; }

        [Column("START_DATE")]
        [Display(Name = "Thời gian bắt đầu")]
        public DateTime? StartDate { get; set; }

        [Column("END_DATE")]
        [Display(Name = "Thời gian kết thúc")]
        public DateTime? EndDate { get; set; }

        [Column("PRIORITY")]
        [Display(Name = "Mức độ ưu tiên")]
        public int? Priority { get; set; }

        [Column("ESTIMATED_TIME")]
        public double? EstimatedTime { get; set; }

        [Column("DESCRIPTION")]
        [Display(Name = "Mô tả")]
        public string Description { get; set; }

        [Column("STATUS")]
        [Display(Name = "Trạng thái")]
        public string Status { get; set; }

        //[Column("DEPARTMENT_ID")]
        //public int DepartmentId { get; set; }

        [Column("PARENT_ID")]
        public int? ParentId { get; set; }
        //public TblDmDepartment Department { get; set; }
        [Column("CREATED_BY")]
        [Display(Name = "Người tạo")]
        public int? CreatedBy { get; set; }

        [Column("CREATED_AT")]
        public DateTime? CreatedAt { get; set; }
        [Display(Name = "Nhãn dán")]
        public List<LabelQueryDto> Labels { get; set; }
        public List<UserQueryDto> Users { get; set; }
        public List<CommentQueryDto> Comments { get; set; }
        public IFormFileCollection? TaskFiles { get; set; }
    }
}
