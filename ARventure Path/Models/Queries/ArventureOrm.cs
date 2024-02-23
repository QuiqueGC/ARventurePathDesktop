using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARventure_Path.Models
{
    public static class ArventureOrm
    {
        public static String Insert(arventure arventure)
        {
            Orm.db.arventure.Add(arventure);
            return Orm.MySaveChanges();
        }

        public static List<arventure> Select()
        {
            List<arventure> _arventure = Orm.db.arventure.ToList();

            return _arventure;
        }
        public static String Delete(arventure _arventure)
        {
            Orm.db.arventure.Remove(_arventure);
            return Orm.MySaveChanges();
        }
    }
}
