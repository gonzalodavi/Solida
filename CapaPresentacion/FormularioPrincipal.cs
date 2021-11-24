using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using CapaComun.Cache;
using FontAwesome.Sharp;
using CapaNegocio;
using System.Diagnostics;
using CapaPresentacion;

namespace Presentacion
{
    public partial class FormularioPrincipal : Form
    {
        //INSTANCIAMOS UN OBJETO DE LA CLASE CN_USUARIOS
        CN_Usuarios objetoCN = new CN_Usuarios();

        //INSTANCIAMOS ESTA CLASE QUE NOS SIRVE PARA CONTAR EL TIEMPO DE SESION
        Stopwatch oSW = new Stopwatch();

        private Form activeForm = null;
        private IconButton currentBtn;
        private string usuario = null;
        private string fecha = null;
        private string tiempoSesion = null;

        public FormularioPrincipal()
        {
            InitializeComponent();
            customizeDesing();

            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        //METODO-CODIGO QUE PERMITE ARRASTRAR LA VENTANA - SE LO LLAMA DESDE LA PROPIEDAD: MOUSE DOWN
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);


        //METODO QUE TRAE DEL CACHÉ ROL, NOMBRE Y APELLIDO DEL USUARIO QUE INICIA LA SESION
        private void LoadUserData()
        {
            lblNombre.Text = UserLoginCache.Nombre + " " + UserLoginCache.Apellido;
            lblRol.Text = UserLoginCache.Rango;
            usuario = UserLoginCache.Usuario;           
        }

        private void FormularioPrincipal_Load(object sender, EventArgs e)
        {            
            LoadUserData();
            horaFecha.Enabled = true;
            inicioSesion();

            //CONDICIONES QUE HABILITAN BOTONES SEGUN LOS PRIVILEGIOS DE USUARIO
            if (UserLoginCache.Rango == Roles.Encargado)
            {
                btnAjustes.Enabled = false;
                btnAjustes.Visible = false;
            }
            if (UserLoginCache.Rango == Roles.Operador)
            {
                btnAjustes.Enabled = false;
                btnInformes.Enabled = false;
                btnAjustes.Visible = false;
                btnInformes.Visible = false;
            }
            if (UserLoginCache.Rango == Roles.Contador)
            {
                btnAjustes.Enabled = false;
                btnAjustes.Visible = false;
                btnVentas.Enabled = false;
                btnVentas.Visible = false;
                btnCompras.Enabled = false;
                btnCompras.Visible = false;
            }
            if (UserLoginCache.Rango == Roles.OperadorCompras)
            {
                btnAjustes.Enabled = false;
                btnAjustes.Visible = false;
                btnVentas.Enabled = false;
                btnVentas.Visible = false;
                btnInformes.Enabled = false;
                btnInformes.Visible = false;
            }
            if (UserLoginCache.Rango == Roles.OperadorVentas)
            {
                btnAjustes.Enabled = false;
                btnAjustes.Visible = false;
                btnCompras.Enabled = false;
                btnCompras.Visible = false;
                btnInformes.Enabled = false;
                btnInformes.Visible = false;
            }
        }

        //METODO QUE INICIA EL CONTADOR Y GUARDA LA FECHA Y EL USUARIO QUE INICIA LA SESION
        private void inicioSesion()
        {
            oSW.Start();
            timer1.Enabled = true;

            fecha = DateTime.Now.ToShortDateString();
            objetoCN.InsertarSesiones(usuario,fecha);
        }


        //METODO PARA DETENER TIEMPO DE SESIÓN GUARDAR FECHA Y HORA EN TABLA 
        private void finSesion()
        {
            oSW.Stop();
            fecha = DateTime.Now.ToShortDateString();
            objetoCN.EditarSesiones(fecha, tiempoSesion);
        }


        //METODO PARA MOSTAR FECHA Y HORA
        private void horaFecha_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("HH:mm");
            lblFecha.Text = DateTime.Now.ToLongDateString();
        }


        //METODO PARA CONTAR EL TIEMPO TRANSCURRIDO EN UNA SESIÓN
        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan ts = new TimeSpan(0, 0, 0, 0, (int)oSW.ElapsedMilliseconds);
            
            if (ts.Days == 0)
            {
                if (ts.Hours == 0)
                {
                    if (ts.Minutes == 0)
                    {
                        tiempoSesion = ts.Seconds.ToString() + " seg ";
                    }
                    else
                    {
                        tiempoSesion = ts.Minutes.ToString() + " min " + ts.Seconds.ToString() + " seg ";
                    }
                }
                else
                {
                    tiempoSesion = ts.Hours.ToString() + " hs " + ts.Minutes.ToString() + " min " + ts.Seconds.ToString() + " seg ";
                }                  
            }
            else
            {
                tiempoSesion = ts.Days.ToString() + " dia/s " + ts.Hours.ToString() + " hs " + ts.Minutes.ToString() + " min " + ts.Seconds.ToString() + " seg ";
            }
        }


        //METODOS PARA OCULTAR/DESPLEGAR LOS SUBMENUS
        private void customizeDesing()  
        {
            panelSubMenuVentas.Visible = false;
            panelSubMenuCompras.Visible = false;
            panelSubMenuInformes.Visible = false;
            panelSubMenuAjustes.Visible = false;
        }

        private void hideSubMenu()
        {
            if (panelSubMenuVentas.Visible == true)
                panelSubMenuVentas.Visible = false;
            if (panelSubMenuCompras.Visible == true)
                panelSubMenuCompras.Visible = false;
            if (panelSubMenuInformes.Visible == true)
                panelSubMenuInformes.Visible = false;
            if (panelSubMenuAjustes.Visible == true)
                panelSubMenuAjustes.Visible = false;            
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                DisableButton();
                subMenu.Visible = false;
            }
        }

        
        //METODOS PARA HABILITAR/DESHABILITAR LOS BOTONES AL PRESIONAR
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(0, 255, 255);
            public static Color color2 = Color.FromArgb(0, 217, 254);
            public static Color color3 = Color.FromArgb(0, 174, 254);
            public static Color color4 = Color.FromArgb(0, 46, 253);
            public static Color color5 = Color.FromArgb(249, 120, 34);
            public static Color color6 = Color.FromArgb(155, 200, 28);
        }

        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(12, 52, 119);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
            }
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.Transparent;
                currentBtn.ForeColor = Color.White;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.White;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }


        //METODO PARA ABRIR UN FORMULARIO EN EL FORMULARIO PRINCIPAL
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelContenedor.Controls.Add(childForm);
            panelContenedor.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }       


        private void btnVentas_Click(object sender, EventArgs e)
        {            
            ActivateButton(sender, RGBColors.color3);
            showSubMenu(panelSubMenuVentas);
        }

        private void btnCompras_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
            showSubMenu(panelSubMenuCompras);
        }

        private void btnInformes_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
            showSubMenu(panelSubMenuInformes);
        }

        private void btnAjustes_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
            showSubMenu(panelSubMenuAjustes);
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            openChildForm(new FormClientes());
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            openChildForm(new FormProductos());
        }

        private void btnFacturacion_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            openChildForm(new FormVentas());
        }

        private void btnRecibos_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            openChildForm(new FormRecibos());
        }

        private void btnNotaCred_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            openChildForm(new FormNotaDBCR());
        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            openChildForm(new FormProveedor());
        }

        private void btnProductosP_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            openChildForm(new FormProductos());
        }

        private void btnFactCompra_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            openChildForm(new FormCompras());
        }

        private void btnOPago_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            openChildForm(new FormOPagos());
        }

        private void btnRemitos_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            openChildForm(new FormRemitos());

        }

        private void btnRubros_Click(object sender, EventArgs e)
        {
            hideSubMenu();

        }

        private void btnInfCaja_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnInfBanco_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnInfCheques_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            openChildForm(new FormCheques());
        }

        private void btnInfVtas_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            openChildForm(new FormInfoVentas());
        }

        private void btnInfCompras_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            openChildForm(new FormInfoCompras());
        }

        private void btnInfStock_Click(object sender, EventArgs e)
        {
            hideSubMenu();            
        }

        private void btnInfCtasCtes_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            openChildForm(new FormDetalleCCC());
        }


        private void btnAdminUsuarios_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            openChildForm(new FormGestionUsuarios());
        }

        private void btnSesionesUsuarios_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            openChildForm(new FormSesionesUsuario());
        }

        private void btnConfSucursal_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            openChildForm(new FormSucursales());
        }

        private void btnCuentasBanco_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            openChildForm(new FormBanco());
        }


        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            DisableButton();
            if (MessageBox.Show("¿Desea cerrar la sesión?", "¡Atencion!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                finSesion();
                this.Close();
            }
        }

        private void btnEditarPerfil_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            DisableButton();
            Form formBG = new Form();
            using (FormEditarUsuario mm = new FormEditarUsuario())
            {
                formBG.StartPosition = FormStartPosition.Manual;
                formBG.FormBorderStyle = FormBorderStyle.None;
                formBG.Opacity = .70d;
                formBG.BackColor = Color.Black;
                formBG.WindowState = FormWindowState.Maximized;
                formBG.TopMost = true;
                formBG.Location = this.Location;
                formBG.ShowInTaskbar = false;
                formBG.Show();

                mm.Owner = formBG;
                mm.ShowDialog();

                formBG.Dispose();
            }
        }


        //ACCION QUE PERMITE MOVER LA VENTANA HACIENDO CLICK EN PANEL SUPERIOR
        private void panelArriba_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }


        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea finalizar el sistema?", "¡Atencion!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                finSesion();
                Application.Exit();
            }
        }

        /*private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
        }*/

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }              
    }
}