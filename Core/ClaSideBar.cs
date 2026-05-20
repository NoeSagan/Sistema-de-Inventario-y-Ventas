namespace ISW_II_2
{
    internal class ClaSideBar
    {
        private readonly Panel _panel;
        private readonly Form  _parent;

        // Módulos accesibles por rol
        private static readonly Dictionary<string, HashSet<string>> _permisos = new()
        {
            ["Administrador"] = new HashSet<string>
            {
                "Dashboard", "Ventas", "Productos", "Inventario",
                "Proveedores", "Ordenes", "Clientes", "Garantias",
                "Reportes", "Usuarios"
            },
            ["Encargado de Inventario"] = new HashSet<string>
            {
                "Dashboard", "Productos", "Inventario",
                "Proveedores", "Ordenes"
            },
            ["Vendedor"] = new HashSet<string>
            {
                "Dashboard", "Ventas", "Clientes", "Garantias"
            }
        };

        public ClaSideBar(Panel pnlSidebar, Form parent)
        {
            _panel  = pnlSidebar;
            _parent = parent;
        }

        public void Configurar()
        {
            string rol     = Sesion.Rol;
            var modulosRol = _permisos.TryGetValue(rol, out var perms)
                             ? perms
                             : new HashSet<string>();

            foreach (Control ctrl in _panel.Controls)
            {
                if (ctrl is not Button btn) continue;

                string tag = btn.Tag?.ToString() ?? "";

                if (tag == "Cerrar Sesión")
                {
                    btn.Visible = true;
                    btn.Click  += BtnCerrarSesion_Click;
                    continue;
                }

                string clave = NormalizarTag(tag);
                btn.Visible = modulosRol.Contains(clave);

                if (btn.Visible)
                {
                    string claveCaptured = clave;
                    btn.Click += (s, e) => Navegar(claveCaptured);
                }
            }
        }

        private void Navegar(string modulo)
        {
            // Evitar recrear el mismo formulario
            if (_parent.GetType().Name == NombreFormulario(modulo)) return;

            Form destino = modulo switch
            {
                "Dashboard"   => new FrmDashboard(),
                "Ventas"      => new FrmVentas(),
                "Productos"   => new FrmProductos(),
                "Inventario"  => new FrmInventario(),
                "Proveedores" => new FrmProveedores(),
                "Ordenes"     => new FrmOrdenesCompra(),
                "Clientes"    => new FrmClientes(),
                "Garantias"   => new FrmGarantias(),
                "Reportes"    => new FrmReportes(),
                "Usuarios"    => MensajeEnDesarrollo(),
                _             => MensajeEnDesarrollo()
            };

            if (destino is _PlaceholderForm)
            {
                destino.Dispose();
                return;
            }

            destino.Show();
            _parent.Close();
        }

        private void BtnCerrarSesion_Click(object? sender, EventArgs e)
        {
            var confirmar = MessageBox.Show(
                "¿Desea cerrar sesión?", "Cerrar sesión",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmar != DialogResult.Yes) return;

            Sesion.Limpiar();

            var login = Application.OpenForms.OfType<Login>().FirstOrDefault();
            if (login != null)
                login.Show();
            else
                new Login().Show();

            _parent.Close();
        }

        // Devuelve el nombre de clase esperado para cada módulo
        private static string NombreFormulario(string modulo) => modulo switch
        {
            "Dashboard"   => "FrmDashboard",
            "Ventas"      => "FrmVentas",
            "Productos"   => "FrmProductos",
            "Inventario"  => "FrmInventario",
            "Proveedores" => "FrmProveedores",
            "Ordenes"     => "FrmOrdenesCompra",
            "Clientes"    => "FrmClientes",
            "Garantias"   => "FrmGarantias",
            "Reportes"    => "FrmReportes",
            _             => ""
        };

        // Normaliza el Tag del diseñador a clave interna del diccionario de permisos
        private static string NormalizarTag(string tag) => tag switch
        {
            "Dashboard"   => "Dashboard",
            "Ventas"      => "Ventas",
            "Productos"   => "Productos",
            "Inventario"  => "Inventario",
            "Proveedores" => "Proveedores",
            "Ordenes"     => "Ordenes",
            "Clientes"    => "Clientes",
            "Garantías"   => "Garantias",
            "Garantias"   => "Garantias",
            "Reportes"    => "Reportes",
            "Usuarios"    => "Usuarios",
            _             => tag
        };

        private static Form MensajeEnDesarrollo()
        {
            MessageBox.Show("Módulo en desarrollo.", "Información",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            return new _PlaceholderForm();
        }

        // Formulario marcador para el patrón de módulo en desarrollo
        private class _PlaceholderForm : Form { }
    }
}
