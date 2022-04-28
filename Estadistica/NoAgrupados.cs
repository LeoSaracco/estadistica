using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estadistica
{
    class NoAgrupados
    {
        public void OpcionNoAgrupados(DataGridView DGV_noagrupados_clase, Label lbl_n_noagrup_clase, TextBox txt_media_noagrup_clase, TextBox txt_moda_noagrup_clase, TextBox txt_mediana_noagrup_clase, TextBox txt_variancia_noagrup_clase, TextBox txt_ds_noagrup_clase, TextBox txt_cv_noagrup_clase)
        {
            double n = 0, Moda = 0, MAX = 0, media = 0, totalXxF = 0, AUX_MODA = 0, mediana = 0, AUX_MEDIANA = 0, x_m_f = 0, variancia = 0, desviost = 0, cv = 0;

            foreach (DataGridViewRow x in DGV_noagrupados_clase.Rows) // calculo N
            {
                n += Convert.ToDouble(x.Cells["Columna_frec_simp"].Value);
            }
            lbl_n_noagrup_clase.Visible = true;
            lbl_n_noagrup_clase.Text = Convert.ToString("N: " + n);


            foreach (DataGridViewRow g in DGV_noagrupados_clase.Rows) //Calcula el X.F (Acumulando)
            {
                totalXxF += Convert.ToDouble(g.Cells["Columna_X"].Value) * Convert.ToDouble(g.Cells["Columna_frec_simp"].Value);
            }
            //Calcula la media
            media = totalXxF / n;
            txt_media_noagrup_clase.Text = Convert.ToString(media);

            //Calculo Moda
            foreach (DataGridViewRow q in DGV_noagrupados_clase.Rows)
            {
                Moda = Convert.ToDouble(q.Cells["Columna_frec_simp"].Value);
                //Compara mayor columna F 
                if (Moda > MAX)
                {
                    AUX_MODA = Convert.ToDouble(q.Cells["Columna_X"].Value); //Compara con X cuando el mayor es tal
                    MAX = Moda;
                }
            }
            txt_moda_noagrup_clase.Text = Convert.ToString(AUX_MODA);

            mediana = (n + 1) / 2;
            foreach (DataGridViewRow w in DGV_noagrupados_clase.Rows) //Calculo mediana
            {
                AUX_MEDIANA += Convert.ToDouble(w.Cells["Columna_frec_simp"].Value);
                if (mediana <= AUX_MEDIANA)
                {
                    mediana = Convert.ToDouble(w.Cells["Columna_X"].Value);
                    txt_mediana_noagrup_clase.Text = Convert.ToString(mediana);
                    break; //Cuando encuentra el valor que supera a la mediana, para.
                }
            }
            foreach (DataGridViewRow z in DGV_noagrupados_clase.Rows) //Calculo el total de (x-m)^2.f
            {
                x_m_f += Math.Pow(Convert.ToDouble(z.Cells["Columna_X"].Value) - media, 2) * Convert.ToDouble(z.Cells["Columna_frec_simp"].Value);
            }
            variancia = Convert.ToDouble(x_m_f / n); //Calculo variancia S^2
            txt_variancia_noagrup_clase.Text = Convert.ToString(variancia);

            desviost = Convert.ToDouble(Math.Sqrt(variancia));//Calculo el desvio standar
            txt_ds_noagrup_clase.Text = Convert.ToString(desviost);

            cv = Convert.ToDouble((desviost / media)); //Calculo coeficiente de variacion
            txt_cv_noagrup_clase.Text = Convert.ToString(cv);
        }
    }
}
