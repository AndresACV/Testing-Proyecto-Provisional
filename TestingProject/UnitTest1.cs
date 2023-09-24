using NUnit.Framework;
using WebApplication1.Model;

namespace TestingProject
{
    [TestFixture] // Atributo para la clase de prueba
    public class ManualPuestoTests
    {
        [Test]
        public void TestLinkFuncional()
        {
            // Arrange
            string enlace = "https://www.aya.go.cr/SitePages/Principal.aspx";
            var manualPuestoService = new ManualPuestoService(enlace);

            // Act
            var result = manualPuestoService.AccederManualPuesto();

            // Assert
            Assert.IsTrue(result, "El enlace no es funcional o no lleva a la direcci�n correcta.");
        }
    }

    [TestFixture] // Atributo para la clase de prueba
    public class SolicitudPuestoClaveTests
    {
        [Test]
        public void TestSeleccionarCantidadPersonas_ValidSelection()
        {
            // Arrange
            var solicitudService = new SolicitudPuestoClaveService();
            var seleccion = "2"; // Puedes cambiar este valor para probar diferentes selecciones

            // Act
            var result = solicitudService.SeleccionarCantidadPersonas(seleccion);

            // Assert
            Assert.IsTrue(result, "La selecci�n de cantidad de personas no es v�lida.");
        }

        [Test]
        public void TestSeleccionarCantidadPersonas_InvalidSelection()
        {
            // Arrange
            var solicitudService = new SolicitudPuestoClaveService();
            var seleccion = ""; // Simulando que no se ha seleccionado ninguna opci�n

            // Act
            var result = solicitudService.SeleccionarCantidadPersonas(seleccion);

            // Assert
            Assert.IsFalse(result, "Se esperaba una selecci�n inv�lida, pero el sistema la acept�.");
        }
    }
}
