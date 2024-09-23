using Microsoft.AspNetCore.Identity;

namespace EntityLayer.Concrete;

public class AppUser:IdentityUser<int>
{
    public string ImageUrl { get; set; }
    public string Name { get; set; }
    public string SurName { get; set; }
    public string Gender { get; set; }
}