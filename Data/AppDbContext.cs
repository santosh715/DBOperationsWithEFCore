using Microsoft.EntityFrameworkCore;

public class AppDbContext : DbContext{
    public AppDbContext(DbContextOptions<AppDbContext>options):base(options){

    }

    public DbSet<Student>?Students{get;set;}

    public DbSet<Language>?Languages{get;set;}
}