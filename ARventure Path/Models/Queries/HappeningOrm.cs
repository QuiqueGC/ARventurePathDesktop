using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARventure_Path.Models
{
    public static class HappeningOrm
    {
        public static String Insert(happening happening)
        {
            Orm.db.happening.Add(happening);
            return Orm.MySaveChanges();
        }

        public static List<happening> Select(String type)
        {
            List<happening> _happening = Orm.db.happening
                .Where(h => h.type.Contains(type))
                .ToList();

            return _happening;
        }

        public static List<happening> Select(story story)
        {
            List<happening> _happening = Orm.db.happening
                .Where(h => h.idStory == story.id)
                .ToList();

            return _happening;
        }

        public static String Delete(happening _happening)
        {
            Orm.db.happening.Remove(_happening);
            return Orm.MySaveChanges();
        }
    }
}
