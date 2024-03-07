using ARventure_Path.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ARventure_Path.Forms
{
    public partial class FragmentsDialog : Form
    {
        public FragmentsDialog()
        {
            InitializeComponent();
        }

        public void loadFragments(story story)
        {
            // Cargar los detalles del story en el DataGridView
            bindingSourceFragments.DataSource = null;
            bindingSourceFragments.DataSource = FragmentOrm.Select(story);
        }
    }
}
