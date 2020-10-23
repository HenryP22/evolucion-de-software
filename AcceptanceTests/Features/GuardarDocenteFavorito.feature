Feature: GuardarDocenteFavorito
	COMO padre de familia 
	QUIERO poder guardar a los buenos docentes 
	PARA facilitar el contacto con aquellos docentes que me gustó su servicio

@mytag
Scenario: El docente no está marcado
	Given el padre de familia logueado en la aplicación [cuando] ingrese a la opción “buscar clases” y encuentra a un docente de su agrado
	When ingrese a la opción “buscar clases” y encuentra a un docente de su agrado
	Then no podrá volver a marcar al docente, en cambio se quitará el favorito
@mytag
Scenario: El docente ya está marcado
	Given el padre de familia ligueado en la aplicación
	When ingrese a la opción “buscar clases” y encuentra a un docente de su agrado
	Then no podrá volver a marcar al docente, en cambio se quitará el favorito
@mytag
Scenario: Ver lista de docente favoritos
	Given el padre de familia desea visualizar sus docente favoritos
	When ingrese a la sección “tutorías” y seleccione el filtro “favoritos” 
	Then se le mostrará una lista de todos los docentes favoritos con su respectiva informacion detallada