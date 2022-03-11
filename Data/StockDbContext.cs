using Microsoft.EntityFrameworkCore;

namespace StockTracker.Data;
public class StockDbContext : DbContext
{
    #region Contructor
    public StockDbContext(DbContextOptions<StockDbContext> options)
            : base(options)
    {

    }
    #endregion

    #region Public properties
    public DbSet<Stock> Stocks { get; set; }
    #endregion

    #region Overidden methods
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Stock>().HasData(GetStocks());
        base.OnModelCreating(modelBuilder);
    }
    #endregion


    #region Private methods
    private List<Stock> GetStocks()
    {
        return new List<Stock>
    {
        new Stock {id = 1, ticker = "GME"},
        new Stock {id = 2, ticker = "AAPL"}
    };
    }
    #endregion
}