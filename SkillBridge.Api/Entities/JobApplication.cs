using System.ComponentModel.DataAnnotations;
using SkillBridge.Api.Entities;

public class JobApplication
{
    [Required, Key]
    public int Id {get; set;}
    [Required]
    public Job AppliedJob {get; set;}
    public int AppliedJobId {get; set;}
    public User AppliedBy {get; set;}
    public int AppliedById {get; set;}
    public DateTime ApplicationDate {get; set;}
    public string Status {get; set;}
   public bool isActive {get; set;}
   public string CoverLetter {get; set;}
   public string ResumePath {get; set;}
}