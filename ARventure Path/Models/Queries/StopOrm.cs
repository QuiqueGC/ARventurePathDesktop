using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARventure_Path.Models
{
    public static class StopOrm
    {
        public static String Insert(stop stop)
        {
            Orm.db.stop.Add(stop);
            return Orm.MySaveChanges();
        }

        public static List<stop> Select()
        {
            List<stop> _stop = Orm.db.stop.ToList();

            return _stop;
        }
        public static String Delete(stop _stop)
        {
            Orm.db.stop.Remove(_stop);
            return Orm.MySaveChanges();
        }
    }
}
