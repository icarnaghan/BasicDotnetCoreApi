using Microsoft.EntityFrameworkCore;  
namespace WebApiCore.Models {     
public class WebApiCoreContext : DbContext     
  {         
    public WebApiCoreContext(DbContextOptions<WebApiCoreContext> options)                            : base(options)         
{         
}       
    public DbSet<TodoItem> TodoItems { get; set; }     
  
   } 
}