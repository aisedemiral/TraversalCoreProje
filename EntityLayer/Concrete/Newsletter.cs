using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete;

public class Newsletter
{
    [Key]
    public int NewletterID { get; set; }
    public string Mail { get; set; } 
}