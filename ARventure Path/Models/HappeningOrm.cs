using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARventure_Path.Models
{
    public static class HappeningOrm
    {
        public static void Insert(happening happening)
        {
            Orm.db.happening.Add(happening);
            Orm.db.SaveChanges();
        }
    }
}
