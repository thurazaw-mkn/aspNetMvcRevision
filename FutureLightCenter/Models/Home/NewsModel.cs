namespace FutureLightCenter.Models.Home;

public class NewsModel
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Image { get; set; }
    public string Body { get; set; }
}

public class ListNewsModel
{
    public List<NewsModel> newsModelList = new List<NewsModel>();
}