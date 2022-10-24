using Microsoft.EntityFrameworkCore;

namespace BankApp.Data.Context
{
    public class BankContext:DbContext
    {
        public BankContext(DbContextOptions<BankContext> options):base(options)
        {

        }
    }
}
