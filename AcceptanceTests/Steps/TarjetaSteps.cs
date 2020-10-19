using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace AcceptanceTests.Steps
{
    [Binding]
    public sealed class TarjetaSteps
    {
        [Given(@"el padre quiere registar su tarjeta")]
        public void GivenElPadreQuiereRegistarSuTarjeta()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"este en la opcion mi perfil")]
        public void WhenEsteEnLaOpcionMiPerfil()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"se mostrara una opcion mi tarjeta")]
        public void ThenSeMostraraUnaOpcionMiTarjeta()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"seleccionara agregar tarjeta")]
        public void ThenSeleccionaraAgregarTarjeta()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"registrara el numero y fecha de vencimiento")]
        public void ThenRegistraraElNumeroYFechaDeVencimiento()
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"el padre quiere eliminar su tarjeta")]
        public void GivenElPadreQuiereEliminarSuTarjeta()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"eliminara la tarjeta mostrada mediante un boton")]
        public void ThenEliminaraLaTarjetaMostradaMedianteUnBoton()
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"el sistema rechazo la tarjeta ingresada")]
        public void GivenElSistemaRechazoLaTarjetaIngresada()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"el padre completo los datos de la tarjeta")]
        public void WhenElPadreCompletoLosDatosDeLaTarjeta()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"se mostrara un mensaje de datos incorrectos")]
        public void ThenSeMostraraUnMensajeDeDatosIncorrectos()
        {
            ScenarioContext.Current.Pending();
        }

    }
}
