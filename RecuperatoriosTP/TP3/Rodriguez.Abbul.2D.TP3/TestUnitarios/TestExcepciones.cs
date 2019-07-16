using Microsoft.VisualStudio.TestTools.UnitTesting;
using EntidadesInstanciables;
using Excepciones;
using Archivos;

namespace TestUnitarios
{
    [TestClass]
    public class TestExcepciones
    {
        [TestMethod]
        [ExpectedException(typeof(AlumnoRepetidoException))]
        // patron idela para los test unitarios: AAA(Arrange, Act,Assert)
        public void AlumnoRepetido()
        {
            // ARRANGE --- aca iran todas los datos y objectos necesarios.
            int id = 1;
            string nombre = "Seba";
            string apellido = "Perez";
            string dni = "23444444";
            EntidadesAbstractas.Persona.ENacionalidad nacionalidad = EntidadesAbstractas.Persona.ENacionalidad.Argentino;
            Universidad.EClases clase = Universidad.EClases.Legislacion;

            // ACT --- incova los metodos
            Alumno alu = new Alumno(id, nombre, apellido, dni, nacionalidad, clase);

            Universidad uni = new Universidad();
            uni += alu;
            uni += alu;

        }

        [TestMethod]
        [ExpectedException(typeof(ArchivosException))]
        // patron idela para los test unitarios: AAA(Arrange, Act,Assert)
        public void Archivos()
        {
            Universidad uni = new Universidad();
            uni.Leer();
        }

        [TestMethod]
        [ExpectedException(typeof(DniInvalidoException))]
        // patron idela para los test unitarios: AAA(Arrange, Act,Assert)
        public void DniInvalido()
        {
            // ARRANGE --- aca iran todas los datos y objectos necesarios.
            int id = 1;
            string nombre = "Seba";
            string apellido = "Perez";
            string dni = "98999999999";
            EntidadesAbstractas.Persona.ENacionalidad nacionalidad = EntidadesAbstractas.Persona.ENacionalidad.Argentino;
            Universidad.EClases clase = Universidad.EClases.Legislacion;

            // ACT --- incova los metodos
             Alumno alu= new Alumno(id,nombre,apellido,dni,nacionalidad,clase);

            // ASSERT --- comprueba si el resultado esperados son correctos


        }

        [TestMethod]
        [ExpectedException(typeof(NacionalidadInvalidaException))]
        // patron idela para los test unitarios: AAA(Arrange, Act,Assert)
        public void NaciondalidadInvalida()
        {
            // ARRANGE --- aca iran todas los datos y objectos necesarios.
            int id = 1;
            string nombre = "Seba";
            string apellido = "Perez";
            string dni = "98999999";
            EntidadesAbstractas.Persona.ENacionalidad nacionalidad = EntidadesAbstractas.Persona.ENacionalidad.Argentino;
            Universidad.EClases clase = Universidad.EClases.Legislacion;

            // ACT --- incova los metodos
            Alumno alu = new Alumno(id, nombre, apellido, dni, nacionalidad, clase);

            // ASSERT --- comprueba si el resultado esperados son correctos


        }

        [TestMethod]
        [ExpectedException(typeof(SinProfesorException))]
        // patron ideal para los test unitarios: AAA(Arrange, Act,Assert)
        public void SinProfesor()
        {
            /*Clase*/ Universidad.EClases clase = Universidad.EClases.Legislacion;
            /*Profesor*/ Profesor profe = new Profesor(1, "Juan", "Kike","333333", EntidadesAbstractas.Persona.ENacionalidad.Argentino);
            /* Jornada */ Jornada jornada;

            if (profe != Universidad.EClases.Laboratorio)
            {
                 jornada = new Jornada(Universidad.EClases.Laboratorio, profe);
            }
            else if (profe != Universidad.EClases.Legislacion)
            {
                 jornada = new Jornada(Universidad.EClases.Legislacion, profe);
            }
            else
            {
                 jornada = new Jornada(Universidad.EClases.Programacion, profe);
            }

        }


    }
}
