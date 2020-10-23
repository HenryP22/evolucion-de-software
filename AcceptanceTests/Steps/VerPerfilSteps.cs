using System;
using TechTalk.SpecFlow;

namespace AcceptanceTests.Steps
{
    [Binding]
    public class VerPerfilSteps
    {
        [Given(@"el usuario quiere verificar su perfil registrado en la aplicación web")]
        public void GivenElUsuarioQuiereVerificarSuPerfilRegistradoEnLaAplicacionWeb()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"que el usuario este en la opción ""(.*)""")]
        public void GivenQueElUsuarioEsteEnLaOpcion(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"el usuario quiere ver sus recientes actividades")]
        public void GivenElUsuarioQuiereVerSusRecientesActividades()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"presione el botón ""(.*)""")]
        public void WhenPresioneElBoton(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"quiera acceder a su información detallada")]
        public void WhenQuieraAccederASuInformacionDetallada()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"el usuario ingrese a la opción ""(.*)""")]
        public void WhenElUsuarioIngreseALaOpcion(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"podrá revisar los datos de su perfil")]
        public void ThenPodraRevisarLosDatosDeSuPerfil()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"se mostrara su respectivos datos y foto personal")]
        public void ThenSeMostraraSuRespectivosDatosYFotoPersonal()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"se mostrará un lista de actividades tales como los servicios de tutorías contratados y sus respectivos pagos")]
        public void ThenSeMostraraUnListaDeActividadesTalesComoLosServiciosDeTutoriasContratadosYSusRespectivosPagos()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
