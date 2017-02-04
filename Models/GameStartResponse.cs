using Newtonsoft.Json;

public class GameStartResponse
{
    public string Color { get; set; }
    [JsonProperty("head_url", NullValueHandling=NullValueHandling.Ignore)]
    public string HeadUrl { get; set; }
    public string Name { get; set; }
    [JsonProperty(NullValueHandling=NullValueHandling.Ignore)]
    public string Taunt { get; set; }
}