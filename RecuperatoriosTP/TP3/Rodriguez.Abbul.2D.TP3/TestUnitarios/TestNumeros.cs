using Microsoft.VisualStudio.TestTools.UnitTesting;
using EntidadesInstanciables;

namespace TestUnitarios
{
    [TestClass]
    public class TestNotNull
    {
        [TestMethod]

        public void ValidaInt()
        {
            int id = 1;
            string nombre = "Seba";
            string apellido = "Perez";
            string dni = "23444444";
            EntidadesAbstractas.Persona.ENacionalidad nacionalidad = EntidadesAbstractas.Persona.ENacionalidad.Argentino;
            Universidad.EClases clase = Universidad.EClases.Legislacion;

            Alumno alu = new Alumno(id, nombre, apellido, dni, nacionalidad, clase);

            Assert.IsNotNull(alu.Dni);
            Assert.IsNotNull(alu.Apellido);
            Assert.IsNotNull(alu.Nacionalidad);
            Assert.IsNotNull(alu.Nombre);
        }
    }
}
