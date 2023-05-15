using Microsoft.EntityFrameworkCore;

namespace aspnetcoreapp.Data;

public class ApiDbContext : DbContext
{
    public ApiDbContext(DbContextOptions<ApiDbContext> options):base(options) {  }
}