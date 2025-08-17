using MediatR;
using PDFManagerV2.UseCases.Recibos.Create;
using PDFManagerV2.UseCases.Recibos.GetByDni;
using PDFManagerV2.UseCases.Recibos.Interfaces;
using System.Windows.Forms;

namespace PDFManagerV2.Desktop
{
    public partial class MainForm : Form
    {
        private readonly IMediator _mediator;
        private readonly IAppSettings _appSettings;
        public MainForm(IMediator mediator, IAppSettings appSettings)
        {
            _mediator = mediator;
            _appSettings = appSettings;
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

        private void dgvRecibos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verifica que hizo click en la columna de la imagen
            if (dgvRecibos.Columns[e.ColumnIndex].Name == "Col_Open" && e.RowIndex >= 0)
            {
                // Obtiene el código de la otra columna
                string codigo = dgvRecibos.Rows[e.RowIndex].Cells["Col_Codigo"].Value?.ToString();

                if (!string.IsNullOrEmpty(codigo))
                {
                    // Construye la ruta del archivo
                    string rutaPdf = Path.Combine(_appSettings.PdfInputPath, codigo + ".pdf");

                    if (File.Exists(rutaPdf))
                    {
                        // Abre el PDF con el programa predeterminado
                        System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo()
                        {
                            FileName = rutaPdf,
                            UseShellExecute = true
                        });
                    }
                    else
                    {
                        MessageBox.Show("No se encontró el archivo: " + rutaPdf);
                    }
                }
            }
        }

        private void btn_GuardarConfig_Click(object sender, EventArgs e)
        {
            _appSettings.UpdateSetting("PdfOutputPath", txtoOrigen.Text);
            _appSettings.UpdateSetting("PdfInputPath", txtDestino.Text);
            MessageBox.Show($"{_appSettings.PdfOutputPath}-{_appSettings.PdfInputPath}", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            txtoOrigen.Text = _appSettings.PdfOutputPath;
            txtDestino.Text = _appSettings.PdfInputPath;
        }

        private void btn_SeleccionarOrigen_Click(object sender, EventArgs e)
        {
            using var dialog = new FolderBrowserDialog
            {
                ShowNewFolderButton = true
            };

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string ruta = dialog.SelectedPath;
                _appSettings.UpdateSetting("PdfInputPath", ruta);
                txtoOrigen.Text = ruta;
            }
        }

        private void btn_SeleccionarDestino_Click(object sender, EventArgs e)
        {
            using var dialog = new FolderBrowserDialog
            {
                ShowNewFolderButton = true
            };

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string ruta = dialog.SelectedPath;
                _appSettings.UpdateSetting("PdfOutputPath", ruta);
                txtDestino.Text = ruta;
            }
        }
    }
}
