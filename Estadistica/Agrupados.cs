using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estadistica
{
    class Agrupados
    {
        public void OpcionAgrupados(DataGridView DGV_agrupados_clase, Label lbl_n_agrup_clase, TextBox txt_media_agrup_clase, TextBox txt_variancia_agrup_clase, TextBox txt_ds_agrup, TextBox txt_cv_agrup_clase, TextBox txt_moda_agrup_clase, TextBox txt_mediana_agrup_clase)
        {
            double mc = 0, n_ag = 0, media_ag = 0, x_m_f_ag = 0, xx = 0, variancia_ag = 0, desviost_ag = 0, cv_ag = 0, moda_ag = 0, max_ag = 0, limite_inferior = 0, limite_superior, amplitud = 0, d1 = 0, d2 = 0, OAP = 0;
            int aux_ag = 0, aux_d1 = 0, aux_d2 = 0;

            foreach (DataGridViewRow x in DGV_agrupados_clase.Rows) //Calculo n datos agrupados 
            {
                if ((Convert.ToString(x.Cells["Columna_X1_ag"].Value) != "") || (Convert.ToString(x.Cells["Columna_X2_ag"].Value) != "") || (Convert.ToString(x.Cells["Columna_frec_sim_ag"].Value) != ""))
                {
                    n_ag += Convert.ToDouble(x.Cells["Columna_frec_sim_ag"].Value);
                    x.Cells["Columna_frec_acum_ag"].Value = n_ag; //Y agrego columna de frecuencia acumulada
                }
            }
            foreach (DataGridViewRow v in DGV_agrupados_clase.Rows) //Calculo MC y lo asigno a la columna MC
            {
                if ((Convert.ToString(v.Cells["Columna_X1_ag"].Value) != "") || (Convert.ToString(v.Cells["Columna_X2_ag"].Value) != "") || (Convert.ToString(v.Cells["Columna_frec_sim_ag"].Value) != ""))
                {
                    mc = ((Convert.ToDouble(v.Cells["Columna_X1_ag"].Value) + Convert.ToDouble(v.Cells["Columna_X2_ag"].Value)) / 2);
                    v.Cells["Columna_MC"].Value = mc;
                }
            }
            lbl_n_agrup_clase.Text = Convert.ToString("N: " + n_ag);
            DGV_agrupados_clase.Columns["Columna_MC"].Visible = true;
            DGV_agrupados_clase.Columns["Columna_frec_acum_ag"].Visible = true;

            foreach (DataGridViewRow x in DGV_agrupados_clase.Rows) //Calculo MC (Suma y division por dos de intervalos) datos agrupados y multiplico por frecuencia simple
            {
                xx += ((Convert.ToDouble(x.Cells["Columna_X1_ag"].Value) + Convert.ToDouble(x.Cells["Columna_X2_ag"].Value)) / 2) * Convert.ToDouble(x.Cells["Columna_frec_sim_ag"].Value);
            }

            media_ag = Convert.ToDouble(xx / n_ag);
            txt_media_agrup_clase.Text = Convert.ToString(media_ag);

            foreach (DataGridViewRow z in DGV_agrupados_clase.Rows) //Calculo el total de (x-m)^2.f de datos agrupados
            {
                if ((Convert.ToString(z.Cells["Columna_X1_ag"].Value) != "") || (Convert.ToString(z.Cells["Columna_X2_ag"].Value) != "") || (Convert.ToString(z.Cells["Columna_frec_sim_ag"].Value) != ""))
                {
                    x_m_f_ag += Math.Pow(Convert.ToDouble(z.Cells["Columna_MC"].Value) - media_ag, 2) * Convert.ToDouble(z.Cells["Columna_frec_sim_ag"].Value);
                }
            }
            //MessageBox.Show(Convert.ToString(x_m_f_ag));
            variancia_ag = Convert.ToDouble(x_m_f_ag / n_ag); //Calculo varianza datos agrupados S^2
            txt_variancia_agrup_clase.Text = Convert.ToString(variancia_ag);
            desviost_ag = Convert.ToDouble(Math.Sqrt(variancia_ag)); //Calculo desvio estandar en datos agrupados S
            txt_ds_agrup.Text = Convert.ToString(desviost_ag);
            cv_ag = Convert.ToDouble(desviost_ag / media_ag); //Calculo coeficiente de variación en datos agrupados CV
            txt_cv_agrup_clase.Text = Convert.ToString(cv_ag);


            foreach (DataGridViewRow q in DGV_agrupados_clase.Rows)
            {
                if ((Convert.ToString(q.Cells["Columna_X1_ag"].Value) != "") || (Convert.ToString(q.Cells["Columna_X2_ag"].Value) != "") || (Convert.ToString(q.Cells["Columna_frec_sim_ag"].Value) != ""))
                {
                    moda_ag = Convert.ToDouble(q.Cells["Columna_frec_sim_ag"].Value);
                    //Compara mayor columna F 
                    if (moda_ag > max_ag)
                    {
                        max_ag = moda_ag;
                        limite_inferior = Convert.ToDouble(q.Cells["Columna_X1_ag"].Value);
                        limite_superior = Convert.ToDouble(q.Cells["Columna_X2_ag"].Value);
                        amplitud = Convert.ToDouble(q.Cells["Columna_X2_ag"].Value) - Convert.ToDouble(q.Cells["Columna_X1_ag"].Value);
                        aux_ag++; //Cuento la fila modal
                        aux_d1 = Convert.ToInt16(DGV_agrupados_clase.Rows.Count - (DGV_agrupados_clase.Rows.Count - aux_ag)) - 1; //resto el total de filas, menos (la cantidad total de filas menos la cant modal) para obtener el valor ANTERIOR al modal
                        aux_d2 = aux_d1 + 1; //Obtengo el numero posterior al modal
                    }
                }
            }
            d1 = max_ag - Convert.ToDouble(DGV_agrupados_clase.Rows[aux_d1 - 1].Cells["Columna_frec_sim_ag"].Value); //Calculo d1
            d2 = max_ag - Convert.ToDouble(DGV_agrupados_clase.Rows[aux_d2].Cells["Columna_frec_sim_ag"].Value); //Calculo d2     
            moda_ag = limite_inferior + (d1 / (d1 + d2)) * amplitud; //Calculo la moda con la ecuación dada por el profesor
            txt_moda_agrup_clase.Text = Convert.ToString(moda_ag);

            OAP = (50 * n_ag) / 100;
            double mediana_ag = 0, mediana_ag_aux = 0, limite_inferior_med_ag = 0, f_med_ag = 0, aux_med_ag = 0, F_intAnt_acum = 0;
            int aux_pos = 0;
            foreach (DataGridViewRow m in DGV_agrupados_clase.Rows)
            {
                if ((Convert.ToString(m.Cells["Columna_X1_ag"].Value) != "") || (Convert.ToString(m.Cells["Columna_X2_ag"].Value) != "") || (Convert.ToString(m.Cells["Columna_frec_sim_ag"].Value) != ""))
                {
                    mediana_ag_aux = Convert.ToDouble(m.Cells["Columna_frec_acum_ag"].Value);
                    aux_med_ag++; //Cuento la fila modal
                    //Compara mayor columna F 
                    if (mediana_ag_aux > OAP)
                    {
                        limite_inferior_med_ag = Convert.ToDouble(m.Cells["Columna_X1_ag"].Value);
                        f_med_ag = Convert.ToDouble(m.Cells["Columna_frec_sim_ag"].Value);

                        aux_pos = Convert.ToInt16(DGV_agrupados_clase.Rows.Count - (DGV_agrupados_clase.Rows.Count - aux_med_ag) - 1); //resto el total de filas, menos (la cantidad total de filas menos la cant modal) para obtener el valor ANTERIOR al modal
                        break;
                    }
                }
            }
            F_intAnt_acum = Convert.ToDouble(DGV_agrupados_clase.Rows[aux_pos - 1].Cells["Columna_frec_acum_ag"].Value); //Calculo valor de la frecuencia anterior
            mediana_ag = Convert.ToDouble(limite_inferior_med_ag + ((OAP - F_intAnt_acum) / f_med_ag) * amplitud);//----> la amplitud se calcula en el modo. 
            txt_mediana_agrup_clase.Text = Convert.ToString(mediana_ag);
        }
    }
}
