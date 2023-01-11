using SmartCompany.Models;
using System.Xml.Linq;

namespace SmartCompany.Data.Interfaces
{
    public interface IPurchase
    {
        IEnumerable<Purchase> GetAllPurchases();

        void AddPurchase(Purchase purchase);

        void DeletePurchase(int id);
    }
}
