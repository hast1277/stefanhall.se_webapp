namespace stefanhall_se_WebApp.Services
{
    using stefanhall_se_WebApp.Shared;
    using System.Net.Http.Headers;
    using System.Net.Http;

    public class RunkeeperService : IRunkeeperService
    {
        public RunkeeperService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        private readonly HttpClient? _httpClient;
        private string? _token = "9816c7b034ff44b6817e7c0d68bcb97f";
        public async Task<RunkeeperActivityList> GetAllActivities()
        {
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    request_.Method = HttpMethod.Get;
                    request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
                    request_.RequestUri = new Uri("http://api.runkeeper.com/fitnessActivities?pageSize=88");
                    _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", _token);
                    var response_ = await _httpClient.SendAsync(request_, HttpCompletionOption.ResponseHeadersRead).ConfigureAwait(false);

                    try
                    {
                        var headers_ = Enumerable.ToDictionary(response_.Headers, h_ => h_.Key, h_ => h_.Value);
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }
                        ResponseHandler readActivitiesListResponse = new ResponseHandler();
                        var objectResponse_ = await readActivitiesListResponse.ReadObjectResponseAsync<RunkeeperActivityList>(response_, headers_).ConfigureAwait(false);
                        return objectResponse_.Object;

                    }

                    finally
                    { }
                }
            }
            finally
            { }
        }
    }
}
