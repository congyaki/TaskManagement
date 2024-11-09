using System.ComponentModel.DataAnnotations;

namespace TaskManagement.Models.Requests.List
{
    public record ListRequestModel
    {
        [Range(1, 1000)]
        public int PageNumber { get; set; }

        [Range(1, 100)]
        public int PageItemCount { get; set; }

        public ListRequestModel()
        {
            PageNumber = 1;
            PageItemCount = 50;
        }
    }
}
