using System;
using TechTalk.SpecFlow;

namespace AcceptanceTests.Steps
{
    [Binding]
    public class GuardarDocenteFavoritoSteps
    {
        [Given(@"el padre de familia logueado en la aplicación \[cuando] ingrese a la opción ""(.*)"" y encuentra a un docente de su agrado")]
        public void GivenElPadreDeFamiliaLogueadoEnLaAplicacionCuandoIngreseALaOpcionYEncuentraAUnDocenteDeSuAgrado(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"el padre de familia ligueado en la aplicación")]
        public void GivenElPadreDeFamiliaLigueadoEnLaAplicacion()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"el padre de familia desea visualizar sus docente favoritos")]
        public void GivenElPadreDeFamiliaDeseaVisualizarSusDocenteFavoritos()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"ingrese a la opción ""(.*)"" y encuentra a un docente de su agrado")]
        public void WhenIngreseALaOpcionYEncuentraAUnDocenteDeSuAgrado(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"ingrese a la sección ""(.*)"" y seleccione el filtro ""(.*)""")]
        public void WhenIngreseALaSeccionYSeleccioneElFiltro(string p0, string p1)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"no podrá volver a marcar al docente, en cambio se quitará el favorito")]
        public void ThenNoPodraVolverAMarcarAlDocenteEnCambioSeQuitaraElFavorito()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"se le mostrará una lista de todos los docentes favoritos con su respectiva informacion detallada")]
        public void ThenSeLeMostraraUnaListaDeTodosLosDocentesFavoritosConSuRespectivaInformacionDetallada()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
