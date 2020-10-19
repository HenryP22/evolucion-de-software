using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace AcceptanceTests.Steps
{
    [Binding]
    public sealed class InformeSteps
    {
        [Given(@"el padre esta en la seccion clases")]
        public void GivenElPadreEstaEnLaSeccionClases()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"se dirija a detalles")]
        public void WhenSeDirijaADetalles()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"aparecera un mensaje de no subido")]
        public void ThenApareceraUnMensajeDeNoSubido()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"podra visualizar el informe")]
        public void ThenPodraVisualizarElInforme()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"podra descargarlo mediante un boton")]
        public void ThenPodraDescargarloMedianteUnBoton()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"revise el archivo")]
        public void WhenReviseElArchivo()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"podra enviar una notificacion si es incorrecto")]
        public void ThenPodraEnviarUnaNotificacionSiEsIncorrecto()
        {
            ScenarioContext.Current.Pending();
        }

    }
}
