Markdown
# Sistema de Gestión de Nómina (SistemaNominaConsola) 💼

Este software tiene como enfoque el cálculo de pagos semanales para diferentes tipos de empleados: asalariados, por horas, por comisión y asalariados por comisión. La aplicación también incluye la captura de datos de los empleados, el cálculo de pago automático y la generación de reportes semanales detallados aplicando herencia y polimorfismo.

A continuación, una imagen de la consola en funcionamiento:
![Consola en funcionamiento](https://github.com/user-attachments/assets/028ad36f-cbd4-4d5f-bbf7-28bc6db1a1aa)

## Comenzando 🚀

Estas instrucciones te permitirán obtener una copia del proyecto en funcionamiento en tu máquina local para propósitos de desarrollo, pruebas y evaluación académica.

### Pre-requisitos 📋

Para ejecutar este software necesitas tener instalado lo siguiente en tu sistema:

* **.NET 8.0 SDK** (o superior)
* Un entorno de desarrollo como **Visual Studio 2022 / 2026** o **Visual Studio Code** con la extensión de C#.

### Instalación 🔧

Sigue estos pasos para configurar un entorno de desarrollo local:

1. **Clona el repositorio** en tu máquina local usando la terminal o GitHub Desktop:
   ```bash
   git clone [https://github.com/raymelramirez63-svg/SistemaNominaConsola.git](https://github.com/raymelramirez63-svg/SistemaNominaConsola.git)
Navega al directorio del proyecto:

Bash
cd SistemaNominaConsola
Restaura las dependencias del sistema:

Bash
dotnet restore
Ejecuta la aplicación:

Bash
dotnet run
Ejecutando una Demo ⚙️
Una vez ejecutado el programa, interactúa con el menú numérico en la pantalla:

Selecciona la opción 1 para agregar un empleado base (ej. Asalariado).

Ingresa los datos solicitados (Nombre, Apellido, NSS y el Salario Semanal).

Selecciona la opción 6 para procesar la nómina completa y ver el desglose en tiempo real con los formatos de moneda calculados automáticamente.

Verificación de Requisitos (RF-3) 🔩
Para comprobar el recálculo dinámico de pagos:

Selecciona la opción 5, introduce el NSS del empleado registrado anteriormente y modifica sus valores numéricos (horas o ventas) para comprobar cómo el sistema actualiza la memoria inmediatamente antes de generar el nuevo reporte.

Construido con 🛠️
Las herramientas y tecnologías utilizadas en el desarrollo de la arquitectura del proyecto:

.NET 8.0 - El framework de desarrollo utilizado.

C# 12 - Lenguaje de programación enfocado en objetos.

Git & GitHub - Control de versiones y alojamiento de código.

Autores ✒️
Raymel Ramirez - Trabajo Inicial, Desarrollo de Software y Código Base - raymelramirez63-svg

Licencia 📄
Este proyecto está bajo la Licencia MIT; puedes mirar el archivo LICENSE.md para más detalles si corresponde.

Expresiones de Gratitud 🎁
Muchas gracias al profesor y evaluadores por el tiempo dedicado a la revisión de esta solución arquitectónica de software. 🤓

Proyecto estructurado siguiendo los principios SOLID y la especificación formal del documento de requerimientos (SRS).


### ¿Qué debes hacer ahora?
1. Entra a tu repositorio en GitHub desde el navegador.
2. Dale al lápiz de editar en el archivo `README.md` (como estabas haciendo antes).
3. Borra lo que tienes y pega este bloque completo.
4. Presiona el botón verde de **Commit changes...** para guardar. 

