
using BulkyBook_ASPNETCore_Web_MVC.Models;
using Microsoft.EntityFrameworkCore;

namespace BulkyBook_ASPNETCore_Web_MVC.Data
{
    public class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {

        }
        
        //create the categories table inside the database 
        //whatever model that you have to create inside the database you will have to create DbSet inside the ApplicationDbContext 
        public DbSet<Category> Categories { get; set; } //categories is the table name 
    }
}

