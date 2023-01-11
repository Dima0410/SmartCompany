using SmartCompany.Data.Interfaces;
using SmartCompany.Models;

namespace SmartCompany.Data.Services
{
    public class OutlayService : IOutlay
    {
        private readonly DBContextTables _dBContextTables;

        public OutlayService(DBContextTables dBContextTables)
        {
            _dBContextTables = dBContextTables;
        }


        public IEnumerable<Outlay> GetAllOutlays()
        {
            return _dBContextTables.Outlays;
        }

        //public void AddOutlay(string name, double summ, string description)
        //{
        //    Outlay newOutlay = new Outlay()
        //    {
        //        Name = name,
        //        Summ = summ,
        //        Description = description,
        //        CreatedDate = DateTime.Now
        //    };

        //    _dBContextTables.Outlays.Add(newOutlay);
        //    _dBContextTables.SaveChanges();
        //}
        public void AddOutlay(Outlay outlay)
        {
            _dBContextTables.Outlays.Add(outlay);
            _dBContextTables.SaveChanges();
        }

        public void DeleteOutlay(int id)
        {
            var deleteOutlay = _dBContextTables.Outlays.Find(id);

            if (deleteOutlay != null)
            {
                _dBContextTables.Outlays.Remove(deleteOutlay);
                _dBContextTables.SaveChanges();
            }
        }
    }
}
