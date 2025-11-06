using Ejercicio1_models.Models;

namespace Ejercicio2_DesktopApp
{
    public partial class Form1 : Form
    {
        Sistema sistema = new Sistema();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnImportar_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string path = openFileDialog1.FileName;

                FileStream fs = null;
                try
                {
                    fs = new FileStream(path, FileMode.Open, FileAccess.Read);
                    sistema.Descargar(fs);

                    MostrarListaZonas();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    if (fs != null) fs.Close();
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cBoxCamiones.Items.AddRange(sistema.CamionesCargados());
        }

        private void MostrarListaZonas()
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            foreach (Paquete paquete in sistema.listaPaquetes)
            {
                if (paquete.ZonaDestino == "1")
                {
                    listBox1.Items.Add(paquete);
                }
                else if (paquete.ZonaDestino == "2")
                {
                    listBox2.Items.Add(paquete);
                }
                else if (paquete.ZonaDestino == "3")
                {
                    listBox3.Items.Add(paquete);
                }
            }
        }

        int camionElegido = -1;

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            camionElegido = cBoxCamiones.SelectedItem;
        }
    }
}
