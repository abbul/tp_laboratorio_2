using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;

namespace TestUnitarios
{
    [TestClass]
    public class TestPaquete
    {
        [TestMethod]
        public void ValidaDistintosTrakingID()
        {
            Paquete pUno = new Paquete("Av. Corrientes 8541", "123-456-789");
            Paquete pDos = new Paquete("Calle 25 de Mayo 32", "123-456-789");
            Paquete pTres = new Paquete("Ruta 248 Km 233443", "113-456-789");

            bool resultado_1 = (pUno == pDos);
            Assert.AreEqual(true, resultado_1);

            bool resultado_2 = (pUno != pDos);
            Assert.AreEqual(false, resultado_2);

            bool resultado_3 = (pUno == pTres);
            Assert.AreEqual(false, resultado_3);

            bool resultado_4 = (pUno != pTres);
            Assert.AreEqual(true, resultado_4);

        }
    }
}
