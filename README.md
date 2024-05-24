# API REST en .NET

Este proyecto es una API REST construida con .NET. La siguiente gu�a te ayudar� a configurar y ejecutar el proyecto en tu entorno local.

## Pasos para Configurar y Ejecutar el Proyecto

### 1. Clonar el Repositorio

Primero, clona el repositorio en tu m�quina local usando el siguiente comando:

```bash
git clone https://github.com/oscarpolo/api-prueba-tecnica.git
```
### 2. Abrir la Soluci�n

Abre la soluci�n .sln en tu IDE preferido. Puedes hacerlo desde la l�nea de comandos o directamente desde el men� de tu IDE.

### 3. Modificar la Propiedad "dev" del appsettings.json
En el archivo appsettings.json busca la secci�n "ConnectionStrings" y cambia el valor de "dev" por el string de conexi�n de tu base de datos.
```bash
"ConnectionStrings": {
    "dev": "Data Source = DESKTOP; Initial Catalog = ALGARTECH_PRUEBATECNICA; Integrated Security = True;"
  }
```
### 4. Ejecutar y Probar en Swagger o desde un cliente