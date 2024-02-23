using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARventure_Path.Models
{
    public static class AchievementOrm
    {
        public static String Insert(achievement achievement)
        {
            Orm.db.achievement.Add(achievement);
            return Orm.MySaveChanges();
        }
        public static List<achievement> Select()
        {
            List<achievement> _achievement = Orm.db.achievement.ToList();

            return _achievement;
        }

        public static String Delete(achievement _achievement)
        {
            Orm.db.achievement.Remove(_achievement);
            return Orm.MySaveChanges();
        }
    }
}
