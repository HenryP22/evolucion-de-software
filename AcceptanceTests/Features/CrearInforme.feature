Feature: CrearInforme
 COMO docente 
 QUIERO crear informe sobre la tutoría realizada 
 PARA que mis clientes puedan tener presente el avance realizado
 
Scenario: Crear informe
 Given el docente debe crear un informe por cada tutoría
  When el tiempo de la tutoría haya finalizado
  Then al docente le aparecerá la opción de "Realizar Imforme"

Scenario: Editar informe
 Given el docente desea editar información errónea respecto al informe
 When they go to the option "anterior"
 Then  se le mostrará la interfaz del informe con sus datos anteriores

Scenario: Enviar Informe
 Given el docente desea enviar el informe de desempeño
 When ya haya completado el informe, este se dirigirá a la opción "Siguiente"
 Then se le mostrará una interfaz con la descripción del informe para que pueda revisar si están correctos y si es así seleccionará la opción "Enviar"

Scenario: Reclamo
 Given  el padre de familia no ha comprendido del todo el informe creado por el docente 
  When este realice su reclamo
  Then el docente tendrá que editarlo, de tal manera que el cliente esté conforme