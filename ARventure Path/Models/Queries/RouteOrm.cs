using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARventure_Path.Models
{
    public static class RouteOrm
    {
        public static String Insert(route route)
        {
            Orm.db.route.Add(route);
            return Orm.MySaveChanges();
        }

        public static List<route> Select()
        {
            List<route> _routes = Orm.db.route.ToList();

            return _routes;
        }

        public static String Delete(route _route)
        {
            Orm.db.route.Remove(_route);
            return Orm.MySaveChanges();
        }
    }
}
