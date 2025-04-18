using System;
using Microsoft.EntityFrameworkCore;

namespace Expense_Tracker.Models;

public class ApplicationDbContext:DbContext
{
    public ApplicationDbContext(DbContextOptions options):base(options)
    {
        
    }

    public DbSet<Transaction> Transaction { get; set; }
    public DbSet<Category> Category { get; set; }
}
