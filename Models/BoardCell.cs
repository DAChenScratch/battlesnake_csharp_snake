using Newtonsoft.Json;

public class BoardCell
{
    public string State { get; set; }
    [JsonProperty(NullValueHandling=NullValueHandling.Ignore)]
    public string Snake { get; set; }
}