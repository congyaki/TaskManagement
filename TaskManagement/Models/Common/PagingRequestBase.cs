using System.ComponentModel.DataAnnotations;

namespace TaskManagement.Models.Common
{
    public class PagingRequestBase
    {
        public int PageIndex { get; set; }

        public int PageSize { get; set; }

        public PagingRequestBase()
        {
            PageIndex = 1;
            PageSize = 10;
        }
    }
}
