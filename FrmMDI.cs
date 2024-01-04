using Capa_Modelo.Model;
using Capa_Modelo.ViewModel;
using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
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
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void PanelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);

        }
        private void FrmMDI_Load(object sender, EventArgs e)
        {
            /*Programacion para los Privilegios del Usuario */

            this.WindowState = FormWindowState.Maximized;

            // Itera a través de todos los controles en el panel PnlDesplegable.
            foreach (Control control in PnlDesplegable.Controls)
            {
                // Verifica si el control actual es un IconButton.
                if (control is IconButton item)
                {
                    // Obtiene permisos del modelo Permiso_Model para el usuario y contraseña específicos.
                    bool encontrado = new Permiso_Model().GetPermisos(usuario, contraseña, item.Name);

                    // Si no se encontraron permisos, oculta el IconButton.
                    if (!encontrado)
                    {
                        item.Visible = false;
                    }
                    // Si se encontraron permisos, muestra el IconButton.
                    else
                    {
                        item.Visible = true;
                    }
                }
            }
            DespleMenu();

            /*Fecha y Hora del Sistema*/

            segundos = 0;

            Tmr.Interval = 1000; 
            Tmr.Tick += Tmr_Tick;

            Tmr.Start();         
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void ajustforms()
        {
            try
            {
                switch (this.WindowState)
                {
                    case FormWindowState.Normal:
                        if (this.Padding.Top == borderSize)
                        {


                            this.Padding = new Padding(borderSize);
                        }
                        break;

                    case FormWindowState.Maximized:
                        this.Padding = new Padding(8, 8, 8, 0);
                        break;

                }
            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
        private void CerrarPanel<frm>() where frm : Form
        {
            /*Programacion para Cerrar Formulario Emergente*/

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
            /*Programacion para Abrir un Formulario */

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
            // Cuando se hace clic en el botón "Btnmin", se ejecuta este método.

            // Se cambia el estado de la ventana actual (this) a Minimizado.
            this.WindowState = FormWindowState.Minimized;

            // Esto significa que la ventana se minimizará y aparecerá en la barra de tareas.
        }
        private void DespleMenu()
        {
            try
            {
                // Verifica si el ancho del panel desplegable es mayor que 200 (menú contraído).
                if (this.PnlDesplegable.Width > 200)
                {
                    // Ajusta el ancho del panel desplegable y del menú a 90 píxeles.
                    PnlDesplegable.Width = 90;
                    PnlMenu.Width = 90;

                    // Oculta las etiquetas "LblFecha" y "lblHora".
                    LblFecha.Visible = false;
                    lblHora.Visible = false;

                    // Configura cada botón en el panel desplegable.
                    foreach (Button menubut in PnlDesplegable.Controls.OfType<Button>())
                    {
                        menubut.Text = "";
                        menubut.ImageAlign = ContentAlignment.MiddleCenter;
                        menubut.Padding = new Padding(0);
                    }
                }
                else
                {
                    // Menú desplegado: Ajusta el ancho del panel desplegable y del menú a 346 píxeles.
                    PnlDesplegable.Width = 346;
                    PnlMenu.Width = 346;

                    // Muestra las etiquetas "LblFecha" y "lblHora".
                    LblFecha.Visible = true;
                    lblHora.Visible = true;

                    // Configura cada botón en el panel desplegable.
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
                // Captura cualquier excepción que pueda ocurrir durante la ejecución y muestra un mensaje.
                MessageBox.Show(ex.ToString());
            }
        }
        private bool FormularioActivo<frm>() where frm : Form
        {
            // Verificar si el formulario activo pertenece a los controles del panelDesktop
            return panelDesktop.Controls.OfType<frm>().Any(f => f.Visible);
        } 
        private void ICNMenu_Click_1(object sender, EventArgs e)
        {
            DespleMenu();
        }
        private void BtnCitas_Click(object sender, EventArgs e)
        {
            // Cuando se hace clic en el botón "BtnCitas", se ejecuta este método.

            // Abre el panel asociado al formulario FrmCitas.
            AbrirPanel<FrmCitas>();

            // Actualiza el texto de la etiqueta LblMenu con "Modulo de Reservacion de Citas".
            LblMenu.Text = "Modulo de Reservacion de Citas";

            // Realiza alguna acción relacionada con el despliegue del menú (no proporcionada en el código actual).
            DespleMenu();
        }
        private void BtnRes_Ex_Click_1(object sender, EventArgs e)
        {
            // Cuando se hace clic en el botón "BtnRes_Ex", se ejecuta este método.

            // Abre el panel asociado al formulario FrmResultados.
            AbrirPanel<FrmResultados>();

            // Actualiza el texto de la etiqueta LblMenu con "Modulo de Resultados".
            LblMenu.Text = "Modulo de Resultados";

            // Realiza alguna acción relacionada con el despliegue del menú (no proporcionada en el código actual).
            DespleMenu();
        }
        private void IcnCerrarSesion_Click(object sender, EventArgs e)
        {
            // Cuando se hace clic en el elemento "IcnCerrarSesion", se ejecuta este método.

            // Oculta el formulario actual.
            this.Hide();

            // Crea una nueva instancia del formulario de inicio de sesión (FrmLogin).
            FrmLogin login = new FrmLogin();

            // Muestra el formulario de inicio de sesión.
            login.Show();
        }
        private void BtnCompras_Click(object sender, EventArgs e)
        {
            // Cuando se hace clic en el botón "BtnCompras", se ejecuta este método.

            // Abre el panel asociado al formulario FrmCompras.
            AbrirPanel<FrmCompras>();

            // Actualiza el texto de la etiqueta LblMenu con "Modulo de Recepcion de Compras".
            LblMenu.Text = "Modulo de Recepcion de Compras";

            // Realiza alguna acción relacionada con el despliegue del menú (no proporcionada en el código actual).
            DespleMenu();
        }
        private void BtnFac_m_Click(object sender, EventArgs e)
        {
            AbrirPanel<FrmFacturacion>();

            LblMenu.Text = "Modulo de Rececpion de Facturacion";

            DespleMenu();
        }
        private void BtnReg_pas_Click(object sender, EventArgs e)
        {
            AbrirPanel<FrmRegistrodePacientes>();

            LblMenu.Text = "Modulo de Registros de Pacientes";

            DespleMenu();
        }

        private void BtnConf_Click(object sender, EventArgs e)
        {

            AbrirPanel<FrmConfiguracion>();

            LblMenu.Text = "Configuracion";

            DespleMenu();
        }
        private void BtnAd_Usuario_Click(object sender, EventArgs e)
        {

            AbrirPanel<FrmExamen>();

            LblMenu.Text = "Modulo de Gestion de Examenes";

            DespleMenu();
        }
        private void ICNMenu_MouseHover(object sender, EventArgs e)
        {
            // Cuando el mouse se sitúa sobre el elemento ICNMenu, se ejecuta este método.

            // Crea una instancia de ToolTip.
            ToolTip toolTip = new ToolTip();

            // Asocia el mensaje "Boton Desplegable" al elemento ICNMenu.
            toolTip.SetToolTip(ICNMenu, "Boton Desplegable");
        }
        private void BtnHome_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(BtnHome, "Home");
        }
        private void BtnFac_m_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(BtnFac_m, "Modulo de Recepcion de Facturacion");
        }
        private void BtnReg_pas_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(BtnReg_pas, "Modulo de Registros de Pacientes");
        }
        private void BtnCompras_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(BtnCompras, "Modulo de Recepcion de Compras");
        }
        private void BtnRes_Ex_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(BtnRes_Ex, "Modulo de Gestion de Resultados");
        }
        private void BtnGesti_Exa_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(BtnGesti_Exa, "Modulo de Gestion de Examenes");
        }
        private void BtnAd_Usuario_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(BtnAd_Usuario, "Modulo de Administracion de Usuario");
        }
        private void BtnCitas_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(BtnCitas, "Modulo de Reservacion de Citas");
        }
        private void BtnConf_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(BtnConf, "Configuracion");
        }
        private void IcnCerrarSesion_MouseEnter(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(IcnCerrarSesion, "Cerrar Sesion del Usuario");
        }
        private void ICNCalendary_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(ICNCalendary, $"Fecha: {DateTime.Now.ToLongDateString()} ");
        }
        private void ICNTimes_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(ICNTimes, $"Hora: {DateTime.Now.ToString($"HH:mm  ")}");
        }
        private void button1_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(button1, "Cerrar");
        }
        private void Btnmin_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(Btnmin, "Minimizar");
        }
        private void BtnCerrarFormulario_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(BtnCerrarFormulario, "Cerrar Formulario Emergente");
        }
        private void PcLogo_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(PcLogo, "Laboratorio Clinico El Soccorro");
        }
        private void PnlMenu_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(PnlMenu, "Menu Lateral");
        }
        private void IcnUsers_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(IcnUsers, "Usuario: ");
        }
        private void BtnGesti_Exa_Click(object sender, EventArgs e)
        {
            // Cuando se hace clic en el botón "BtnCitas", se ejecuta este método.

            // Abre el panel asociado al formulario FrmCitas.
            AbrirPanel<FrmExamen>();

            // Actualiza el texto de la etiqueta LblMenu con "Modulo de Reservacion de Citas".
            LblMenu.Text = "Modulo de Gestion de Examenes";

            // Realiza alguna acción relacionada con el despliegue del menú (no proporcionada en el código actual).
            DespleMenu();
        }

        private void FrmMDI_Resize(object sender, EventArgs e)
        {
            ajustforms();
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
            else if (FormularioActivo<FrmUsuario>())
            {
                CerrarPanel<FrmUsuario>();
            }
            else if (FormularioActivo<FrmFacturacion>())
            {
                CerrarPanel<FrmFacturacion>();
            }
            else if (FormularioActivo<FrmRegistrodePacientes>())
            {
                CerrarPanel<FrmRegistrodePacientes>();
            }
            else if (FormularioActivo<FrmCompras>())
            {
                CerrarPanel<FrmCompras>();
            }
            else if (FormularioActivo<FrmResultados>())
            {
                CerrarPanel<FrmResultados>();
            }
        }
    }
}
