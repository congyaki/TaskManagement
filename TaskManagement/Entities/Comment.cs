﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TaskManagement.Entities
{
    [Table("TBL_COMMENTS")]
    public class Comment
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }

        [Column("TASK_ID")]
        public int TaskId { get; set; }  // Foreign Key to TblTask

        [Column("USER_ID")]
        public int UserId { get; set; }  // Foreign Key to User (assuming there is a User table)

        [Column("CONTENT")]
        public string Content { get; set; }

        [Column("CREATED_AT")]
        public DateTime CreatedAt { get; set; }

        [Column("CREATED_BY")]
        public string CreatedBy { get; set; }

        [Column("LAST_MODIFIED_BY")]
        public string LastModifiedBy { get; set; }

        [Column("LAST_MODIFIED_AT")]
        public DateTime? LastModifiedAt { get; set; }
    }
}
