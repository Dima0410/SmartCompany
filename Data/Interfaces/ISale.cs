using SmartCompany.Models;

namespace SmartCompany.Data.Interfaces
{
    public interface ISale
    {
        IEnumerable<Sale> GetAllSales();

        void AddSale(Sale sale);

        void DeleteSale(int id);
    }
}
