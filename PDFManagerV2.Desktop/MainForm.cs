using PDFManagerV2.Core;

namespace PDFManagerV2.Desktop
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var dni = txtDni.Text;
            var nombres = txtNombres.Text;
            var apellidos = txtApellidos.Text;
            var monto = txtMonto.Text;
            var concepto = txtConcepto.Text;
            var client = new Cliente
            {
                Dni = dni,
                Nombres = nombres,
                Apellidos = apellidos
            };
            var Recibo = new Recibo
            {
                Monto = monto,
                Concepto = concepto,
                FechaEmision = DateTime.Now.ToString("dd/MM/yyyy"),
                Cliente = client
            };
            MessageBox.Show($"Recibo guardado:\n\n" +
                $"Código: {Recibo.Codigo}\n" +
                $"Monto: {Recibo.Monto}\n" +
                $"Concepto: {Recibo.Concepto}\n" +
                $"Fecha de Emisión: {Recibo.FechaEmision}\n" +
                $"Cliente: {Recibo.Cliente.Nombres} {Recibo.Cliente.Apellidos} (DNI: {Recibo.Cliente.Dni})",
                "Información del Recibo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
