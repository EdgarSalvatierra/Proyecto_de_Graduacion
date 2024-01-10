using Capa_Modelo.ViewModel;
using FontAwesome.Sharp;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_de_Graduacion
{
    public partial class Form1 : MaterialForm
    {
        Facturacion_Model Facturacion = new Facturacion_Model();

        Paciente_Model paciente = new Paciente_Model();

        ErrorProvider error = new ErrorProvider();

        Compras_Model compras = new Compras_Model();

        Examen_Model Examen = new Examen_Model();

        Citas_Model Citas = new Citas_Model();

        Usuario_Model Usuario_ = new Usuario_Model();

        Configuracion_Model Configuracion = new Configuracion_Model();

        private int segundos;
        private int borderSize = 2;
        string usuario, contraseña;

        public Form1(string Usuario, string Contraseña)
        {
            InitializeComponent();

            // Crea una instancia de MaterialSkinManager
            SkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            SkinManager.ColorScheme = new ColorScheme(Primary.DeepPurple700, Primary.DeepPurple600, Primary.DeepPurple500, Accent.DeepPurple400, TextShade.WHITE);

            usuario = Usuario;

            contraseña = Contraseña;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (Control control in MaterialTabcontrollist.Controls)
            {
                // Verifica si el control actual es un IconButton.
                if (control is TabPage item)
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

            System.Drawing.Icon iconoProyecto = System.Drawing.Icon.ExtractAssociatedIcon(Application.ExecutablePath);

            // Convertir el ícono a imagen
            System.Drawing.Image imagenIcono = iconoProyecto.ToBitmap();

            // Asignar la imagen al control PictureBox (suponiendo que Pclogo es un control PictureBox)
            Pclogo.Image = imagenIcono;

            DtgFactura.DataSource = Facturacion.LeerFacturas();

            DtgPaciente.DataSource = paciente.LeerPacientes();

            DtgCompras.DataSource = compras.LeerPedidos();

            DtgExamen.DataSource = Examen.LeerExamen();

            DtgCitas.DataSource = Citas.LeerCitas();

            DtgUsuarios.DataSource = Usuario_.LeerUsuario();

            LblEntidad2.Text = Configuracion.GetNombre();

            Lbladministrador2.Text = Configuracion.GetAdministrador();

            LblTelefono2.Text = Configuracion.GetTelefono().ToString();

            Lblubicacion2.Text = Configuracion.GetUbicacion();

            Lblciudad2.Text = Configuracion.GetCiudad();
        }
        private void Btnrefrescarcompra_Click(object sender, EventArgs e)
        {
            DtgCompras.DataSource = compras.LeerPedidos();
        } 
        private void BtnBuscarpaciente_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(TxtBuscarPaciente.Text, out _))
            {
                string Paciente = TxtBuscarPaciente.Text;

                DtgPaciente.DataSource = paciente.LeerPacientesporId(Paciente);
            }
            else
            {
                MessageBox.Show("No existe tal dato", "SQL Server", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void Btnrefrescarpaciente_Click(object sender, EventArgs e)
        {
            DtgPaciente.DataSource = paciente.LeerPacientes();
        }
        private void BtnBuscarCompra_Click(object sender, EventArgs e)
        {
            string Producto = TxtBuscarCompra.Text.ToString();

            string Proveedor = TxtBuscarCompra.Text.ToString();

            DtgCompras.DataSource = compras.LeerPedidosporNombre(Proveedor, Producto);
        }
        private void TxtBuscarCompra_Enter(object sender, EventArgs e)
        {
            if (TxtBuscarCompra.Text == "Buscar Compra")
            {
                TxtBuscarCompra.Text = "";

                TxtBuscarCompra.ForeColor = Color.Black;
            }
        }
        private void ICNBuscador_Click_1(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(TxtBuscarFactura.Text))
            {
                if (int.TryParse(TxtBuscarFactura.Text, out _))
                {
                    int CodigoFactura = Convert.ToInt32(TxtBuscarFactura.Text);

                    DtgFactura.DataSource = Facturacion.BuscarFacturas(CodigoFactura);
                }
                else
                {
                    MessageBox.Show("Buscar con el numero de factura", "SQL Server", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                error.SetError(TxtBuscarFactura, "No hay registro");
                MessageBox.Show("el registro no existe", "SQL Server", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void BtnRefrescar_Click(object sender, EventArgs e)
        {
            DtgFactura.DataSource = Facturacion.LeerFacturas();
        }
        private void BtnBuscareExamen_Click(object sender, EventArgs e)
        {
            string examen = TxtBuscarExamen.Text;

            DtgExamen.DataSource = Examen.BuscarporExamen(examen);
        }
        private void Btnrefrescarexamen_Click(object sender, EventArgs e)
        {
            DtgExamen.DataSource = Examen.LeerExamen();
        }
        private void BtnBuscarCitas_Click(object sender, EventArgs e)
        {
            if (long.TryParse(txtBusquedaCita.Text, out _))
            {
                long Telefono = Convert.ToInt64(txtBusquedaCita.Text);

                string Pacientes = "";

                DtgCitas.DataSource = Citas.Search(Pacientes, Telefono);
            }
            else
            {
                long Telefono = 0;

                string Pacientes = txtBusquedaCita.Text;

                DtgCitas.DataSource = Citas.Search(Pacientes, Telefono);
            }
        }
        private void Btnrefrescarcitas_Click(object sender, EventArgs e)
        {
            DtgCitas.DataSource = Citas.LeerCitas();
        }
        private void txtBusquedaCita_Enter(object sender, EventArgs e)
        {
            if (txtBusquedaCita.Text == "Buscar Citas")
            {
                txtBusquedaCita.Text = "";

                txtBusquedaCita.ForeColor = Color.Black;
            }
        }
        private void ICNCompra_Click(object sender, EventArgs e)
        {
            FrmNuevaCompra compras = new FrmNuevaCompra();

            compras.Show();
        }
        private void BtnDardebajaCompra_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Quieres realizar esta acción?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (resultado == DialogResult.Yes)
            {
                if (DtgCompras.SelectedRows.Count > 0)
                {
                    DataGridViewRow data = DtgCompras.SelectedRows[0];

                    int Codigo = Convert.ToInt32(data.Cells[0].Value);

                    compras.DarDebaja(Codigo);

                    MessageBox.Show("El Registro fue dado de baja", "SQL Server", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("La Tabla esta vacia, no puede dar de baja", "SQL Server", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void BtnEditarCompra_Click(object sender, EventArgs e)
        {

        }
        private void BtnBuscarUsuario_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(TxtBuscarFactura.Text, out _))
            {
                string Nombre = TxtBuscarFactura.Text;

                string Roles = TxtBuscarFactura.Text;

                DtgUsuarios.DataSource = Usuario_.LeerUsuarioporId(Nombre, Roles);
            }
        }
        private void BtnRefrescarUsuario_Click(object sender, EventArgs e)
        {
            DtgUsuarios.DataSource = Usuario_.LeerUsuario();
        }
        private void BtnNuevoUsuario_Click(object sender, EventArgs e)
        {
            FrmNuevoUsuario frmNuevo = new FrmNuevoUsuario();

            frmNuevo.Show();
        }
        private void BtnDardebajaUsuario_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Quieres realizar esta acción?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (resultado == DialogResult.Yes)
            {
                if (DtgUsuarios.SelectedRows.Count > 0)
                {
                    DataGridViewRow data = DtgUsuarios.SelectedRows[0];

                    string user = data.Cells[4].Value.ToString();

                    Usuario_.DardebajaUsuario(user);

                    MessageBox.Show("El Registro fue dado de baja", "SQL Server", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    DtgUsuarios.DataSource = Usuario_.LeerUsuario();
                }
                else
                {
                    MessageBox.Show("La Tabla esta vacia, no puede dar de baja", "SQL Server", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void BtnEditarUsuario_Click(object sender, EventArgs e)
        {
            if (DtgUsuarios.SelectedRows.Count > 0)
            {
                DataGridViewRow data = DtgUsuarios.SelectedRows[0];

                int Codigo = Convert.ToInt32(data.Cells[0].Value);

                string Nombre = data.Cells[1].Value.ToString();

                int Edad = Convert.ToInt32(data.Cells[2].Value);

                long Telefono = Convert.ToInt64(data.Cells[3].Value);

                string user = data.Cells[4].Value.ToString();

                string contraseña = data.Cells[5].Value.ToString();

                string Roles = data.Cells[6].Value.ToString();

                FrmEditarUsuario editarUsuario = new FrmEditarUsuario(Codigo, Nombre, Edad, Telefono, user, contraseña, Roles);

                editarUsuario.Show();

                DtgUsuarios.DataSource = Usuario_.LeerUsuario();
            }
            else
            {
                MessageBox.Show("La Tabla esta vacia, no puede dar de baja", "SQL Server", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxtBuscarUsuario_Enter(object sender, EventArgs e)
        {
            if (TxtBuscarUsuario.Text == "Buscar Usuario")
            {
                TxtBuscarUsuario.Text = "";
                TxtBuscarUsuario.ForeColor = Color.Black;
            }
        }
        private void Btncambiarinformacion_Click(object sender, EventArgs e)
        {
            FrmNuevaConfiguracion nuevaConfiguracion = new FrmNuevaConfiguracion(LblEntidad2.Text, Lbladministrador2.Text, LblTelefono2.Text, Lblubicacion2.Text, Lblciudad2.Text);

            nuevaConfiguracion.Show();
        }
        public void cambiaricono(string rutaimagen)
        {
            Bitmap bitmap = new Bitmap(rutaimagen);
            System.Drawing.Icon nuevoIcono = System.Drawing.Icon.FromHandle(bitmap.GetHicon());

            // Convertir el nuevo ícono a un arreglo de bytes

            foreach (Form formulario in Application.OpenForms)
            {
                formulario.Icon = nuevoIcono;

                // Opcional: Forzar una actualización visual del formulario
                formulario.Refresh();

                nuevoIcono.Dispose();
            }
            // Convertir el nuevo ícono a una imagen y asignarlo a un control PictureBox (si es necesario)
            System.Drawing.Image imagenIcono = nuevoIcono.ToBitmap();
            Pclogo.Image = imagenIcono;
        }
        private void BtnCambiarlogo_Click(object sender, EventArgs e)
        {
            cambiaricono(TxtArchivodelIcono.Text);
        }
        private void BtnSeleccionar_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Configurar el diálogo para mostrar solo archivos de imagen
            openFileDialog.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.gif;*.bmp|Todos los archivos|*.*";
            openFileDialog.Title = "Seleccionar una imagen";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Obtener la ruta del archivo seleccionado
                    string rutaImagen = openFileDialog.FileName;

                    TxtArchivodelIcono.Text = rutaImagen;

                    TxtArchivodelIcono.Enabled = false;

                    // Cargar la imagen en el PictureBox
                    Pclogo.Image = Image.FromFile(rutaImagen);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void BtnImprimir_Click(object sender, EventArgs e)
        {
            if (DtgFactura.SelectedRows.Count > 0)
            {
                DataGridViewRow data = DtgFactura.SelectedRows[0];

                int numeroruc = Convert.ToInt32(data.Cells[0].Value);

                string Nombre = data.Cells[1].Value.ToString();

                decimal SubTotal = Convert.ToDecimal(data.Cells[3].Value);

                decimal Total = Convert.ToDecimal(data.Cells[4].Value);

                DateTime date = Convert.ToDateTime(data.Cells[5].Value);

                TimeSpan hora = TimeSpan.Parse(data.Cells[6].Value.ToString());

                Frmservicio2 frmNuevo = new Frmservicio2(numeroruc, Nombre, SubTotal, Total, date, hora);

                frmNuevo.Show();
            }
        }
        private void BtnAd_Usuario_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(BtnAd_Usuario, "Modulo de Administracion de Usuario");
        }
        private void BtnHome_MouseEnter(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(BtnHome, "Home");
        }
        private void BtnReg_pas_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(BtnReg_pas, "Modulo de Registros de Pacientes");
        }
        private void BtnGesti_Exa_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(BtnGesti_Exa, "Modulo de Gestion de Examenes");
        }
        private void BtnConf_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(BtnConf, "Configuracion");
        }
        private void BtnCitas_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(BtnCitas, "Modulo de Reservacion de Citas");
        }
        private void Btnrespaldo_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(BtnConf, "Respaldo de los modulos");
        }
        private void BtnFac_m_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(BtnFac_m, "Modulo de Recepcion de Facturacion");
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
        private void BtnNuevoExamen_Click(object sender, EventArgs e)
        {
            FrmNuevoExamen examen = new FrmNuevoExamen();

            examen.Show();
        }

        private void BtnEditarExamen_Click(object sender, EventArgs e)
        {
            if (DtgExamen.Rows.Count > 0)
            {
                DataGridViewRow data = DtgExamen.SelectedRows[0];

                int Numero = Convert.ToInt32(data.Cells[0].Value);

                string Categoria = data.Cells[1].Value.ToString();

                string Examen = data.Cells[2].Value.ToString();

                string Plantilla = data.Cells[3].Value.ToString();

                decimal Precio = Convert.ToDecimal(data.Cells[4].Value);

                FrmEditarExamen editarExamen = new FrmEditarExamen(Numero,Categoria,Examen,Plantilla,Precio);

                editarExamen.Show();
            }
        }

        private void iconButton6_Click(object sender, EventArgs e)
        {
            if (DtgPaciente.SelectedRows.Count > 0)
            {
                DataGridViewRow data = DtgPaciente.SelectedRows[0];

                LblCodigo.Text = data.Cells[0].Value.ToString();

                TxtNombre.Text = data.Cells[1].Value.ToString();

                TxtApellido.Text = data.Cells[2].Value.ToString();

                DtpFecha.Text = data.Cells[3].Value.ToString();

                CmbSexo.Text = data.Cells[5].Value.ToString();

                txtTelefono.Text = data.Cells[6].Value.ToString();
            }
            BtnEditar.Enabled = false;

            TxtNombre.Enabled = true;
            TxtApellido.Enabled = true;
            txtTelefono.Enabled = true;
            CmbSexo.Enabled = true;
            BtnGuardar.Enabled = true;
            BtnCancelar.Enabled = true;
        }

        private void iconButton7_Click(object sender, EventArgs e)
        {
              TxtNombre.Clear();
            TxtApellido.Clear();
            txtTelefono.Clear();
            DtpFecha.Focus();
            CmbSexo.Focus();

            TxtNombre.Enabled = true;
            TxtApellido.Enabled = true;
            txtTelefono.Enabled = true;
            CmbSexo.Enabled = true;
            DtpFecha.Enabled = true;

            BtnGuardar.Enabled = true;
            BtnCancelar.Enabled = true;
            BtnNuevoPaciente.Enabled = false;
            BtnEditarPaciente.Enabled = false;
        }

        private void TxtBuscarPaciente_Enter(object sender, EventArgs e)
        {
            if (TxtBuscarPaciente.Text == "Buscar Paciente")
            {
                TxtBuscarPaciente.Text = "";
                TxtBuscarPaciente.ForeColor = Color.Black;
            }
        }

        private void BtnBuscarpaciente_Click_1(object sender, EventArgs e)
        {
            if (!int.TryParse(TxtBuscarPaciente.Text, out _))
            {
                string Paciente = TxtBuscarPaciente.Text;

                DtgPaciente.DataSource = paciente.LeerPacientesporId(Paciente);
            }
            else
            {
                MessageBox.Show("No existe tal dato", "SQL Server", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void Btnrefrescarpaciente_Click_1(object sender, EventArgs e)
        {
            DtgPaciente.DataSource = paciente.LeerPacientes();
        }

        private void BtnDarPaciente_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Quieres realizar esta acción?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (resultado == DialogResult.Yes)
            {
                if (DtgPaciente.SelectedRows.Count > 0)
                {
                    DataGridViewRow data = DtgPaciente.SelectedRows[0];

                    DateTime numeroruc = Convert.ToDateTime(data.Cells[3].Value.ToString());

                    paciente.ActualizarEstado(numeroruc);

                    MessageBox.Show("El Registro fue dado de baja", "SQL Server", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("La Tabla esta vacia, no puede dar de baja", "SQL Server", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrWhiteSpace(TxtNombre.Text) && !String.IsNullOrWhiteSpace(txtTelefono.Text))
                {
                    string Nombre = TxtNombre.Text;

                    string Apellido = TxtApellido.Text;

                    DateTime Nacimiento = Convert.ToDateTime(DtpFecha.Text);

                    long telefono = Convert.ToInt64(txtTelefono.Text);

                    string Sexo = CmbSexo.Text;

                    paciente.InsertarPacientes(Nombre, Apellido, telefono, Nacimiento, Sexo);

                    MessageBox.Show("Guardardo exitosamente", "SQL Server", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    TxtNombre.Clear();

                    TxtApellido.Clear();

                    txtTelefono.Clear();

                    TxtNombre.Enabled = false;

                    TxtApellido.Enabled = false;

                    txtTelefono.Enabled = false;

                    CmbSexo.Enabled = false;

                    DtpFecha.Enabled = false;

                    BtnGuardar.Enabled = false;

                    BtnCancelar.Enabled = false; ;

                    BtnEditarPaciente.Enabled = true;

                }
                else
                {
                    error.SetError(BtnGuardar, "Campos incompletos, no se puede guardar");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "SQL Server", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DtgPaciente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (DtgPaciente.SelectedRows.Count > 0)
                {
                    DataGridViewRow data = DtgPaciente.SelectedRows[0];

                    LblCodigo.Text = data.Cells[0].Value.ToString();

                    TxtNombre.Text = data.Cells[1].Value.ToString();

                    TxtApellido.Text = data.Cells[2].Value.ToString();

                    DtpFecha.Text = data.Cells[3].Value.ToString();

                    CmbSexo.Text = data.Cells[5].Value.ToString();

                    txtTelefono.Text = data.Cells[6].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void TxtBuscarFactura_Enter(object sender, EventArgs e)
        {
            if (TxtBuscarFactura.Text == "Buscar Factura")
            {
                TxtBuscarFactura.Text = "";
                TxtBuscarFactura.ForeColor = Color.Black;
            }
        }
        private void TxtBuscarResultados_Enter(object sender, EventArgs e)
        {
            if (TxtBuscarResultados.Text == "Buscar Resultados")
            {
                TxtBuscarResultados.Text = "";
                TxtBuscarResultados.ForeColor = Color.Black;
            }
        }
        private void TxtBuscarExamen_Enter(object sender, EventArgs e)
        {
            if (TxtBuscarExamen.Text == "Buscar Examen")
            {
                TxtBuscarExamen.Text = "";
                TxtBuscarExamen.ForeColor = Color.Black;
            }
        }
        private void Btndardebajacitas_Click(object sender, EventArgs e)
        {

        }
        private void Btnnuevacita_Click(object sender, EventArgs e)
        {
            FrmNuevaCita cita = new FrmNuevaCita();

            cita.Show();
        }

        private void BtnDardebaja_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Quieres realizar esta acción?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (resultado == DialogResult.Yes)
            {
                if (DtgFactura.SelectedRows.Count > 0)
                {
                    DataGridViewRow data = DtgFactura.SelectedRows[0];

                    int numeroruc = Convert.ToInt32(data.Cells[0].Value);

                    Facturacion.ActualizarFacturas(numeroruc);

                    MessageBox.Show("El Registro fue dado de baja", "SQL Server", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("La Tabla esta vacia, no puede dar de baja", "SQL Server", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ICNServicio_Click(object sender, EventArgs e)
        {
            FrmNuevoServicio servicio = new FrmNuevoServicio();

            servicio.Show();
        }
    }
}
