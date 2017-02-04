using System;
using Newtonsoft.Json;

public class MoveRequest
{
    public BoardCell[][] Board { get; set; }
    public Point[] Food { get; set; }
    [JsonProperty("game_id")]
    public Guid GameId { get; set; }
    public int Height { get; set; }
    public Snake[] Snakes { get; set; }
    public int Turn { get; set; }
    public int Width { get; set; }
    public Guid You { get; set; }
}