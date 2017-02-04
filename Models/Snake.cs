using System;
using Newtonsoft.Json;

public class Snake
{
    public Point[] Coords { get; set; }
    [JsonProperty("health_points")]
    public int HealthPoints { get; set; }
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Taunt { get; set; }
}