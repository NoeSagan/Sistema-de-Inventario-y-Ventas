# Sistema de Inventario y Ventas

Sistema de gestión de inventario y ventas desarrollado en **C# .NET 8 (Windows Forms)** con base de datos **PostgreSQL** (Supabase). Incluye control de acceso por roles, módulo de ventas con carrito, gestión de productos, proveedores, clientes, órdenes de compra y dashboard con KPIs en tiempo real.

---

## Tecnologías

| Capa | Tecnología |
|---|---|
| Interfaz | Windows Forms (.NET 8) |
| Base de datos | PostgreSQL (Supabase) |
| Conector BD | Npgsql 10.0.2 |
| Lenguaje | C# 12 |
| IDE recomendado | Visual Studio 2022 |

---

## Módulos

| Módulo | Descripción |
|---|---|
| **Login** | Autenticación con bloqueo por intentos fallidos (pgcrypto) |
| **Dashboard** | KPIs en tiempo real: ventas del día, ingresos, stock bajo, valor de inventario |
| **Ventas** | Carrito de compras, búsqueda de productos, selección de cliente y método de pago |
| **Productos** | Catálogo con filtros por categoría y estado, gestión de precios y stock |
| **Inventario** | Control de niveles de stock y alertas |
| **Proveedores** | Registro de proveedores, historial y desempeño de órdenes |
| **Órdenes de Compra** | Creación y seguimiento de órdenes (Pendiente → Recibida) |
| **Clientes** | Registro y gestión de clientes |
| **Garantías** | Gestión de garantías de productos |
| **Reportes** | Reportes del negocio |
| **Usuarios** | Administración de cuentas (solo Administrador) |

---

## Roles y permisos

El acceso a cada módulo se controla automáticamente por `ClaSideBar` según el rol del usuario autenticado. Los botones del sidebar no visibles para el rol quedan ocultos.

| Módulo | Administrador | Encargado de Inventario | Vendedor |
|---|:---:|:---:|:---:|
| Dashboard | ✓ | ✓ | ✓ |
| Ventas | ✓ | | ✓ |
| Productos | ✓ | ✓ | |
| Inventario | ✓ | ✓ | |
| Proveedores | ✓ | ✓ | |
| Órdenes de Compra | ✓ | ✓ | |
| Clientes | ✓ | | ✓ |
| Garantías | ✓ | | ✓ |
| Reportes | ✓ | | |
| Usuarios | ✓ | | |

---

## Estructura del proyecto

```
Sistema-de-Inventario-y-Ventas/
│
├── Forms/          # Formularios WinForms (.cs + .Designer.cs + .resx)
│   ├── Form1       # Login
│   ├── FrmDashboard
│   ├── FrmVentas
│   ├── FrmProductos
│   ├── FrmInventario
│   ├── FrmProveedores
│   ├── FrmOrdenesCompra
│   ├── FrmClientes
│   ├── FrmGarantias
│   └── FrmReportes
│
├── Modelos/        # Entidades / clases de datos
│   ├── Producto, Proveedor, Cliente, Categoria
│   ├── ItemCarrito, Venta, OrdenCompra
│   └── KpiDashboard, AlertaStock
│
├── Servicios/      # Lógica de negocio y acceso a datos
│   ├── AuthService, DashboardService
│   ├── ProductoService, CategoriaService
│   ├── ClienteService, VentaService
│   ├── ProveedorService, OrdenCompraService
│
├── Core/           # Infraestructura base
│   ├── DBConfig.cs     # Cadena de conexión a PostgreSQL
│   ├── Sesion.cs       # Estado de la sesión activa (usuario, rol)
│   └── ClaSideBar.cs   # Sidebar con navegación y control de acceso por rol
│
├── Program.cs
└── ISW-II 2.csproj
```

---

## Requisitos previos

- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8)
- Visual Studio 2022 con carga de trabajo **Desarrollo de escritorio de .NET**
- Acceso a una instancia de PostgreSQL (local o Supabase)
- Extensión `pgcrypto` habilitada en la base de datos

---

## Configuración

1. Clonar el repositorio:
   ```bash
   git clone https://github.com/tu-usuario/sistema-inventario-ventas.git
   ```

2. Abrir `ISW-II 2.sln` en Visual Studio 2022.

3. Configurar la conexión a la base de datos en `Core/DBConfig.cs`:
   ```csharp
   string host = "TU_HOST";
   string port = "5432";
   string user = "TU_USUARIO";
   string pass = "TU_CONTRASEÑA";
   string db   = "TU_BASE_DE_DATOS";
   ```

4. Ejecutar el script SQL en tu base de datos para crear las tablas, vistas y triggers.

5. Compilar y ejecutar:
   ```bash
   dotnet run
   ```

---

## Base de datos

El sistema utiliza las siguientes vistas para consultas optimizadas:

| Vista | Uso |
|---|---|
| `v_productos_completo` | Productos con nombre de categoría |
| `v_ventas_completo` | Ventas con datos de cliente y vendedor |
| `v_resumen_dashboard` | KPIs del dashboard en una sola consulta |
| `v_productos_stock_bajo` | Alertas de stock con nivel de criticidad |

Los triggers de PostgreSQL gestionan automáticamente:
- Descuento de stock al registrar una venta (`trg_venta_descontar_stock`)
- Actualización de stock al recibir una orden de compra (`trg_orden_recibida`)

---

## Seguridad

- Las contraseñas se almacenan hasheadas con `pgcrypto` (`crypt()`).
- Las cuentas se bloquean automáticamente tras 5 intentos fallidos.
- El acceso a módulos se restringe por rol en tiempo de ejecución; los botones no autorizados no se muestran ni tienen eventos asignados.