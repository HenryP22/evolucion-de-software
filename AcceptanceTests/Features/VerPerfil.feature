Feature: VerPerfil
	COMO usuario 
	QUIERO ver si mi información es correcta 
	PARA que no exista ningún inconveniente al momento de contactar el servicio o para la contratación

@mytag
Scenario: Opcion perfil
	Given el usuario quiere verificar su perfil registrado en la aplicación web
	When presione el botón “Mi Perfil”
	Then podrá revisar los datos de su perfil

@mytag
Scenario: Visualizacion de datos personales
	Given que el usuario este en la opción “Mi Perfil”
	When quiera acceder a su información detallada
	Then se mostrara su respectivos datos y foto personal

@mytag
Scenario: Registro de activiades
	Given el usuario quiere ver sus recientes actividades
	When el usuario ingrese a la opción “Mi Perfil”
	Then se mostrará un lista de actividades tales como los servicios de tutorías contratados y sus respectivos pagos