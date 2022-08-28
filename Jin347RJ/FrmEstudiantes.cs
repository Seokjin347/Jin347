using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jin347RJ
{
    public partial class FrmEstudiantes : Form
    {
       
        private string Nombre, Edad, Carrera, Año;

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            int Reglon = dataGridView1.Rows.Add();
            // rellanos los datos del dataGridView

            dataGridView1.Rows[Reglon].Cells["CNombre"].Value = Nombre;
            dataGridView1.Rows[Reglon].Cells["CEdad"].Value = Edad;
            dataGridView1.Rows[Reglon].Cells["CCarrera"].Value = Carrera;
            dataGridView1.Rows[Reglon].Cells["CAño"].Value = Año;

        }

       

        public string pNombre
        {
            set
            {
                Nombre = value;
            }
        }

        public string pEdad
        {
            set
            {
                Edad = value;
            }
        }

        public string pCarrera
        {
            set
            {
                Carrera = value;
            }
        }

        private void FrmEstudiantes_Load(object sender, EventArgs e)
        {

        }

        public string pAño
        {
            set
            {
                Año = value;
            }
        }
        public FrmEstudiantes()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }




    }

}
