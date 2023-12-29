using Capa_Modelo.Model;
using Capa_Modelo.ViewModel;
using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_de_Graduacion
{
    public partial class FrmMDI : Form
    {
        private int segundos;
        private int borderSize = 2;
        Usuario_Model Usuario_ = new Usuario_Model();
        string usuario, contraseña;
        public FrmMDI(string Usuario,string Contraseña)
        {
            InitializeComponent();

            this.Padding = new Padding(borderSize);
            this.BackColor = Color.FromArgb(98, 102, 244);

            usuario = Usuario;

            contraseña = Contraseña;
        }
        private void FrmMDI_Load(object sender, EventArgs e)
        {
            foreach (Control control in PnlDesplegable.Controls)
            {
                if (control is IconButton item)
                {
                    bool encontrado = new Permiso_Model().GetPermisos(usuario, contraseña, item.Name);

                    if (!encontrado)
                    {
                        item.Visible = false;
                    }
                    else
                    {
                        item.Visible = true;
                    }
                }
            }

            DespleMenu();

            segundos = 0;

            Tmr.Interval = 1000; // Intervalo en milisegundos (1 segundo)
            Tmr.Tick += Tmr_Tick;

            Tmr.Start();
            

        }
        private void ICNMenu_Click(object sender, EventArgs e)
        {
            DespleMenu();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void CerrarPanel<frm>() where frm : Form
        {
            Form formu = panelDesktop.Controls.OfType<frm>().FirstOrDefault();

            // Si el formulario existe, ciérralo
            if (formu != null)
            {
                formu.Close();

                panelDesktop.BackColor= Color.White;
            }
        }
        private void AbrirPanel<frm>() where frm : Form, new()
        {
            Form formu;
            formu = panelDesktop.Controls.OfType<frm>().FirstOrDefault();//Busca la coleccion de los formularios
                                                                         //si el formulario  no existe
            if (formu == null)
            {
                formu = new frm();
                formu.TopLevel = false;
                formu.Dock = DockStyle.Fill;
                panelDesktop.Controls.Add(formu);
                panelDesktop.Tag = formu;
                formu.Show();
                formu.BringToFront();

            }
            else
            {
                formu.BringToFront();
            }
        }
        private void Tmr_Tick(object sender, EventArgs e)
        {
            segundos = segundos + 1;

            // Calcular minutos y segundos
            int minutos = segundos / 60;
            int segundosRestantes = segundos % 60;


            // Mostrar en el Label la hora con formato HH:mm:ss
            lblHora.Text = DateTime.Now.AddMinutes(minutos).AddSeconds(segundosRestantes).ToString("HH:mm:ss");

            // Mostrar la fecha actual
            LblFecha.Text = DateTime.Now.ToShortDateString();
        }
        private void Btnmin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void AjustarBotonesAlMaximizar()
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                LblFecha.Font = new Font(LblFecha.Font.FontFamily, 15f);
                lblHora.Font = new Font(lblHora.Font.FontFamily, 15f);

                    foreach (Button menubut in PnlDesplegable.Controls.OfType<Button>())
                    {
                        menubut.Size = new Size(302,60);
                        menubut.Font = new Font(menubut.Font.FontFamily, 13f); // Establece el tamaño de la fuente deseado
                        menubut.Padding = new Padding(0);
                    }
            }
        }
        private void DespleMenu()
        {
            try
            {
                if (this.PnlDesplegable.Width > 200)//menu Contraido
                {
                    PnlDesplegable.Width = 100;
                    PcLaboratorio.Width = 50;
                    LblFecha.Visible = false;
                    lblHora.Visible = false;
                    foreach (Button menubut in PnlDesplegable.Controls.OfType<Button>())
                    {
                        menubut.Text = "";
                        menubut.ImageAlign = ContentAlignment.MiddleCenter;
                        menubut.Padding = new Padding(0);
                    }                 
                }
                else 
                {
                    PnlDesplegable.Width = 341;//Menu Desplasado
                    PcLaboratorio.Width = 84;
                    LblFecha.Visible = true;
                    lblHora.Visible = true;
                    foreach (Button menubut in PnlDesplegable.Controls.OfType<Button>())
                    {
                        menubut.Text = "" + menubut.Tag.ToString();
                        menubut.ImageAlign = ContentAlignment.MiddleLeft;
                        menubut.Padding = new Padding(10, 0, 0, 0);
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
        private void BtnCerrarFormulario_Click(object sender, EventArgs e)
        {
            if (FormularioActivo<FrmFacturacion>())
            {
                CerrarPanel<FrmFacturacion>();
            }
            else if (FormularioActivo<FrmCitas>())
            {
                CerrarPanel<FrmCitas>();
            }
            else if (FormularioActivo<FrmExamen>())
            {
                CerrarPanel<FrmExamen>();
            }
            else if(FormularioActivo<FrmUsuario>())
            {
                CerrarPanel<FrmUsuario>();
            }
            else if(FormularioActivo<FrmFacturacion>())
            {
                CerrarPanel<FrmFacturacion>();
            }
            else if(FormularioActivo<FrmRegistrodePacientes>())
            {
                CerrarPanel<FrmRegistrodePacientes>();
            }
            else if(FormularioActivo<FrmCompras>())
            {
                CerrarPanel<FrmCompras>();
            }
        }
        private bool FormularioActivo<frm>() where frm : Form
        {
            // Verificar si el formulario activo pertenece a los controles del panelDesktop
            return panelDesktop.Controls.OfType<frm>().Any(f => f.Visible);
        } 
        private void Btncompra_Click(object sender, EventArgs e)
        {
            AbrirPanel<FrmCompras>();

            LblMenu.Text = "Modulo de Recepcion de Compras";

            DespleMenu();
        }
        private void BtnConf_Click(object sender, EventArgs e)
        {

            AbrirPanel<FrmConfiguracion>();

            LblMenu.Text = "Configuracion";

            DespleMenu();
        }
        private void BtnReg_pas_Click(object sender, EventArgs e)
        {
            AbrirPanel<FrmRegistrodePacientes>();

            LblMenu.Text = "Modulo de Registros de Pacientes";

            DespleMenu();
        }

        private void BtnAd_Usuario_Click_1(object sender, EventArgs e)
        {
            AbrirPanel<FrmUsuario>();

            LblMenu.Text = "Modulo de Administracion de Usuario";

            DespleMenu();
        }
        private void BtnFac_m_Click(object sender, EventArgs e)
        {
            AbrirPanel<FrmFacturacion>();

            LblMenu.Text = "Modulo de Rececpion de Facturacion";

            DespleMenu();
        }
        private void BtnGesti_Exa_Click(object sender, EventArgs e)
        {
            AbrirPanel<FrmExamen>();

            LblMenu.Text = "Modulo de Gestion de Examenes";

            DespleMenu();
        }
        private void IcnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Hide();

            FrmLogin login = new FrmLogin();

            login.Show();
        }

        private void BtnHome_Click(object sender, EventArgs e)
        {

        }
        private void BtnRes_Ex_Click(object sender, EventArgs e)
        {
            AbrirPanel<FrmResultados>();

            LblMenu.Text = "Modulo de Resultados";

            DespleMenu();
        }

        private void PnlDesplegable_Paint(object sender, PaintEventArgs e)
        {

        }
        private void FrmMDI_Resize(object sender, EventArgs e)
        {
            AjustarBotonesAlMaximizar();
        }
        private void BtnCitas_Click(object sender, EventArgs e)
        {
            AbrirPanel<FrmCitas>();

            LblMenu.Text = "Modulo de Reservacion de Citas";

            DespleMenu();
        }
    }
}
