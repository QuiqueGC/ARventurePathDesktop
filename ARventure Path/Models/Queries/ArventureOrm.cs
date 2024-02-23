using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARventure_Path.Models
{
    public static class ArventureOrm
    {
        public static void Insert(arventure arventure)
        {
            Orm.db.arventure.Add(arventure);
            Orm.db.SaveChanges();
        }

        public static List<arventure> Select()
        {
            List<arventure> _arventure = Orm.db.arventure.ToList();

            return _arventure;
        }
        public static void Delete(arventure _arventure)
        {
            Orm.db.arventure.Remove(_arventure);
            Orm.db.SaveChanges();
        }
    }
}
