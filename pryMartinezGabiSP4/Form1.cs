using System.Globalization;
using System.Drawing.Drawing2D;

namespace pryMartinezGabiSP4
{
    public partial class Form1 : Form
    {
        private readonly float[,] ventas = new float[5, 4];
        private readonly string[] mozos = { "Julio", "Esteban", "Javier", "Gonzalo", "Alberto" };

        public Form1()
        {
            InitializeComponent();
            EstilizarResultados();
        }

        private void EstilizarResultados()
        {
            dgvVentas.BackgroundColor = Color.FromArgb(38, 8, 20);
            dgvVentas.BorderStyle = BorderStyle.None;
            dgvVentas.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvVentas.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvVentas.EnableHeadersVisualStyles = false;
            dgvVentas.GridColor = Color.FromArgb(218, 165, 70);
            dgvVentas.RowHeadersVisible = false;
            dgvVentas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvVentas.MultiSelect = false;
            dgvVentas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvVentas.ColumnHeadersHeight = 42;
            dgvVentas.RowTemplate.Height = 36;

            dgvVentas.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(75, 16, 34);
            dgvVentas.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(245, 220, 160);
            dgvVentas.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dgvVentas.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvVentas.ColumnHeadersDefaultCellStyle.Padding = new Padding(8, 0, 8, 0);

            dgvVentas.DefaultCellStyle.BackColor = Color.FromArgb(250, 244, 235);
            dgvVentas.DefaultCellStyle.ForeColor = Color.FromArgb(55, 27, 32);
            dgvVentas.DefaultCellStyle.SelectionBackColor = Color.FromArgb(105, 25, 42);
            dgvVentas.DefaultCellStyle.SelectionForeColor = Color.White;
            dgvVentas.DefaultCellStyle.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular);
            dgvVentas.DefaultCellStyle.Padding = new Padding(8, 4, 8, 4);

            dgvVentas.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(241, 230, 215);
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            base.OnPaintBackground(e);

            if (ClientRectangle.Width <= 0 || ClientRectangle.Height <= 0)
                return;

            using LinearGradientBrush fondo = new(
                ClientRectangle,
                Color.FromArgb(38, 8, 20),
                Color.FromArgb(105, 25, 42),
                LinearGradientMode.ForwardDiagonal);
            e.Graphics.FillRectangle(fondo, ClientRectangle);

            using SolidBrush brillo = new(Color.FromArgb(28, 218, 165, 70));
            e.Graphics.FillEllipse(brillo, new Rectangle(ClientSize.Width - 270, -100, 360, 360));
            e.Graphics.FillEllipse(brillo, new Rectangle(-190, ClientSize.Height - 190, 300, 300));

            using Pen detalleDorado = new(Color.FromArgb(150, 218, 165, 70), 2F);
            e.Graphics.DrawLine(detalleDorado, 24, 68, ClientSize.Width - 24, 68);
            e.Graphics.DrawLine(detalleDorado, 24, ClientSize.Height - 22, ClientSize.Width - 24, ClientSize.Height - 22);

            Rectangle marco = dgvVentas.Bounds;
            marco.Inflate(4, 4);
            Point[] contorno =
            {
                new(marco.Left + 12, marco.Top),
                new(marco.Right - 12, marco.Top),
                new(marco.Right, marco.Top + 12),
                new(marco.Right, marco.Bottom - 12),
                new(marco.Right - 12, marco.Bottom),
                new(marco.Left + 12, marco.Bottom),
                new(marco.Left, marco.Bottom - 12),
                new(marco.Left, marco.Top + 12)
            };
            using Pen marcoDorado = new(Color.FromArgb(218, 165, 70), 1F);
            marcoDorado.LineJoin = LineJoin.Miter;
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.DrawPolygon(marcoDorado, contorno);
        }

        private void btnValidar_Click(object? sender, EventArgs e)
        {
            for (int fila = 0; fila < 5; fila++)
            {
                for (int columna = 0; columna < 4; columna++)
                {
                    int indiceColumnaGrilla = columna + 1;
                    object? valor = dgvVentas.Rows[fila].Cells[indiceColumnaGrilla].Value;
                    if (!TryParseImporte(valor?.ToString(), out float importe))
                    {
                        btnMozoDelDia.Enabled = false;
                        btnTotales.Enabled = false;
                        MessageBox.Show(
                            $"El importe de {mozos[fila]} en la categoría «{dgvVentas.Columns[indiceColumnaGrilla].HeaderText}» no es válido.",
                            "Datos inválidos",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                        dgvVentas.CurrentCell = dgvVentas.Rows[fila].Cells[indiceColumnaGrilla];
                        dgvVentas.Focus();
                        return;
                    }

                    ventas[fila, columna] = importe;
                }
            }

            btnMozoDelDia.Enabled = true;
            btnTotales.Enabled = true;
            MessageBox.Show("Todos los datos fueron validados correctamente.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnMozoDelDia_Click(object? sender, EventArgs e)
        {
            int indiceMozo = 0;
            float mayorTotal = ObtenerTotalMozo(0);

            for (int fila = 1; fila < mozos.Length; fila++)
            {
                float totalMozo = ObtenerTotalMozo(fila);
                if (totalMozo > mayorTotal)
                {
                    mayorTotal = totalMozo;
                    indiceMozo = fila;
                }
            }

            lblMozoDelDia.Text = $"Nombre: {mozos[indiceMozo]}";
            lblImporteMozo.Text = $"Importe: {mayorTotal:N2}";
        }

        private void btnTotales_Click(object? sender, EventArgs e)
        {
            float totalGeneral = 0;
            float[] totalesPorCategoria = new float[4];

            for (int fila = 0; fila < 5; fila++)
            {
                for (int columna = 0; columna < 4; columna++)
                {
                    totalGeneral += ventas[fila, columna];
                    totalesPorCategoria[columna] += ventas[fila, columna];
                }
            }

            lblTotalGeneral.Text = $"Total general: {totalGeneral:N2}";
            lblTotalComidas.Text = $"Comidas: {totalesPorCategoria[0]:N2}";
            lblTotalBebidasSinAlcohol.Text = $"Bebidas sin alcohol: {totalesPorCategoria[1]:N2}";
            lblTotalBebidasConAlcohol.Text = $"Bebidas con alcohol: {totalesPorCategoria[2]:N2}";
            lblTotalPostres.Text = $"Postres: {totalesPorCategoria[3]:N2}";
        }

        private void btnCerrar_Click(object? sender, EventArgs e)
        {
            Close();
        }

        private void dgvVentas_CellValueChanged(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                btnMozoDelDia.Enabled = false;
                btnTotales.Enabled = false;
            }
        }

        private float ObtenerTotalMozo(int fila)
        {
            float total = 0;
            for (int columna = 0; columna < 4; columna++)
            {
                total += ventas[fila, columna];
            }

            return total;
        }

        private static bool TryParseImporte(string? texto, out float importe)
        {
            return float.TryParse(texto, NumberStyles.Float, CultureInfo.CurrentCulture, out importe)
                || float.TryParse(texto, NumberStyles.Float, CultureInfo.InvariantCulture, out importe);
        }
    }
}
