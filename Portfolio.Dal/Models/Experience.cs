namespace Portfolio.Dal.Models;

public class Experience
{
    public Guid Id { get; set; }
    
    public string Position { get; set; }
    
    public string Place { get; set; }
    
    public DateTime StartDate { get; set; }
    
    public DateTime? EndDate { get; set; }
    
    public bool InProgress { get; set; }
    
    public string Description { get; set; }
}