namespace ForumSystem.Services.Common
{
    public class CategoryRequest
    {
        public string Name { get; set; }

        public string Visibility { get; set; }

        public int Page { get; set; }

        public int PageSize { get; set; }
    }
}
