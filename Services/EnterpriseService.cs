using TimeControl.Models;
using Microsoft.Extensions.Options;

namespace TimeControl.Services;

public class EnterpriseService : BaseService<Enterprise>
{
    public EnterpriseService(IOptions<DatabaseSettings> databaseSettings) :
        base(databaseSettings, databaseSettings.Value.EnterpriseCollectionName)
    { }
}