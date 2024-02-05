namespace stefanhall_se_WebApp.Services
{
    using stefanhall_se_WebApp.Shared;
    public interface IRunkeeperService
    {
        Task<List<RunkeeperActivity>> GetAllActivities();
    }
}
