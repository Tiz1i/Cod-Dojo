#pragma warning disable CS8618
/* 
Disabled Warning: "Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable."
We can disable this safely because we know the framework will assign non-null values when it constructs this class for us.
*/
using Microsoft.EntityFrameworkCore;

// kujdes namespacennnnn!!!!!!!/////
namespace ProductsCategories.Models;
// the MyContext class representing a session with our MySQL database, allowing us to query for or save data
public class MyContext : DbContext 
{ 
    public MyContext(DbContextOptions options) : base(options) { }
    // the "Monsters" table name will come from the DbSet property name
	///// ndryshoni DbSet me emrin e modelit tuaj dhe jasht <> vendoseni emrin e modelit ne shumes////
    public DbSet<Products> Products { get; set; } 
    public DbSet<Category> Categories { get; set; } 
     public DbSet<Association> Associations { get; set; } 
}

