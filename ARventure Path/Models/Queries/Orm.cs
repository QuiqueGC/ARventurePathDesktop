using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARventure_Path.Models
{
    public static class Orm
    {
        public static AbpEntities db = new AbpEntities();

        /// <summary>
        /// Extrae el mensaje de error de la excepción pertinente
        /// </summary>
        /// <param name="ex">la excepción que ha ocurrido</param>
        /// <returns>el mensaje de la excepción</returns>
        public static String ErrorMessage(SqlException ex)
        {
            String msg = "";

            switch (ex.Number)
            {
                case 2:
                    msg = "Servidor no operativo";
                    break;
                case 547:
                    msg = "El registro tiene datos relacionados";
                    break;
                case 2601:
                    msg = "Registro duplicado";
                    break;
                case 4060:
                    msg = "No se puede abrir la base de datos";
                    break;
                case 18456:
                    msg = "Error al iniciar sesión";
                    break;
                default:
                    msg = ex.Number + " : " + ex.Message;
                    break;
            }
            return msg;
        }

        /// <summary>
        /// Intenta guardar los cambios en la base de datos y
        /// en caso de que no se pueda, dará un error
        /// </summary>
        /// <returns>El mensaje de error en caso de que lo haya o un String vacío si todo
        /// es correcto</returns>
        public static String MySaveChanges()
        {
            String msg = "";

            try
            {
                Orm.db.SaveChanges();

            }catch (DbUpdateException ex) 
            {
                SqlException sqlException = (SqlException)ex.InnerException.InnerException;
                msg = Orm.ErrorMessage(sqlException);
                RejectChanges();
            }
            return msg;
        }


        /// <summary>
        /// Devuelve los datos internos de la aplicación al estado anterior
        /// para que se mantengan como en la base de datos
        /// </summary>
        public static void RejectChanges()
        {
            foreach (DbEntityEntry item in db.ChangeTracker.Entries())
            {
                switch (item.State)
                {
                    case System.Data.EntityState.Detached:
                        break;
                    case System.Data.EntityState.Unchanged:
                        break;
                    case System.Data.EntityState.Added:
                        item.State = System.Data.EntityState.Detached;
                        break;
                    case System.Data.EntityState.Deleted:
                        item.Reload();
                        break;
                    case System.Data.EntityState.Modified:
                        item.State = System.Data.EntityState.Unchanged;
                        break;
                    default:
                        break;
                }
            }
        }

        /// <summary>
        /// Update genérico para todas las clases
        /// </summary>
        /// <returns>El mensaje de error en caso de que
        /// lo haya, o un String vacío si todo es correcto</returns>
        public static String Update()
        {
            return MySaveChanges();
        }

    }
}
