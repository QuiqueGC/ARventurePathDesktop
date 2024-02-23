using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARventure_Path.Models
{
    public static class StopOrm
    {
        public static void Insert(stop stop)
        {
            Orm.db.stop.Add(stop);
            Orm.db.SaveChanges();
        }

        public static List<stop> Select()
        {
            List<stop> _stop = Orm.db.stop.ToList();

            return _stop;
        }
        public static void Delete(stop _stop)
        {
            Orm.db.stop.Remove(_stop);
            Orm.db.SaveChanges();
        }
    }
}
