using SmartCompany.Models;

namespace SmartCompany.Data.Interfaces
{
    public interface IProfit
    {
        IEnumerable<Profit> GetAllProfits();

        void AddProfit(Profit profit);

        void DeleteProfit(int id);
    }
}
