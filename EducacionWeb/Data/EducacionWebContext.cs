using Microsoft.EntityFrameworkCore;

public class EducacionWebContext : DbContext
{
    public EducacionWebContext(DbContextOptions<EducacionWebContext> options) : base(options)
    {
    }

    public DbSet<EducacionWeb.Models.Registro> Registro { get; set; } = default!;
}