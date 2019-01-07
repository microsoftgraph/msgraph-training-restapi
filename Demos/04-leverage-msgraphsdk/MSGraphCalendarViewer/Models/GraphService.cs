using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace MSGraphCalendarViewer.Models
{
    public class GraphService
    {
        public async Task<List<GraphOdataEvent>> GetCalendarEvents(string accessToken)
        {
            List<GraphOdataEvent> myEventList = new List<GraphOdataEvent>();

            string query = "https://graph.microsoft.com/v1.0/me/events?$select=subject,start,end&$top=20&$skip=0";

            using (var client = new HttpClient())
            {
                using (var request = new HttpRequestMessage(HttpMethod.Get, query))
                {
                    request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);

                    using (var response = await client.SendAsync(request))
                    {
                        if (response.IsSuccessStatusCode)
                        {
                            var json = await response.Content.ReadAsStringAsync();
                            var result = JsonConvert.DeserializeObject<GraphOdataResponse>(json);
                            myEventList = result.Events.ToList();
                        }

                        return myEventList;
                    }
                }
            }
        }
    }
}