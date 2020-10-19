Feature: Tarjeta
	Registrar tarjeta

@mytag
Scenario: Ingresar tarjeta
	Given el padre quiere registar su tarjeta
	When este en la opcion mi perfil
	Then se mostrara una opcion mi tarjeta
	And seleccionara agregar tarjeta
	And registrara el numero y fecha de vencimiento

@mytag
Scenario: Eliminar tarjeta
	Given el padre quiere eliminar su tarjeta
	When este en la opcion mi perfil
	Then se mostrara una opcion mi tarjeta
	And eliminara la tarjeta mostrada mediante un boton

@mytag
Scenario: Datos mal ingresados
	Given el sistema rechazo la tarjeta ingresada
	When el padre completo los datos de la tarjeta
	Then se mostrara un mensaje de datos incorrectos