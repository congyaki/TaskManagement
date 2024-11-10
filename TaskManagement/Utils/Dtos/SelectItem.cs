namespace TaskManagement.Utils.Dtos
{
    public class SelectItem
    {
        public int Id { get; set; }
        public string Code { get; set; }

        public string Name { get; set; }

        public bool Selected { get; set; }

        public object Select()
        {
            throw new NotImplementedException();
        }
    }
}
