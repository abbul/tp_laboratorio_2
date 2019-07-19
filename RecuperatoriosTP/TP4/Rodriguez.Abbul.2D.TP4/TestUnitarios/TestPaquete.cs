using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;

namespace TestUnitarios
{
    [TestClass]
    public class TestPaquete
    {
        [TestMethod]
        [ExpectedException(typeof(TrackingIdRepetidoException))]
        public void ValidaDistintosTrakingID()
        {
            Correo correo = new Correo();
            Paquete pUno = new Paquete("Av. Corrientes 8541", "123-456-789");
            Paquete pDos = new Paquete("Calle 25 de Mayo 32", "123-456-789");

            correo += pUno;
            correo += pDos;

        }
    }
}
