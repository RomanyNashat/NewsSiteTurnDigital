namespace NewsSiteTurnDigital.WEB.ViewModel
{
    public class NewsViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int CategoryId { get; set; }
        public bool IsFirstPage { get; set; }
        public string ImageUrl { get; set; }
        public IFormFile File { get; set; }
    }
}
