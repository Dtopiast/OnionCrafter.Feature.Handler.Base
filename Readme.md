# OnionCrafter.Feature.Handler.Base

![Versión de la librería](https://img.shields.io/badge/Versi%C3%B3n-1.0.0-brightgreen) [![NuGet](https://img.shields.io/nuget/v/OnionCrafter.Feature.Handler.Base.svg)](https://www.nuget.org/packages/OnionCrafter.Feature.Handler.Base/)

![](https://raw.githubusercontent.com/Dtopiast/OnionCrafter.Feature.Handler.Base/main/Images/Logo.png)

**Estado de la Librería: Pre-Alfa - No Listo para Producción**

Esta librería se encuentra actualmente en un estado pre-alfa, lo que significa que está en una fase muy temprana de desarrollo y no está destinada para su uso en entornos de producción. Estamos trabajando arduamente para mejorar y estabilizar la librería, pero aún pueden existir errores y limitaciones significativas.

Si estás interesado en utilizar esta librería, te recomendamos encarecidamente que la pruebes en un entorno de desarrollo o pruebas para evaluar su idoneidad para tu proyecto. No se garantiza la estabilidad ni la compatibilidad con versiones futuras en este estado inicial.

Por favor, mantente atento a futuras actualizaciones y anuncios sobre el progreso de la librería. Tu retroalimentación y contribuciones son bienvenidas a medida que avanzamos hacia una versión más estable y lista para producción.

## Descripción

OnionCrafter.Feature.Handler.Base es una librería diseñada para facilitar el desarrollo de aplicaciones basadas en la arquitectura Onion y el patrón de diseño CQRS en .NET 7. Proporciona un conjunto esencial de interfaces que permiten definir manejadores de solicitudes de consulta y comandos.

## Características

- **Manejadores de Solicitudes de Consulta (Query Handlers)**: Interfaces que permiten definir manejadores de solicitudes de consulta que siguen el patrón CQRS. Esto simplifica la implementación de consultas y la separación de las operaciones de lectura y escritura en la aplicación.

- **Manejadores de Solicitudes de Comando (Command Handlers)**: Interfaces que facilitan la implementación de manejadores de solicitudes de comando, lo que permite una clara separación de las operaciones de escritura en la aplicación.

- **Arquitectura Onion**: La librería se adhiere al principio de arquitectura Onion, fomentando una estructura de aplicación organizada y mantenible.

- **Extendiendo a MediatR**: Con el respaldo de la biblioteca mas usada para la implementacion del patron mediador se extendie aqui para agregar funcionalidades y mayor seguridad.

## Requisitos

- .NET 7
- MediatR

## Instalación

Puedes agregar esta librería a tu proyecto .NET 7 a través de NuGet. Usa el siguiente comando de NuGet para instalarla:

```bash
dotnet add package OnionCrafter.Feature.Handler.Base
```

## Uso

Para comenzar a utilizar OnionCrafter.Feature.Handler.Base en tu proyecto:

1. Agrega la referencia a esta biblioteca en tu proyecto .NET 7.
2. Extiende las clases base o implementa las interfaces proporcionadas para definir tus propias clases.
3. Personaliza y agrega propiedades y métodos específicos a tus implementaciones según tus necesidades.

Para obtener ejemplos detallados sobre cómo utilizar esta librería, consulta la [documentación](https://github.com/Dtopiast/OnionCrafter.Feature.Handler.Base/wiki).

## Contribuir

Si deseas contribuir a esta librería, ¡te damos la bienvenida! Puedes hacerlo de las siguientes maneras:

1. **Informa problemas:** Si encuentras algún problema o error, por favor, abre un [issue](https://github.com/dtopiast/OnionCrafter.Feature.Handler.Base/issues).

2. **Envía Pull Requests:** Si deseas agregar nuevas características o corregir errores existentes, no dudes en enviar un [pull request](https://github.com/dtopiast/OnionCrafter.Feature.Handler.Base/pulls).

## Licencia

Este proyecto está bajo la [Licencia Mozilla Public v. 2](LICENSE.txt). Consulta el archivo LICENSE.txt para obtener más información.
