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

        public static List<happening> Select(arventure arventure)
        {
            List<happening> _happenings = Orm.db.arventure
                .Where(h => h.id == arventure.id)
                .SelectMany(h => h.happening)
                .ToList();

            return _happenings;
        }


        public static String InsertForArventure(arventure arventure, happening happening)
        {
            try
            {
                // Asigna los happenings a la arventure
                arventure.happening.Add(happening);

                // Guarda los cambios en la base de datos
                return Orm.MySaveChanges();
            }
            catch (Exception ex)
            {
                return "Error al agregar happenings a la arventure: " + ex.Message;
            }
        }


        public static String Delete(happening _happening)
        {
            Orm.db.happening.Remove(_happening);
            return Orm.MySaveChanges();
        }
    }
}
