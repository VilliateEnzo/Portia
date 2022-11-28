namespace Portfolio.Dal.Models;

public class Profile
{
    public Guid Id { get; set; }
    
    public string Name { get; set; }
    
    public string AboutMe { get; set; }
    
    public string Mail { get; set; }
    
    public DateTime DateOfBirth { get; set; }
    
    public ICollection<Photo> Photos { get; set; }
}