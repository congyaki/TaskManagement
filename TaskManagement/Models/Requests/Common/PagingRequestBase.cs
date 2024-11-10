using System.ComponentModel.DataAnnotations;

namespace TaskManagement.Models.Requests.List
{
    public record PagingRequestBase
    {
        public int PageIndex { get; set; }

        public int PageSize { get; set; }

        public PagingRequestBase()
        {
            PageIndex = 1;
            PageSize = 50;
        }
    }
}
