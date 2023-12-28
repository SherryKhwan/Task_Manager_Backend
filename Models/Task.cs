using System.ComponentModel.DataAnnotations;

public class Task
{
    [Key]
    public int Id { get; set; }
    [Required]
    public string Name { get; set; } = string.Empty;
    [Required]
    public string Description { get; set; } = string.Empty;
    [Required]
    public Status TaskStatus { get; set; } = Status.Incomplete;
    public DateTime DateCreated { get; set; } = DateTime.Now;
    [Required]
    public DateTime DateDue { get; set; }

    public enum Status
    {
        Incomplete,
        Successful,
        Failed
    }
}
