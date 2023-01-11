using SmartCompany.Data.Interfaces;
using SmartCompany.Models;

namespace SmartCompany.Data.Services
{
    public class ProfitService : IProfit
    {
        private readonly DBContextTables _dbContextTables;

        public ProfitService(DBContextTables dbContextTables)
        {
            _dbContextTables = dbContextTables;
        }


        public IEnumerable<Profit> GetAllProfits()
        {
            return _dbContextTables.Profits;
        }


        public void AddProfit(Profit profit)
        {
            _dbContextTables.Profits.Add(profit);
            _dbContextTables.SaveChanges();
        }

        public void DeleteProfit(int id)
        {
            var deleteProfit = _dbContextTables.Profits.Find(id);

            if (deleteProfit != null)
            {
                _dbContextTables.Profits.Remove(deleteProfit);
                _dbContextTables.SaveChanges(true);
            }
        }
    }
}
