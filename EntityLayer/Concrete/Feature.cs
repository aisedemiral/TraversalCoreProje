using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete;

public class Feature
{
    [Key]
    public int FeatureID { get; set; }
    public string Title { get; set; }
    public string PostDescription { get; set; }
    public string PostImage { get; set; }
    public bool Status { get; set; }
}