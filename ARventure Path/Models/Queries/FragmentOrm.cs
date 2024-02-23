using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARventure_Path.Models
{
    public static class FragmentOrm
    {
        public static void Insert(fragment fragment)
        {
            Orm.db.fragment.Add(fragment);
            Orm.db.SaveChanges();
        }

        public static List<fragment> Select()
        {
            List<fragment> _fragment = Orm.db.fragment.ToList();

            return _fragment;
        }

        public static void Delete(fragment _fragment)
        {
            Orm.db.fragment.Remove(_fragment);
            Orm.db.SaveChanges();
        }
    }
}
