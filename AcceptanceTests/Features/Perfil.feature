Feature: Perfil
	Ver perfil del usuario

@mytag
Scenario: Ingresar a mi perfil
	Given el usuario quiera verificar su perfil
	When presione la opcion mi perfil
	Then podra revisar los datos del perfil mostrado

@mytag
Scenario: Visualizar datos personales
	Given el usuario esta en mi perfil
	When quiera acceder a la información
	Then se mostrara sus datos

@mytag
Scenario: Registro de actividades 
	Given el usuario quiere ver sus recientes actividades
	When ingrese a mi perfil
	Then se mostrara una lista de actividades
