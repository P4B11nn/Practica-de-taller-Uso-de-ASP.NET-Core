# 📋 My Task Manager - ASP.NET Core

Una aplicación web moderna para gestión de tareas desarrollada con **ASP.NET Core 8**, **Entity Framework Core** y **Bootstrap 5**.

![ASP.NET Core](https://img.shields.io/badge/ASP.NET%20Core-8.0-blue)
![Entity Framework](https://img.shields.io/badge/Entity%20Framework-8.0-green)
![Bootstrap](https://img.shields.io/badge/Bootstrap-5.0-purple)
![SQLite](https://img.shields.io/badge/SQLite-Database-orange)

## 🌟 Características Principales

- ✅ **Gestión Completa de Tareas**: Crear, editar, eliminar y completar tareas
- 🖼️ **Subida de Imágenes**: Adjunta imágenes a tus tareas
- 🎯 **Drag & Drop**: Reordena tus tareas arrastrando y soltando
- 🔐 **Autenticación de Usuarios**: Sistema completo de registro y login
- 📱 **Diseño Responsive**: Funciona perfectamente en móviles y escritorio
- 🎨 **Interfaz Moderna**: Diseño limpio con Bootstrap 5 e iconos
- 💾 **Base de Datos SQLite**: Almacenamiento local sin configuración adicional

## 🛠️ Tecnologías Utilizadas

### Backend
- **ASP.NET Core 8.0** - Framework web
- **Entity Framework Core 8.0** - ORM para base de datos
- **ASP.NET Core Identity** - Sistema de autenticación
- **SQLite** - Base de datos ligera

### Frontend
- **Bootstrap 5** - Framework CSS
- **Bootstrap Icons** - Iconografía
- **jQuery** - Manipulación DOM
- **SortableJS** - Funcionalidad drag & drop
- **HTML5 & CSS3** - Estructura y estilos

## 📋 Prerequisitos

- [.NET 8.0 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- [Entity Framework CLI Tools](https://docs.microsoft.com/en-us/ef/core/cli/dotnet)
- Un editor de código como [Visual Studio](https://visualstudio.microsoft.com/) o [Visual Studio Code](https://code.visualstudio.com/)

## 🚀 Instalación y Configuración

### 1. Clonar el Repositorio
```bash
git clone https://github.com/[tu-usuario]/my-task-manager.git
cd my-task-manager
```

### 2. Restaurar Dependencias
```bash
dotnet restore
```

### 3. Instalar Entity Framework CLI Tools (si no está instalado)
```bash
dotnet tool install --global dotnet-ef --version 8.0.11
```

### 4. Crear la Base de Datos
```bash
# Crear migración inicial (si no existe)
dotnet ef migrations add InitialCreate

# Aplicar migraciones
dotnet ef database update
```

### 5. Ejecutar la Aplicación
```bash
dotnet run
```

La aplicación estará disponible en:
- **HTTP**: http://localhost:5152
- **HTTPS**: https://localhost:7236

## 📖 Cómo Usar la Aplicación

### 1. **Registro e Inicio de Sesión**
- Regístrate con un email y contraseña
- Inicia sesión para acceder a tus tareas

### 2. **Gestión de Tareas**
- **Crear**: Haz clic en "Nueva Tarea" y completa el formulario
- **Editar**: Haz clic en una tarea para editarla
- **Completar**: Marca el checkbox para completar una tarea
- **Eliminar**: Usa el botón de eliminar en cada tarea

### 3. **Subida de Imágenes**
- Al crear o editar una tarea, puedes adjuntar una imagen
- Las imágenes se almacenan en el servidor y se muestran en la lista

### 4. **Reordenar Tareas**
- Arrastra y suelta las tareas para cambiar su orden
- El orden se guarda automáticamente

## 🏗️ Estructura del Proyecto

```
📁 Taller ASP.NET Core/
├── 📁 Controllers/          # Controladores MVC
│   ├── HomeController.cs    # Controlador principal
│   └── TasksController.cs   # Controlador de tareas
├── 📁 Data/                 # Configuración de datos
│   └── ApplicationDbContext.cs
├── 📁 Models/               # Modelos de datos
│   ├── TaskItem.cs         # Modelo de tarea
│   └── ErrorViewModel.cs   # Modelo de errores
├── 📁 Views/                # Vistas Razor
│   ├── 📁 Home/            # Vistas del Home
│   ├── 📁 Tasks/           # Vistas de tareas
│   └── 📁 Shared/          # Vistas compartidas
├── 📁 wwwroot/             # Archivos estáticos
│   ├── 📁 css/             # Estilos CSS
│   ├── 📁 js/              # JavaScript
│   ├── 📁 lib/             # Librerías (Bootstrap, jQuery)
│   └── 📁 uploads/         # Imágenes subidas
├── 📁 Migrations/          # Migraciones de EF
└── Program.cs              # Configuración principal
```

## 🗄️ Modelo de Datos

### TaskItem
```csharp
public class TaskItem
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public bool IsCompleted { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime? CompletedAt { get; set; }
    public string? ImagePath { get; set; }
    public int Order { get; set; }
    public string UserId { get; set; }
}
```

## 🔧 Configuración

### Base de Datos
La aplicación utiliza SQLite por defecto. La cadena de conexión se encuentra en `appsettings.json`:

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Data Source=app.db"
  }
}
```

### Archivos Subidos
Las imágenes se almacenan en `wwwroot/uploads/` y se referencian en la base de datos.

## 🧪 Ejecutar Pruebas

```bash
# Compilar el proyecto
dotnet build

# Verificar que no hay errores
dotnet build --verbosity normal
```

## 🚀 Despliegue

### Publicación para Producción
```bash
dotnet publish -c Release -o ./publish
```

### Variables de Entorno Recomendadas
- `ASPNETCORE_ENVIRONMENT=Production`
- `ConnectionStrings__DefaultConnection` (para base de datos externa)

## 🤝 Contribuir

1. Fork el proyecto
2. Crea una rama para tu feature (`git checkout -b feature/AmazingFeature`)
3. Commit tus cambios (`git commit -m 'Add some AmazingFeature'`)
4. Push a la rama (`git push origin feature/AmazingFeature`)
5. Abre un Pull Request

## 📝 Notas de Desarrollo

- La aplicación utiliza **ASP.NET Core Identity** para autenticación
- **Entity Framework Core** con patrón Code-First
- **Bootstrap 5** para diseño responsive
- **SortableJS** para funcionalidad drag & drop
- **SQLite** como base de datos por simplicidad

## 🙏 Agradecimientos

- [ASP.NET Core Team](https://github.com/dotnet/aspnetcore) por el framework
- [Bootstrap Team](https://getbootstrap.com/) por el framework CSS
- [Entity Framework Team](https://github.com/dotnet/efcore) por el ORM

