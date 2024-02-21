using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARventure_Path.Models
{
    public static class AchievementOrm
    {
        public static void Insert(achievement achievement)
        {
            Orm.db.achievement.Add(achievement);
            Orm.db.SaveChanges();
        }
    }
}
