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

        public static List<arventure> Select(story story)
        {
            List<arventure> _arventure = Orm.db.arventure
                .Where(a => a.idStory == story.id)
                .ToList();

            return _arventure;
        }

        public static List<arventure> Select(route route)
        {
            List<arventure> _arventure = Orm.db.arventure
                .Where(a => a.idRoute == route.id)
                .ToList();

            return _arventure;
        }


        public static String Delete(arventure arventure)
        {
            Orm.db.arventure.Remove(arventure);
            return Orm.MySaveChanges();
        }
    }
}
