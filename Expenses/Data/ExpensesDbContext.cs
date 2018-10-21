using Microsoft.EntityFrameworkCore;

namespace Expenses.Data
{
  public class ExpensesDbContext : DbContext
  {
    public ExpensesDbContext(DbContextOptions<ExpensesDbContext> options)
      : base(options)
    {
      Database.Migrate();
    }
    
    public DbSet<DbExpense> Expenses { get; set; }
  }
}
