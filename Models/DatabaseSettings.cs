namespace TimeControl.Models;

public class DatabaseSettings
{
    public string ConnectionString { get; set; } = null!;

    public string DatabaseName { get; set; } = null!;

    public string EnterpriseCollectionName { get; set; } = null!;
}