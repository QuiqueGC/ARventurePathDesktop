using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARventure_Path.Models
{
    public static class FragmentOrm
    {
        public static String Insert(fragment fragment)
        {
            Orm.db.fragment.Add(fragment);
            return Orm.MySaveChanges();
        }

        public static List<fragment> Select()
        {
            List<fragment> _fragment = Orm.db.fragment.ToList();

            return _fragment;
        }

        public static List<fragment> Select(story story)
        {
            List<fragment> fragments = Orm.db.fragment
                .Where(f =>
                f.story.id == story.id)
                .ToList();
            return fragments;
        }

        public static String Delete(fragment _fragment)
        {
            Orm.db.fragment.Remove(_fragment);
            return Orm.MySaveChanges();
        }
    }
}
