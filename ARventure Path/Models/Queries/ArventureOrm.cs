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
    }
}
