using SmartCompany.Models;

namespace SmartCompany.Data.Interfaces
{
    public interface IOutlay
    {
        IEnumerable<Outlay> GetAllOutlays();

        //void AddOutlay(string name, double summ, string description);
        void AddOutlay(Outlay outlay);

        void DeleteOutlay(int id);
    }
}
