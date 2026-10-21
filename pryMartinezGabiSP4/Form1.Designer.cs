namespace pryMartinezGabiSP4
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private Label lblIcono;
        private Label lblTitulo;
        private Label lblSubtitulo;
        private Label lblSeccionCarga;
        private DataGridView dgvVentas;
        private Button btnValidar;
        private Button btnMozoDelDia;
        private Button btnTotales;
        private Button btnCerrar;
        private Label lblMozoDelDia;
        private Label lblImporteMozo;
        private Label lblTotalGeneral;
        private Label lblTotalComidas;
        private Label lblTotalBebidasSinAlcohol;
        private Label lblTotalBebidasConAlcohol;
        private Label lblTotalPostres;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lblIcono = new Label();
            lblTitulo = new Label();
            lblSubtitulo = new Label();
            lblSeccionCarga = new Label();
            dgvVentas = new DataGridView();
            btnValidar = new Button();
            btnMozoDelDia = new Button();
            btnTotales = new Button();
            btnCerrar = new Button();
            lblMozoDelDia = new Label();
            lblImporteMozo = new Label();
            lblTotalGeneral = new Label();
            lblTotalComidas = new Label();
            lblTotalBebidasSinAlcohol = new Label();
            lblTotalBebidasConAlcohol = new Label();
            lblTotalPostres = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvVentas).BeginInit();
            SuspendLayout();
            // 
            // lblIcono
            // 
            lblIcono.BackColor = Color.FromArgb(166, 35, 58);
            lblIcono.BorderStyle = BorderStyle.FixedSingle;
            lblIcono.Font = new Font("Georgia", 14F, FontStyle.Bold);
            lblIcono.ForeColor = Color.FromArgb(246, 208, 112);
            lblIcono.Location = new Point(24, 13);
            lblIcono.Size = new Size(42, 42);
            lblIcono.Text = "LM";
            lblIcono.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Georgia", 20F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(246, 208, 112);
            lblTitulo.Location = new Point(82, 10);
            lblTitulo.Text = "LA MILANGA";
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.AutoSize = true;
            lblSubtitulo.Font = new Font("Georgia", 8F, FontStyle.Italic);
            lblSubtitulo.ForeColor = Color.FromArgb(235, 220, 190);
            lblSubtitulo.Location = new Point(84, 42);
            lblSubtitulo.Text = "CARGA DE VENTAS DIARIAS  ·  BAR & LOUNGE";
            // 
            // lblSeccionCarga
            // 
            lblSeccionCarga.AutoSize = true;
            lblSeccionCarga.BackColor = Color.Transparent;
            lblSeccionCarga.Font = new Font("Georgia", 10F, FontStyle.Italic);
            lblSeccionCarga.ForeColor = Color.FromArgb(246, 208, 112);
            lblSeccionCarga.Location = new Point(24, 78);
            lblSeccionCarga.Padding = new Padding(0, 2, 0, 2);
            lblSeccionCarga.Text = "REGISTRO DE VENTAS";
            // 
            // dgvVentas
            // 
            dgvVentas.AllowUserToAddRows = false;
            dgvVentas.AllowUserToDeleteRows = false;
            dgvVentas.AllowUserToResizeRows = false;
            dgvVentas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvVentas.BackgroundColor = Color.FromArgb(247, 239, 222);
            dgvVentas.BorderStyle = BorderStyle.FixedSingle;
            dgvVentas.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dgvVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVentas.ColumnHeadersHeight = 34;
            dgvVentas.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(112, 20, 38);
            dgvVentas.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(246, 208, 112);
            dgvVentas.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dgvVentas.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvVentas.EnableHeadersVisualStyles = false;
            dgvVentas.GridColor = Color.FromArgb(213, 186, 130);
            dgvVentas.Location = new Point(24, 108);
            dgvVentas.MultiSelect = false;
            dgvVentas.RowsDefaultCellStyle.BackColor = Color.FromArgb(250, 245, 233);
            dgvVentas.RowsDefaultCellStyle.ForeColor = Color.FromArgb(66, 35, 32);
            dgvVentas.RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(232, 208, 154);
            dgvVentas.RowsDefaultCellStyle.SelectionForeColor = Color.FromArgb(66, 35, 32);
            dgvVentas.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvVentas.RowsDefaultCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
            dgvVentas.RowsDefaultCellStyle.Padding = new Padding(6, 3, 6, 3);
            dgvVentas.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(241, 229, 205);
            dgvVentas.RowTemplate.Height = 30;
            dgvVentas.RowHeadersVisible = false;
            dgvVentas.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dgvVentas.Size = new Size(850, 190);
            dgvVentas.TabIndex = 0;
            dgvVentas.CellValueChanged += dgvVentas_CellValueChanged;
            dgvVentas.Columns.Add("Mozo", "Mozo");
            dgvVentas.Columns.Add("Comidas", "Comidas");
            dgvVentas.Columns.Add("BebidasSinAlcohol", "Bebidas sin alcohol");
            dgvVentas.Columns.Add("BebidasConAlcohol", "Bebidas con alcohol");
            dgvVentas.Columns.Add("Postres", "Postres");
            dgvVentas.Columns["Mozo"].ReadOnly = true;
            dgvVentas.Columns["Mozo"].FillWeight = 65;
            dgvVentas.Columns["Mozo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvVentas.Columns["Mozo"].DefaultCellStyle.BackColor = Color.FromArgb(112, 20, 38);
            dgvVentas.Columns["Mozo"].DefaultCellStyle.ForeColor = Color.FromArgb(246, 208, 112);
            dgvVentas.Columns["Mozo"].DefaultCellStyle.Font = new Font("Georgia", 9F, FontStyle.Bold);
            dgvVentas.Rows.Add("Julio");
            dgvVentas.Rows.Add("Esteban");
            dgvVentas.Rows.Add("Javier");
            dgvVentas.Rows.Add("Gonzalo");
            dgvVentas.Rows.Add("Alberto");
            dgvVentas.RowHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            // 
            // botones
            // 
            btnValidar.Location = new Point(24, 310);
            btnValidar.Size = new Size(150, 35);
            btnValidar.Text = "Validar Datos";
            btnValidar.BackColor = Color.FromArgb(166, 35, 58);
            btnValidar.FlatAppearance.BorderSize = 0;
            btnValidar.FlatStyle = FlatStyle.Flat;
            btnValidar.ForeColor = Color.White;
            btnValidar.Click += btnValidar_Click;
            btnMozoDelDia.Enabled = false;
            btnMozoDelDia.Location = new Point(24, 360);
            btnMozoDelDia.Size = new Size(150, 35);
            btnMozoDelDia.Text = "Mozo del día";
            btnMozoDelDia.BackColor = Color.FromArgb(166, 35, 58);
            btnMozoDelDia.FlatAppearance.BorderSize = 0;
            btnMozoDelDia.FlatStyle = FlatStyle.Flat;
            btnMozoDelDia.ForeColor = Color.White;
            btnMozoDelDia.Click += btnMozoDelDia_Click;
            btnTotales.Enabled = false;
            btnTotales.Location = new Point(24, 410);
            btnTotales.Size = new Size(150, 35);
            btnTotales.Text = "Totales";
            btnTotales.BackColor = Color.FromArgb(166, 35, 58);
            btnTotales.FlatAppearance.BorderSize = 0;
            btnTotales.FlatStyle = FlatStyle.Flat;
            btnTotales.ForeColor = Color.White;
            btnTotales.Click += btnTotales_Click;
            btnCerrar.Location = new Point(24, 490);
            btnCerrar.Size = new Size(150, 35);
            btnCerrar.Text = "Cerrar";
            btnCerrar.BackColor = Color.FromArgb(111, 82, 35);
            btnCerrar.FlatAppearance.BorderSize = 0;
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.ForeColor = Color.White;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // resultados
            // 
            lblMozoDelDia.AutoSize = true;
            lblMozoDelDia.ForeColor = Color.WhiteSmoke;
            lblMozoDelDia.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblMozoDelDia.Location = new Point(205, 370);
            lblMozoDelDia.Text = "Nombre: -";
            lblImporteMozo.AutoSize = true;
            lblImporteMozo.ForeColor = Color.FromArgb(246, 208, 112);
            lblImporteMozo.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblImporteMozo.Location = new Point(430, 370);
            lblImporteMozo.Text = "Importe: -";
            lblTotalGeneral.AutoSize = true;
            lblTotalGeneral.ForeColor = Color.FromArgb(246, 208, 112);
            lblTotalGeneral.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTotalGeneral.Location = new Point(205, 420);
            lblTotalGeneral.Text = "Total general: -";
            lblTotalComidas.AutoSize = true;
            lblTotalComidas.ForeColor = Color.WhiteSmoke;
            lblTotalComidas.Location = new Point(205, 450);
            lblTotalComidas.Text = "Comidas: -";
            lblTotalBebidasSinAlcohol.AutoSize = true;
            lblTotalBebidasSinAlcohol.ForeColor = Color.WhiteSmoke;
            lblTotalBebidasSinAlcohol.Location = new Point(380, 450);
            lblTotalBebidasSinAlcohol.Text = "Bebidas sin alcohol: -";
            lblTotalBebidasConAlcohol.AutoSize = true;
            lblTotalBebidasConAlcohol.ForeColor = Color.WhiteSmoke;
            lblTotalBebidasConAlcohol.Location = new Point(620, 450);
            lblTotalBebidasConAlcohol.Text = "Bebidas con alcohol: -";
            lblTotalPostres.AutoSize = true;
            lblTotalPostres.ForeColor = Color.WhiteSmoke;
            lblTotalPostres.Location = new Point(205, 480);
            lblTotalPostres.Text = "Postres: -";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(38, 8, 20);
            ClientSize = new Size(900, 555);
            Controls.Add(lblIcono);
            Controls.Add(lblTitulo);
            Controls.Add(lblSubtitulo);
            Controls.Add(lblSeccionCarga);
            Controls.Add(dgvVentas);
            Controls.Add(btnValidar);
            Controls.Add(btnMozoDelDia);
            Controls.Add(btnTotales);
            Controls.Add(btnCerrar);
            Controls.Add(lblMozoDelDia);
            Controls.Add(lblImporteMozo);
            Controls.Add(lblTotalGeneral);
            Controls.Add(lblTotalComidas);
            Controls.Add(lblTotalBebidasSinAlcohol);
            Controls.Add(lblTotalBebidasConAlcohol);
            Controls.Add(lblTotalPostres);
            Name = "Form1";
            Text = "Ventas del negocio gastronómico";
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            ((System.ComponentModel.ISupportInitialize)dgvVentas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}
