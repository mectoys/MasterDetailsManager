BizLayer Manager  
MasterDetailsManager
![BackgroundIntro](https://github.com/user-attachments/assets/08091206-bd17-428a-a4ad-4b65612ee45d)

📌 Descripción

MasterDetailsManager es un proyecto desarrollado en C# utilizando Windows Forms, con arquitectura en capas (BLL, DAL, MODELS, UI) y conectado a una base de datos MySQL. Este proyecto implementa el patrón Master-Detail, permitiendo gestionar una tabla maestra y su detalle con operaciones básicas de CRUD:

📌 Insertar registros

🔄 Actualizar datos

❌ Anular registros

📋 Listar información

Este repositorio forma parte de una serie de tutoriales educativos donde se explica paso a paso cómo implementar la arquitectura en capas en C#.

📂 Estructura del Proyecto
MasterDetailsManager/
│── BLL/           # Capa de lógica de negocio
│── DAL/           # Capa de acceso a datos
│── MODELS/        # Definición de entidades y modelos
│── UI/            # Interfaz de usuario en Windows Forms
│── database.sql   # Script para crear la base de datos MySQL
│── README.md      # Documentación del proyecto

🚀 Tecnologías Utilizadas

🖥️ C# (Windows Forms .NET Framework)

🗄️ MySQL como base de datos

🔌 ADO.NET para la conexión a la base de datos

🏗️ Arquitectura en capas (BLL, DAL, MODELS, UI)

📖 Requisitos Previos

Antes de ejecutar el proyecto, asegúrate de tener instalado:

🟢 Visual Studio (Recomendado: VS 2019 o superior)

🟢 MySQL Server y MySQL Workbench

🟢 .NET Framework 4.7.2 o superior

🟢 Conector MySQL para .NET (MySQL.Data)

🛠️ Instalación y Configuración

📥 Clona el repositorio:
git clone https://github.com/mectoys/MasterDetailsManager.git

🏗️ Importa la base de datos:

Abre MySQL Workbench o cualquier cliente MySQL.

Ejecuta el script Cabecera.txt y  Detalle.txt ubicado en la carpeta DAL\Script para crear las tablas necesarias.

🔧 Configura la conexión a la base de datos:

Edita el archivo en UI/App.config y reemplaza los datos de conexión:
   <connectionStrings>
    <add name="MySqlConnectionString" connectionString="Server=localhost;Database=nombre_basedatos;Uid=root;Pwd=tu_contraseña;" providerName="MySql.Data.MySqlClient"/>
  </connectionStrings>


▶️ Ejecuta el proyecto:

Abre la solución en Visual Studio.

Configura UI como proyecto de inicio.

Presiona F5 para compilar y ejecutar.

🎯 Funcionalidades Principales

✅ Capa DAL (Data Access Layer) → Maneja la conexión a la base de datos y consultas SQL.
✅ Capa BLL (Business Logic Layer) → Implementa la lógica de negocio y validaciones.
✅ Capa MODELS → Define las clases y entidades de la aplicación.
✅ Capa UI (User Interface) → Interfaz gráfica con Windows Forms.
✅ Operaciones CRUD → Crear, actualizar, eliminar y listar registros.
✅ Patrón Master-Detail → Relación entre tabla maestra y detalle.

🎥 Tutoriales Relacionados

Este proyecto forma parte de una serie de videos tutoriales en YouTube, donde explico cada parte en detalle. 📺
👉 Ver la lista de reproducción completa
📩 Contacto y Feedback

Si tienes dudas, sugerencias o mejoras, no dudes en abrir un issue o contactarme en:
📧 Email: mectoys2013@gmail.com📌 YouTube: MectoysTV

🚀 ¡Aprende y mejora tus habilidades en C#!
