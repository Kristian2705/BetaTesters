using BetaTesters.Data;
using Microsoft.EntityFrameworkCore;

namespace BetaTesters.Tests.Mocks
{
    public static class DatabaseMock
    {
        public static BetaTestersDbContext Instance
        {
            get
            {
                var dbContextOptions = new DbContextOptionsBuilder<BetaTestersDbContext>()
                    .UseInMemoryDatabase("BetaTestersInMemoryDb" + DateTime.Now.Ticks.ToString())
                    .Options;

                return new BetaTestersDbContext(dbContextOptions);
            }
        }
    }
}
