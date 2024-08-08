using BlazorApp;

public class ApiData
{
    public string DieselDataJson { get; set; }
    public string MilesDataJson { get; set; }

    public List<Data> DieselData { get; set; }
    public List<Data> MilesData { get; set; }
}