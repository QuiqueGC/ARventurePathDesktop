using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ARventure_Path.Utils
{
    public static class MyUtils
    {
        /// <summary>
        /// Enum para emplear a lo largo de la aplicación
        /// que nos indicará si el usuario se abre para crear
        /// modificar o borrar
        /// </summary>
        public enum FormType
        {
            Create,
            Modify,
            Delete
        }

        /// <summary>
        /// muestra el diálogo deconfirmaciónd de borrado
        /// </summary>
        /// <returns>true si confirma, false si cancela</returns>
        public static bool ShowConfirmDialogAndDelete()
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(
                "¿Estás seguro de que quieres borrar el elemento seleccionado?",
                "¡Cuidado!",
                buttons);

            if (result == DialogResult.Yes)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Chequea si se ha podido realizar la acción en la BBDD
        /// y muestra la respuesta en un diálogo
        /// </summary>
        /// <param name="msg">string con el error que se haya podido dar</param>
        public static void ShowPosibleError(String msg)
        {
            if (msg != "")
            {
                MessageBox.Show(msg, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Operación realizada con éxito.", "¡Maravilloso!");

            }
        }
    }
}
