using MediatR;
using PDFManagerV2.UseCases.Recibos.Create;
using PDFManagerV2.UseCases.Recibos.GetByDni;

namespace PDFManagerV2.Desktop
{
    public partial class MainForm : Form
    {
        private readonly IMediator _mediator;
        public MainForm(IMediator mediator)
        {
            _mediator = mediator;
            InitializeComponent();
        }
        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            var dni = txtDni.Text;
            var nombres = txtNombres.Text;
            var apellidos = txtApellidos.Text;
            var monto = txtMonto.Value;
            var concepto = txtConcepto.Text;
            var command = new CreateReciboCommand(string.IsNullOrEmpty(dni) ? "00000000" : dni,
                                                  string.IsNullOrEmpty(nombres) ? "N/A" : nombres,
                                                  string.IsNullOrEmpty(apellidos) ? "N/A" : apellidos,
                                                  monto,
                                                  string.IsNullOrEmpty(concepto) ? "Sin concepto" : concepto);
            var result = await _mediator.Send(command);
            if (result.IsFailure)
            {
                MessageBox.Show($"Error al generar el documento: {result.Errors}");
                return;
            }
            var dialogResult = MessageBox.Show("Recibo guardado exitosamente, ¿desea abrir el documento?",
                                                "Abrir Documento",
                                                MessageBoxButtons.YesNo,
                                                MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                // Abrir documento con el visor de PDF predeterminado del sistema
                try
                {
                    System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                    {
                        FileName = result.Value,
                        UseShellExecute = true
                    });
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al abrir el documento: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private async void btnListar_Click(object sender, EventArgs e)
        {
            var result = await _mediator.Send(new GetByDniQuery(txtDniBusqueda.Text));
            if (result.IsSuccess)
            {
                dgvRecibos.Rows.Clear();

                foreach (var recibo in result.Value)
                {
                    dgvRecibos.Rows.Add(
                        $"{recibo.Cliente.Nombres} {recibo.Cliente.Apellidos}",
                        $"{recibo.Cliente.Dni}-{recibo.FechaEmision.ToString("ddMMyyyy")}-{recibo.FechaEmision.ToString("HHmmss")}",
                        recibo.FechaEmision.ToString("dd-MM-yyyy")
                    );
                }
            }
            else
            {
                MessageBox.Show(result.Errors.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
