namespace stefanhall_se_WebApp.Services
{
    using stefanhall_se_WebApp.Shared;
    using CsvHelper;
    using System.Globalization;
    using System.Xml;
    using Microsoft.AspNetCore.Http;

    public class RunkeeperService : IRunkeeperService
    {
        public async Task<List<RunkeeperActivity>> GetAllActivities()
        {
            RunkeeperActivity activity = new RunkeeperActivity();
            //string path = "..\\Data\\csv\\caridoActivities.csv";
            string path = "Data\\csv\\cardioActivities.csv";
            
            //string path = "C:\\Users\\halls\\source\\repos\\stefanhall_se_WebApp\\stefanhall_se_WebApp\\Data\\csv\\cardioActivities.csv";
            StreamReader reader = new StreamReader(path);
            CsvReader csv = new CsvReader(reader, CultureInfo.InvariantCulture);
            List<RunkeeperActivity> records = csv.GetRecords<RunkeeperActivity>().ToList();
            return records;
        }

        public async Task<List<RunkeeperDetails>> GetActivityDetails(string activityId)
        {
            string path = "Data\\gpx\\" + activityId;
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load(path);
            XmlNodeList lstTrackPoints = xmlDocument.GetElementsByTagName("trkpt");
            List<RunkeeperDetails> records = new List<RunkeeperDetails>();
            foreach (XmlNode node in lstTrackPoints)
            {
                RunkeeperDetails details = new RunkeeperDetails();
                details.latitude = node.Attributes["lat"].Value;
                details.longitude = node.Attributes["lon"].Value;
                //details.elevation = node.SelectSingleNode("ele").InnerText;
                details.elevation = node.ChildNodes[0].InnerText;
                details.time = DateTime.ParseExact(node.ChildNodes[1].InnerText, "yyyy-MM-ddTHH:mm:ssZ", System.Globalization.CultureInfo.InvariantCulture);
                //DateTime myDate = DateTime.ParseExact(dateString, "yyyy-MM-ddTHH:mm:ssZ", System.Globalization.CultureInfo.InvariantCulture);
                records.Add(details);
            }

            return records;
        }
        
    }
}
