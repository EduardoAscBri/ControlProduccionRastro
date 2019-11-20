using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FYRASA.Forms
{
    public partial class PesosCanastas : Pesos
    {
        public PesosCanastas()
        {
            InitializeComponent();
            this.lblTitle.Text = "Peso en canastas";
        }


        private void PesosCanastas_Load(object sender, EventArgs e)
        {

        }
    }
}
