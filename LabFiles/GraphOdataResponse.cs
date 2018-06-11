using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MSGraphCalendarViewer.Models
{
  public class GraphOdataResponse
  {
    [JsonProperty("odata.context")]
    public string Context { get; set; }
    [JsonProperty("value")]
    public List<GraphOdataEvent> Events { get; set; }
  }

  public class GraphOdataDate
  {
    [JsonProperty("dateTime")]
    public string DateTime { get; set; }
    [JsonProperty("timeZone")]
    public string TimeZone { get; set; }
  }

  public class GraphOdataEvent
  {
    [JsonProperty("odata.etag")]
    public string Etag { set; get; }
    [JsonProperty("id")]
    public string Id { set; get; }
    [JsonProperty("subject")]
    public string Subject { set; get; }
    [JsonProperty("start")]
    public GraphOdataDate Start { set; get; }
    [JsonProperty("end")]
    public GraphOdataDate End { set; get; }
  }
}