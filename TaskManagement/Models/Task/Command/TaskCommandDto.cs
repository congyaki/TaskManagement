using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations.Schema;
using TaskManagement.Entities;
using TaskManagement.enums;

namespace TaskManagement.Models.Task.Command
{
    public class TaskCommandDto
    {
        [Column("TITLE")]
        public string Title { get; set; }
        [Column("CODE")]
        public string Code { get; set; }

        [Column("START_DATE")]
        public DateTime StartDate { get; set; }

        [Column("END_DATE")]
        public DateTime EndDate { get; set; }

        [Column("PRIORITY")]
        public TaskPriority SelectedPriority { get; set; }

        [Column("ESTIMATED_TIME")]
        public double? EstimatedTime { get; set; }

        [Column("DESCRIPTION")]
        public string Description { get; set; }

        [Column("STATUS")]
        public enums.TaskStatus Status { get; set; }

        //[Column("DEPARTMENT_ID")]
        //public int DepartmentId { get; set; }

        [Column("PARENT_ID")]
        public int? ParentId { get; set; }
        public IEnumerable<int> SelectedUserIds { get; set; }
        public IEnumerable<int> SelectedLabelIds { get; set; }
        public IFormFile[]? SelectedFiles { get; set; }
        public IEnumerable<SelectListItem>? Users { get; set; }

        public IEnumerable<SelectListItem>? Labels { get; set; }
        public IEnumerable<SelectListItem>? Priorities { get; set; }

    }
}
