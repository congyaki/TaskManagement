namespace TaskManagement.Utils.Dtos
{
    public class PagedResult<T> : PagedResultBase
    {
        public List<T> Items { set; get; }

    }
}
