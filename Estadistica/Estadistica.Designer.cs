namespace Estadistica
{
    partial class Form_inicial
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_tipo_datos = new System.Windows.Forms.Label();
            this.btn_noagrupados = new System.Windows.Forms.Button();
            this.gb_noagrupados = new System.Windows.Forms.GroupBox();
            this.txt_variancia_noagrup = new System.Windows.Forms.TextBox();
            this.lbl_variancia = new System.Windows.Forms.Label();
            this.lbl_n_noagrup = new System.Windows.Forms.Label();
            this.btn_calcula_noagr = new System.Windows.Forms.Button();
            this.txt_cv_noagrup = new System.Windows.Forms.TextBox();
            this.lbl_cv = new System.Windows.Forms.Label();
            this.txt_ds_noagrup = new System.Windows.Forms.TextBox();
            this.lbl_desv_st = new System.Windows.Forms.Label();
            this.txt_mediana_noagrup = new System.Windows.Forms.TextBox();
            this.lbl_mediana = new System.Windows.Forms.Label();
            this.txt_moda_noagrup = new System.Windows.Forms.TextBox();
            this.lbl_moda = new System.Windows.Forms.Label();
            this.txt_media_noagrup = new System.Windows.Forms.TextBox();
            this.lbl_media = new System.Windows.Forms.Label();
            this.DGV_noagrupados = new System.Windows.Forms.DataGridView();
            this.Columna_X = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Columna_frec_simp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gb_agrupados = new System.Windows.Forms.GroupBox();
            this.lbl_n_agrup = new System.Windows.Forms.Label();
            this.txt_variancia_agrup = new System.Windows.Forms.TextBox();
            this.lbl_variancia_agrup = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_calcular_agrupados = new System.Windows.Forms.Button();
            this.txt_cv_agrup = new System.Windows.Forms.TextBox();
            this.lbl_cv_agrup = new System.Windows.Forms.Label();
            this.txt_ds_agrup = new System.Windows.Forms.TextBox();
            this.lbl_desv_st_agrup = new System.Windows.Forms.Label();
            this.txt_mediana_agrup = new System.Windows.Forms.TextBox();
            this.lbl_mediana_agrup = new System.Windows.Forms.Label();
            this.txt_moda_agrup = new System.Windows.Forms.TextBox();
            this.lbl_moda_agrup = new System.Windows.Forms.Label();
            this.txt_media_agrup = new System.Windows.Forms.TextBox();
            this.lbl_media_agrup = new System.Windows.Forms.Label();
            this.DGV_agrupados = new System.Windows.Forms.DataGridView();
            this.Columna_X1_ag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Columna_X2_ag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Columna_MC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Columna_frec_sim_ag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Columna_frec_acum_ag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_agrupados = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gb_noagrupados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_noagrupados)).BeginInit();
            this.gb_agrupados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_agrupados)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_tipo_datos
            // 
            this.lbl_tipo_datos.AutoSize = true;
            this.lbl_tipo_datos.Location = new System.Drawing.Point(12, 27);
            this.lbl_tipo_datos.Name = "lbl_tipo_datos";
            this.lbl_tipo_datos.Size = new System.Drawing.Size(127, 13);
            this.lbl_tipo_datos.TabIndex = 0;
            this.lbl_tipo_datos.Text = "Seleccione tipo de datos:";
            // 
            // btn_noagrupados
            // 
            this.btn_noagrupados.BackColor = System.Drawing.SystemColors.Control;
            this.btn_noagrupados.Font = new System.Drawing.Font("Arial", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_noagrupados.ForeColor = System.Drawing.Color.Red;
            this.btn_noagrupados.Location = new System.Drawing.Point(237, 12);
            this.btn_noagrupados.Name = "btn_noagrupados";
            this.btn_noagrupados.Size = new System.Drawing.Size(75, 42);
            this.btn_noagrupados.TabIndex = 1;
            this.btn_noagrupados.Text = "No agrupados";
            this.btn_noagrupados.UseVisualStyleBackColor = false;
            this.btn_noagrupados.Click += new System.EventHandler(this.btn_noagrupados_Click);
            // 
            // gb_noagrupados
            // 
            this.gb_noagrupados.Controls.Add(this.txt_variancia_noagrup);
            this.gb_noagrupados.Controls.Add(this.lbl_variancia);
            this.gb_noagrupados.Controls.Add(this.lbl_n_noagrup);
            this.gb_noagrupados.Controls.Add(this.btn_calcula_noagr);
            this.gb_noagrupados.Controls.Add(this.txt_cv_noagrup);
            this.gb_noagrupados.Controls.Add(this.lbl_cv);
            this.gb_noagrupados.Controls.Add(this.txt_ds_noagrup);
            this.gb_noagrupados.Controls.Add(this.lbl_desv_st);
            this.gb_noagrupados.Controls.Add(this.txt_mediana_noagrup);
            this.gb_noagrupados.Controls.Add(this.lbl_mediana);
            this.gb_noagrupados.Controls.Add(this.txt_moda_noagrup);
            this.gb_noagrupados.Controls.Add(this.lbl_moda);
            this.gb_noagrupados.Controls.Add(this.txt_media_noagrup);
            this.gb_noagrupados.Controls.Add(this.lbl_media);
            this.gb_noagrupados.Controls.Add(this.DGV_noagrupados);
            this.gb_noagrupados.Location = new System.Drawing.Point(18, 60);
            this.gb_noagrupados.Name = "gb_noagrupados";
            this.gb_noagrupados.Size = new System.Drawing.Size(371, 475);
            this.gb_noagrupados.TabIndex = 2;
            this.gb_noagrupados.TabStop = false;
            this.gb_noagrupados.Text = "No agrupados";
            this.gb_noagrupados.Visible = false;
            // 
            // txt_variancia_noagrup
            // 
            this.txt_variancia_noagrup.Location = new System.Drawing.Point(109, 385);
            this.txt_variancia_noagrup.Name = "txt_variancia_noagrup";
            this.txt_variancia_noagrup.Size = new System.Drawing.Size(223, 20);
            this.txt_variancia_noagrup.TabIndex = 13;
            // 
            // lbl_variancia
            // 
            this.lbl_variancia.AutoSize = true;
            this.lbl_variancia.Location = new System.Drawing.Point(20, 388);
            this.lbl_variancia.Name = "lbl_variancia";
            this.lbl_variancia.Size = new System.Drawing.Size(54, 13);
            this.lbl_variancia.TabIndex = 12;
            this.lbl_variancia.Text = "Variancia:";
            // 
            // lbl_n_noagrup
            // 
            this.lbl_n_noagrup.AutoSize = true;
            this.lbl_n_noagrup.Location = new System.Drawing.Point(283, 134);
            this.lbl_n_noagrup.Name = "lbl_n_noagrup";
            this.lbl_n_noagrup.Size = new System.Drawing.Size(0, 13);
            this.lbl_n_noagrup.TabIndex = 11;
            this.lbl_n_noagrup.Visible = false;
            // 
            // btn_calcula_noagr
            // 
            this.btn_calcula_noagr.BackColor = System.Drawing.Color.Transparent;
            this.btn_calcula_noagr.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_calcula_noagr.ForeColor = System.Drawing.Color.Black;
            this.btn_calcula_noagr.Location = new System.Drawing.Point(283, 64);
            this.btn_calcula_noagr.Name = "btn_calcula_noagr";
            this.btn_calcula_noagr.Size = new System.Drawing.Size(75, 42);
            this.btn_calcula_noagr.TabIndex = 3;
            this.btn_calcula_noagr.Text = "Calcular";
            this.btn_calcula_noagr.UseVisualStyleBackColor = false;
            this.btn_calcula_noagr.Click += new System.EventHandler(this.btn_calcula_noagr_Click);
            // 
            // txt_cv_noagrup
            // 
            this.txt_cv_noagrup.Location = new System.Drawing.Point(150, 446);
            this.txt_cv_noagrup.Name = "txt_cv_noagrup";
            this.txt_cv_noagrup.Size = new System.Drawing.Size(182, 20);
            this.txt_cv_noagrup.TabIndex = 10;
            // 
            // lbl_cv
            // 
            this.lbl_cv.AutoSize = true;
            this.lbl_cv.Location = new System.Drawing.Point(20, 449);
            this.lbl_cv.Name = "lbl_cv";
            this.lbl_cv.Size = new System.Drawing.Size(124, 13);
            this.lbl_cv.TabIndex = 9;
            this.lbl_cv.Text = "Coeficiente de variación:";
            // 
            // txt_ds_noagrup
            // 
            this.txt_ds_noagrup.Location = new System.Drawing.Point(109, 417);
            this.txt_ds_noagrup.Name = "txt_ds_noagrup";
            this.txt_ds_noagrup.Size = new System.Drawing.Size(223, 20);
            this.txt_ds_noagrup.TabIndex = 8;
            // 
            // lbl_desv_st
            // 
            this.lbl_desv_st.AutoSize = true;
            this.lbl_desv_st.Location = new System.Drawing.Point(20, 420);
            this.lbl_desv_st.Name = "lbl_desv_st";
            this.lbl_desv_st.Size = new System.Drawing.Size(83, 13);
            this.lbl_desv_st.TabIndex = 7;
            this.lbl_desv_st.Text = "Desvío standar:";
            // 
            // txt_mediana_noagrup
            // 
            this.txt_mediana_noagrup.Location = new System.Drawing.Point(109, 350);
            this.txt_mediana_noagrup.Name = "txt_mediana_noagrup";
            this.txt_mediana_noagrup.Size = new System.Drawing.Size(223, 20);
            this.txt_mediana_noagrup.TabIndex = 6;
            // 
            // lbl_mediana
            // 
            this.lbl_mediana.AutoSize = true;
            this.lbl_mediana.Location = new System.Drawing.Point(20, 353);
            this.lbl_mediana.Name = "lbl_mediana";
            this.lbl_mediana.Size = new System.Drawing.Size(51, 13);
            this.lbl_mediana.TabIndex = 5;
            this.lbl_mediana.Text = "Mediana:";
            // 
            // txt_moda_noagrup
            // 
            this.txt_moda_noagrup.Location = new System.Drawing.Point(109, 316);
            this.txt_moda_noagrup.Name = "txt_moda_noagrup";
            this.txt_moda_noagrup.Size = new System.Drawing.Size(223, 20);
            this.txt_moda_noagrup.TabIndex = 4;
            // 
            // lbl_moda
            // 
            this.lbl_moda.AutoSize = true;
            this.lbl_moda.Location = new System.Drawing.Point(20, 316);
            this.lbl_moda.Name = "lbl_moda";
            this.lbl_moda.Size = new System.Drawing.Size(37, 13);
            this.lbl_moda.TabIndex = 3;
            this.lbl_moda.Text = "Moda:";
            // 
            // txt_media_noagrup
            // 
            this.txt_media_noagrup.Location = new System.Drawing.Point(109, 279);
            this.txt_media_noagrup.Name = "txt_media_noagrup";
            this.txt_media_noagrup.Size = new System.Drawing.Size(223, 20);
            this.txt_media_noagrup.TabIndex = 2;
            // 
            // lbl_media
            // 
            this.lbl_media.AutoSize = true;
            this.lbl_media.Location = new System.Drawing.Point(20, 279);
            this.lbl_media.Name = "lbl_media";
            this.lbl_media.Size = new System.Drawing.Size(39, 13);
            this.lbl_media.TabIndex = 1;
            this.lbl_media.Text = "Media:";
            // 
            // DGV_noagrupados
            // 
            this.DGV_noagrupados.AllowUserToAddRows = false;
            this.DGV_noagrupados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_noagrupados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_noagrupados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Columna_X,
            this.Columna_frec_simp});
            this.DGV_noagrupados.Location = new System.Drawing.Point(23, 19);
            this.DGV_noagrupados.Name = "DGV_noagrupados";
            this.DGV_noagrupados.RowHeadersVisible = false;
            this.DGV_noagrupados.Size = new System.Drawing.Size(254, 242);
            this.DGV_noagrupados.TabIndex = 0;
            this.DGV_noagrupados.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DGV_noagrupados_KeyPress);
            // 
            // Columna_X
            // 
            this.Columna_X.HeaderText = "     X";
            this.Columna_X.Name = "Columna_X";
            // 
            // Columna_frec_simp
            // 
            this.Columna_frec_simp.HeaderText = "     F";
            this.Columna_frec_simp.Name = "Columna_frec_simp";
            // 
            // gb_agrupados
            // 
            this.gb_agrupados.Controls.Add(this.lbl_n_agrup);
            this.gb_agrupados.Controls.Add(this.txt_variancia_agrup);
            this.gb_agrupados.Controls.Add(this.lbl_variancia_agrup);
            this.gb_agrupados.Controls.Add(this.label2);
            this.gb_agrupados.Controls.Add(this.btn_calcular_agrupados);
            this.gb_agrupados.Controls.Add(this.txt_cv_agrup);
            this.gb_agrupados.Controls.Add(this.lbl_cv_agrup);
            this.gb_agrupados.Controls.Add(this.txt_ds_agrup);
            this.gb_agrupados.Controls.Add(this.lbl_desv_st_agrup);
            this.gb_agrupados.Controls.Add(this.txt_mediana_agrup);
            this.gb_agrupados.Controls.Add(this.lbl_mediana_agrup);
            this.gb_agrupados.Controls.Add(this.txt_moda_agrup);
            this.gb_agrupados.Controls.Add(this.lbl_moda_agrup);
            this.gb_agrupados.Controls.Add(this.txt_media_agrup);
            this.gb_agrupados.Controls.Add(this.lbl_media_agrup);
            this.gb_agrupados.Controls.Add(this.DGV_agrupados);
            this.gb_agrupados.Location = new System.Drawing.Point(18, 60);
            this.gb_agrupados.Name = "gb_agrupados";
            this.gb_agrupados.Size = new System.Drawing.Size(380, 475);
            this.gb_agrupados.TabIndex = 3;
            this.gb_agrupados.TabStop = false;
            this.gb_agrupados.Text = "Agrupados";
            this.gb_agrupados.Visible = false;
            // 
            // lbl_n_agrup
            // 
            this.lbl_n_agrup.AutoSize = true;
            this.lbl_n_agrup.Location = new System.Drawing.Point(289, 134);
            this.lbl_n_agrup.Name = "lbl_n_agrup";
            this.lbl_n_agrup.Size = new System.Drawing.Size(0, 13);
            this.lbl_n_agrup.TabIndex = 14;
            // 
            // txt_variancia_agrup
            // 
            this.txt_variancia_agrup.Location = new System.Drawing.Point(109, 385);
            this.txt_variancia_agrup.Name = "txt_variancia_agrup";
            this.txt_variancia_agrup.Size = new System.Drawing.Size(223, 20);
            this.txt_variancia_agrup.TabIndex = 13;
            // 
            // lbl_variancia_agrup
            // 
            this.lbl_variancia_agrup.AutoSize = true;
            this.lbl_variancia_agrup.Location = new System.Drawing.Point(20, 388);
            this.lbl_variancia_agrup.Name = "lbl_variancia_agrup";
            this.lbl_variancia_agrup.Size = new System.Drawing.Size(54, 13);
            this.lbl_variancia_agrup.TabIndex = 12;
            this.lbl_variancia_agrup.Text = "Variancia:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(283, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 11;
            this.label2.Visible = false;
            // 
            // btn_calcular_agrupados
            // 
            this.btn_calcular_agrupados.BackColor = System.Drawing.Color.Transparent;
            this.btn_calcular_agrupados.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_calcular_agrupados.ForeColor = System.Drawing.Color.Black;
            this.btn_calcular_agrupados.Location = new System.Drawing.Point(283, 105);
            this.btn_calcular_agrupados.Name = "btn_calcular_agrupados";
            this.btn_calcular_agrupados.Size = new System.Drawing.Size(75, 42);
            this.btn_calcular_agrupados.TabIndex = 3;
            this.btn_calcular_agrupados.Text = "Calcular";
            this.btn_calcular_agrupados.UseVisualStyleBackColor = false;
            this.btn_calcular_agrupados.Click += new System.EventHandler(this.btn_calcular_agrupados_Click);
            // 
            // txt_cv_agrup
            // 
            this.txt_cv_agrup.Location = new System.Drawing.Point(150, 446);
            this.txt_cv_agrup.Name = "txt_cv_agrup";
            this.txt_cv_agrup.Size = new System.Drawing.Size(182, 20);
            this.txt_cv_agrup.TabIndex = 10;
            // 
            // lbl_cv_agrup
            // 
            this.lbl_cv_agrup.AutoSize = true;
            this.lbl_cv_agrup.Location = new System.Drawing.Point(20, 449);
            this.lbl_cv_agrup.Name = "lbl_cv_agrup";
            this.lbl_cv_agrup.Size = new System.Drawing.Size(124, 13);
            this.lbl_cv_agrup.TabIndex = 9;
            this.lbl_cv_agrup.Text = "Coeficiente de variación:";
            // 
            // txt_ds_agrup
            // 
            this.txt_ds_agrup.Location = new System.Drawing.Point(109, 417);
            this.txt_ds_agrup.Name = "txt_ds_agrup";
            this.txt_ds_agrup.Size = new System.Drawing.Size(223, 20);
            this.txt_ds_agrup.TabIndex = 8;
            // 
            // lbl_desv_st_agrup
            // 
            this.lbl_desv_st_agrup.AutoSize = true;
            this.lbl_desv_st_agrup.Location = new System.Drawing.Point(20, 420);
            this.lbl_desv_st_agrup.Name = "lbl_desv_st_agrup";
            this.lbl_desv_st_agrup.Size = new System.Drawing.Size(83, 13);
            this.lbl_desv_st_agrup.TabIndex = 7;
            this.lbl_desv_st_agrup.Text = "Desvío standar:";
            // 
            // txt_mediana_agrup
            // 
            this.txt_mediana_agrup.Location = new System.Drawing.Point(109, 350);
            this.txt_mediana_agrup.Name = "txt_mediana_agrup";
            this.txt_mediana_agrup.Size = new System.Drawing.Size(223, 20);
            this.txt_mediana_agrup.TabIndex = 6;
            // 
            // lbl_mediana_agrup
            // 
            this.lbl_mediana_agrup.AutoSize = true;
            this.lbl_mediana_agrup.Location = new System.Drawing.Point(20, 353);
            this.lbl_mediana_agrup.Name = "lbl_mediana_agrup";
            this.lbl_mediana_agrup.Size = new System.Drawing.Size(51, 13);
            this.lbl_mediana_agrup.TabIndex = 5;
            this.lbl_mediana_agrup.Text = "Mediana:";
            // 
            // txt_moda_agrup
            // 
            this.txt_moda_agrup.Location = new System.Drawing.Point(109, 316);
            this.txt_moda_agrup.Name = "txt_moda_agrup";
            this.txt_moda_agrup.Size = new System.Drawing.Size(223, 20);
            this.txt_moda_agrup.TabIndex = 4;
            // 
            // lbl_moda_agrup
            // 
            this.lbl_moda_agrup.AutoSize = true;
            this.lbl_moda_agrup.Location = new System.Drawing.Point(20, 316);
            this.lbl_moda_agrup.Name = "lbl_moda_agrup";
            this.lbl_moda_agrup.Size = new System.Drawing.Size(37, 13);
            this.lbl_moda_agrup.TabIndex = 3;
            this.lbl_moda_agrup.Text = "Moda:";
            // 
            // txt_media_agrup
            // 
            this.txt_media_agrup.Location = new System.Drawing.Point(109, 279);
            this.txt_media_agrup.Name = "txt_media_agrup";
            this.txt_media_agrup.Size = new System.Drawing.Size(223, 20);
            this.txt_media_agrup.TabIndex = 2;
            // 
            // lbl_media_agrup
            // 
            this.lbl_media_agrup.AutoSize = true;
            this.lbl_media_agrup.Location = new System.Drawing.Point(20, 279);
            this.lbl_media_agrup.Name = "lbl_media_agrup";
            this.lbl_media_agrup.Size = new System.Drawing.Size(39, 13);
            this.lbl_media_agrup.TabIndex = 1;
            this.lbl_media_agrup.Text = "Media:";
            // 
            // DGV_agrupados
            // 
            this.DGV_agrupados.AllowUserToAddRows = false;
            this.DGV_agrupados.AllowUserToDeleteRows = false;
            this.DGV_agrupados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_agrupados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_agrupados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Columna_X1_ag,
            this.Columna_X2_ag,
            this.Columna_MC,
            this.Columna_frec_sim_ag,
            this.Columna_frec_acum_ag});
            this.DGV_agrupados.Location = new System.Drawing.Point(23, 19);
            this.DGV_agrupados.Name = "DGV_agrupados";
            this.DGV_agrupados.RowHeadersVisible = false;
            this.DGV_agrupados.Size = new System.Drawing.Size(254, 242);
            this.DGV_agrupados.TabIndex = 0;
            this.DGV_agrupados.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DGV_agrupados_KeyPress);
            // 
            // Columna_X1_ag
            // 
            this.Columna_X1_ag.HeaderText = "X1";
            this.Columna_X1_ag.Name = "Columna_X1_ag";
            this.Columna_X1_ag.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Columna_X2_ag
            // 
            this.Columna_X2_ag.DividerWidth = 10;
            this.Columna_X2_ag.HeaderText = "X2";
            this.Columna_X2_ag.Name = "Columna_X2_ag";
            // 
            // Columna_MC
            // 
            this.Columna_MC.HeaderText = "MC";
            this.Columna_MC.Name = "Columna_MC";
            this.Columna_MC.Visible = false;
            // 
            // Columna_frec_sim_ag
            // 
            this.Columna_frec_sim_ag.HeaderText = "     f";
            this.Columna_frec_sim_ag.Name = "Columna_frec_sim_ag";
            // 
            // Columna_frec_acum_ag
            // 
            this.Columna_frec_acum_ag.HeaderText = "     F";
            this.Columna_frec_acum_ag.Name = "Columna_frec_acum_ag";
            this.Columna_frec_acum_ag.Visible = false;
            // 
            // btn_agrupados
            // 
            this.btn_agrupados.BackColor = System.Drawing.SystemColors.Control;
            this.btn_agrupados.Font = new System.Drawing.Font("Arial", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agrupados.ForeColor = System.Drawing.Color.DarkCyan;
            this.btn_agrupados.Location = new System.Drawing.Point(145, 12);
            this.btn_agrupados.Name = "btn_agrupados";
            this.btn_agrupados.Size = new System.Drawing.Size(86, 42);
            this.btn_agrupados.TabIndex = 3;
            this.btn_agrupados.Text = "Agrupados";
            this.btn_agrupados.UseVisualStyleBackColor = false;
            this.btn_agrupados.Click += new System.EventHandler(this.btn_agrupados_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.BackColor = System.Drawing.Color.Violet;
            this.btn_reset.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reset.ForeColor = System.Drawing.Color.Black;
            this.btn_reset.Location = new System.Drawing.Point(319, 12);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(67, 42);
            this.btn_reset.TabIndex = 15;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = false;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(203, 538);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "Alumno: Leandro Saracco";
            // 
            // Form_inicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 560);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.gb_agrupados);
            this.Controls.Add(this.btn_agrupados);
            this.Controls.Add(this.gb_noagrupados);
            this.Controls.Add(this.btn_noagrupados);
            this.Controls.Add(this.lbl_tipo_datos);
            this.ForeColor = System.Drawing.SystemColors.WindowText;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_inicial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estadística";
            this.Load += new System.EventHandler(this.Form_inicial_Load);
            this.gb_noagrupados.ResumeLayout(false);
            this.gb_noagrupados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_noagrupados)).EndInit();
            this.gb_agrupados.ResumeLayout(false);
            this.gb_agrupados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_agrupados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_tipo_datos;
        private System.Windows.Forms.Button btn_noagrupados;
        private System.Windows.Forms.GroupBox gb_noagrupados;
        private System.Windows.Forms.DataGridView DGV_noagrupados;
        private System.Windows.Forms.TextBox txt_mediana_noagrup;
        private System.Windows.Forms.Label lbl_mediana;
        private System.Windows.Forms.TextBox txt_moda_noagrup;
        private System.Windows.Forms.Label lbl_moda;
        private System.Windows.Forms.TextBox txt_media_noagrup;
        private System.Windows.Forms.Label lbl_media;
        private System.Windows.Forms.TextBox txt_cv_noagrup;
        private System.Windows.Forms.Label lbl_cv;
        private System.Windows.Forms.TextBox txt_ds_noagrup;
        private System.Windows.Forms.Label lbl_desv_st;
        private System.Windows.Forms.DataGridViewTextBoxColumn Columna_X;
        private System.Windows.Forms.DataGridViewTextBoxColumn Columna_frec_simp;
        private System.Windows.Forms.Button btn_calcula_noagr;
        private System.Windows.Forms.Label lbl_n_noagrup;
        private System.Windows.Forms.TextBox txt_variancia_noagrup;
        private System.Windows.Forms.Label lbl_variancia;
        private System.Windows.Forms.GroupBox gb_agrupados;
        private System.Windows.Forms.TextBox txt_variancia_agrup;
        private System.Windows.Forms.Label lbl_variancia_agrup;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_calcular_agrupados;
        private System.Windows.Forms.TextBox txt_cv_agrup;
        private System.Windows.Forms.Label lbl_cv_agrup;
        private System.Windows.Forms.TextBox txt_ds_agrup;
        private System.Windows.Forms.Label lbl_desv_st_agrup;
        private System.Windows.Forms.TextBox txt_mediana_agrup;
        private System.Windows.Forms.Label lbl_mediana_agrup;
        private System.Windows.Forms.TextBox txt_moda_agrup;
        private System.Windows.Forms.Label lbl_moda_agrup;
        private System.Windows.Forms.TextBox txt_media_agrup;
        private System.Windows.Forms.Label lbl_media_agrup;
        private System.Windows.Forms.DataGridView DGV_agrupados;
        private System.Windows.Forms.Button btn_agrupados;
        private System.Windows.Forms.Label lbl_n_agrup;
        private System.Windows.Forms.DataGridViewTextBoxColumn Columna_X1_ag;
        private System.Windows.Forms.DataGridViewTextBoxColumn Columna_X2_ag;
        private System.Windows.Forms.DataGridViewTextBoxColumn Columna_MC;
        private System.Windows.Forms.DataGridViewTextBoxColumn Columna_frec_sim_ag;
        private System.Windows.Forms.DataGridViewTextBoxColumn Columna_frec_acum_ag;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Label label1;
    }
}

