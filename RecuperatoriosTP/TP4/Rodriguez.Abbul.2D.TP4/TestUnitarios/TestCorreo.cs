using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;

namespace TestUnitarios
{
    [TestClass]
    public class TestCorreo
    {
        [TestMethod]
        public void ListaDePaquetesInstancia()
        {
            Correo correo = new Correo();

            correo += new Paquete("Calle sin nombre", "232432432");
            int resultado = correo.Paquetes.Count;
            int resultadoEsperado = 1;


            Assert.AreEqual(resultadoEsperado, resultado);
        }
    }
}
