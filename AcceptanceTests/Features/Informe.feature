Feature: Informe
	Revisar informe

@mytag
Scenario: Informe no subido
	Given el padre esta en la seccion clases
	When se dirija a detalles
	Then aparecera un mensaje de no subido

@mytag
Scenario: Informe subido
	Given el padre esta en la seccion clases
	When se dirija a detalles
	Then podra visualizar el informe
	And podra descargarlo mediante un boton

@mytag
Scenario: Informe incorrecto
	Given el padre esta en la seccion clases
	When se dirija a detalles
	And revise el archivo
	Then podra enviar una notificacion si es incorrecto
