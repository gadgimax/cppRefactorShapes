*Resumen de Cambios*

Interfaces Agregadas: Se introdujo IIdioma para manejar múltiples idiomas y IFormaGeometrica para diferentes tipos de formas.

*Nuevas Clases para Aggregations:*

FormaResumen: Representa un resumen del conteo de formas, áreas y perímetros.

FormaResumenBuilder: Maneja la lógica de agregación, desacoplándola de la generación del informe.

Renombramiento de la Clase Principal: Se renombro la clase principal a ReportBuilder, que ahora únicamente formatea y genera el informe, cumpliendo con el Principio de Responsabilidad Única (SRP).

*Consideraciones de Localización*

Los casos de prueba ahora evalúan la configuración de localización, asegurando que:

Formato de EE.UU. (en-US) usa . para la separación decimal.

Otros idiomas (por ejemplo, es-AR, it-IT) usan , para la separación decimal.

Esto garantiza un formato numérico correcto según el idioma seleccionado.

*Nuevas pruebas*

Se agregaron pruebas unitarias alrededor del nuevo idioma (italiano) y la nueva forma (trapecio)
