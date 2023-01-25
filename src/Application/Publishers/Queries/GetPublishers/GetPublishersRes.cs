namespace Application.Publishers.Queries.GetPublishers;

public class GetPublishersRes
{
    //public GetPublishersRes()
    //{
    //    this.Data = new List<GetPublishersResData>();
    //}

    public int PageCount { get; set; }
    public int PageIndex { get; set; }
    public IEnumerable<GetPublishersResData> Data { get; set; } = new List<GetPublishersResData>();
}

public class GetPublishersResData
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
}