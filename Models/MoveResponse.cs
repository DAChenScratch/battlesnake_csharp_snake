using Newtonsoft.Json;

public class MoveResponse
{
    public string Move { get; set; }
    [JsonProperty(NullValueHandling=NullValueHandling.Ignore)]
    public string Taunt { get; set; }
}