namespace stefanhall_se_WebApp.Services
{
    using stefanhall_se_WebApp.Shared;
    using CsvHelper;
    using System.Globalization;
    using System;

    public class RunkeeperService : IRunkeeperService
    {
        public async Task<List<RunkeeperActivity>> GetAllActivities()
        {
            RunkeeperActivity activity = new RunkeeperActivity();
            //string path = "..\\Data\\csv\\caridoActivities.csv";
            string path = "C:\\Users\\halls\\source\\repos\\stefanhall_se_WebApp\\stefanhall_se_WebApp\\Data\\csv\\cardioActivities.csv";
            StreamReader reader = new StreamReader(path);
            CsvReader csv = new CsvReader(reader, CultureInfo.InvariantCulture);
            List<RunkeeperActivity> records = csv.GetRecords<RunkeeperActivity>().ToList();
            return records;
        }
    }
}
