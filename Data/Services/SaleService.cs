using SmartCompany.Data.Interfaces;
using SmartCompany.Models;

namespace SmartCompany.Data.Services
{
    public class SaleService : ISale
    {
        private readonly DBContextTables _dbContextTables;

        public SaleService(DBContextTables dbContextTables)
        {
            _dbContextTables = dbContextTables;
        }


        public IEnumerable<Sale> GetAllSales()
        {
            return _dbContextTables.Sales;
        }

        public void AddSale(Sale sale)
        {
            _dbContextTables.Sales.Add(sale);
            _dbContextTables.SaveChanges();
        }

        public void DeleteSale(int id)
        {
            var deleteSale = _dbContextTables.Sales.Find(id);

            if (deleteSale != null)
            {
                _dbContextTables.Sales.Remove(deleteSale);
                _dbContextTables.SaveChanges(true);
            }
        }
    }
}
