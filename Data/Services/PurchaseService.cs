using SmartCompany.Data.Interfaces;
using SmartCompany.Models;

namespace SmartCompany.Data.Services
{
    public class PurchaseService : IPurchase
    {
        private readonly DBContextTables _dBContextTables;

        public PurchaseService(DBContextTables dBContextTables)
        {
            _dBContextTables = dBContextTables;
        }


        public IEnumerable<Purchase> GetAllPurchases()
        {
            return _dBContextTables.Purchases;
        }


        
        public void AddPurchase(Purchase purchase)
        {
            _dBContextTables.Purchases.Add(purchase);
            _dBContextTables.SaveChanges();
        }


        public void DeletePurchase(int id)
        {
            var deletePurchase = _dBContextTables.Purchases.Find(id);

            if (deletePurchase != null)
            {
                _dBContextTables.Purchases.Remove(deletePurchase);
                _dBContextTables.SaveChanges();
            }
        }
    }
}
