using Microsoft.AspNet.Identity.EntityFramework;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;


namespace MadShoppers.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        [Required]
        [Display(Name = "Contact Information")]
        [Range(0, 10)]
        [DataType(DataType.PhoneNumber)]
        public int phonenumber { get; set; }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Itemclass> item { get; set; }
        public DbSet<Customerclass> customer { get; set; }
        public DbSet<purchaseclass> purchase { get; set; }
        public ApplicationDbContext()
            : base("DefaultConnection")
        {
        }
    }
}