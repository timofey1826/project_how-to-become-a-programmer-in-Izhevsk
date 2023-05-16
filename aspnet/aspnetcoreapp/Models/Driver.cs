using aspnetcoreapp.Models;

public class Driver : Users
{
    public Guid TeamId { get; set; }
    public string Name { get; set; } = "";
    public int RacingNumber { get; set; } 
    public virtual Team? Team { get; set; }
}