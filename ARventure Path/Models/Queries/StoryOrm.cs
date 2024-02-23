using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARventure_Path.Models
{
    public static class StoryOrm
    {
        public static String Insert(story story)
        {
            Orm.db.story.Add(story);
            return Orm.MySaveChanges();
        }

        public static List<story> Select()
        {
            List<story> _stories = Orm.db.story.ToList();

            return _stories;
        }
        public static String Delete(story _story)
        {
            Orm.db.story.Remove(_story);
            return Orm.MySaveChanges();
        }
    }
}
