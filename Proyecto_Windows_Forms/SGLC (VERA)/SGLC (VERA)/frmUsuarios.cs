using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGLC__VERA_
{
    public partial class frmUsuarios : Form
    {
        public frmUsuarios()
        {
            InitializeComponent();
        }

        private void btnPanelControl_Click(object sender, EventArgs e)
        {
            frmPanelControl panelControl = new frmPanelControl();
            panelControl.Show();
            this.Hide();
        }

        private void btnLaboratorios_Click(object sender, EventArgs e)
        {
            frmLaboratorio laboratorio = new frmLaboratorio();
            laboratorio.Show();
            this.Hide();
        }

        private void btnComputadoras_Click(object sender, EventArgs e)
        {
            frmComputadoras frmComputadoras = new frmComputadoras();
            frmComputadoras.Show();
            this.Hide();
        }

        private void btnIncidenciasEscaladas_Click(object sender, EventArgs e)
        {
            frmIncidenciasEscalas incidenciasEscalas = new frmIncidenciasEscalas();
            incidenciasEscalas.Show();
            this.Hide();
        }

        private void btnAsignarEscaladas_Click(object sender, EventArgs e)
        {
            frmAsignarAsistentes asignarAsistentes = new frmAsignarAsistentes();
            asignarAsistentes.Show();
            this.Hide();
        }

        private void btnHistorialGeneral_Click(object sender, EventArgs e)
        {
            frmHistorialGeneral historialGeneral = new frmHistorialGeneral();
            historialGeneral.Show();
            this.Hide();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            frmInicioSesion cerrarseeion = new frmInicioSesion();
            cerrarseeion.Show();
            this.Hide();
        }
    }
}
