namespace Portfolio.Dal.Models;

public class Project
{
    public Guid Id {get; set;}
    
    public string Title { get; set;}
    
    public string Description { get; set;}
    
    public ICollection<Technology> Technologies { get; set; }
    
    public bool IsDeleted { get; set; }
    
    public bool IsCompleted { get; set; }
    
    public DateTime StartDate { get; set; }
    
    public DateTime EndDate { get; set; }
    
    public DateTime UpdatedDate { get; set; }
    
    //TODO: ADD HISTORY CHANGES AND UPDATE
}