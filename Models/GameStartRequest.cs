using System;
using Newtonsoft.Json;

public class GameStartRequest 
{
    public int Width { get; set; }
    public int Height { get; set; }
    [JsonProperty("game_id")]
    public Guid GameId { get; set; }
}