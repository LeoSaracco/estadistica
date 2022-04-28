using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estadistica
{
    public partial class Form_inicial : Form
    {
        public Form_inicial()
        {
            InitializeComponent();
        }

        private void btn_noagrupados_Click(object sender, EventArgs e)
        {
            gb_agrupados.Visible = false;
            gb_noagrupados.Visible = true;
        }

        Agrupados agp = new Agrupados();
        NoAgrupados nagp = new NoAgrupados();

        //DATOS NO AGRUPADOS
        private void btn_calcula_noagr_Click(object sender, EventArgs e) //Calculo datos no agrupados
        {
            DGV_noagrupados.Sort(this.DGV_noagrupados.Columns["Columna_X"], ListSortDirection.Ascending); //Ordeno columna X
            nagp.OpcionNoAgrupados(DGV_noagrupados, lbl_n_noagrup, txt_media_noagrup, txt_moda_noagrup, txt_mediana_noagrup, txt_variancia_noagrup, txt_ds_noagrup, txt_cv_noagrup);
        }

        private void btn_agrupados_Click(object sender, EventArgs e)
        {
            gb_noagrupados.Visible=false;
            gb_agrupados.Visible = true;
        }


        //DATOS AGRUPADOS
        private void btn_calcular_agrupados_Click(object sender, EventArgs e) //Calculo datos agrupados
        {
            agp.OpcionAgrupados(DGV_agrupados, lbl_n_agrup, txt_media_agrup, txt_variancia_agrup, txt_ds_agrup, txt_cv_agrup, txt_moda_agrup, txt_mediana_agrup);
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            DGV_agrupados.Rows.Clear();
            DGV_noagrupados.Rows.Clear();
            txt_cv_agrup.Clear();
            txt_cv_noagrup.Clear();
            txt_ds_agrup.Clear();
            txt_ds_noagrup.Clear();
            txt_media_agrup.Clear();
            txt_media_noagrup.Clear();
            txt_mediana_agrup.Clear();
            txt_mediana_noagrup.Clear();
            txt_moda_agrup.Clear();
            txt_moda_noagrup.Clear();
            txt_variancia_agrup.Clear();
            txt_variancia_noagrup.Clear();
            gb_agrupados.Visible = false;
            gb_noagrupados.Visible = false;
            DGV_agrupados.Rows.Add();
            DGV_noagrupados.Rows.Add();
        }

        private void DGV_agrupados_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(13)) // enter
                DGV_agrupados.Rows.Add();
        }

        private void Form_inicial_Load(object sender, EventArgs e)
        {
            DGV_agrupados.Rows.Add();
            DGV_noagrupados.Rows.Add();
        }

        private void DGV_noagrupados_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(13)) // enter
                DGV_noagrupados.Rows.Add();
        }
    }
}