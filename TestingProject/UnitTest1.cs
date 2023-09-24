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
            Assert.IsTrue(result, "El enlace no es funcional o no lleva a la dirección correcta.");
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
            Assert.IsTrue(result, "La selección de cantidad de personas no es válida.");
        }

        [Test]
        public void TestSeleccionarCantidadPersonas_InvalidSelection()
        {
            // Arrange
            var solicitudService = new SolicitudPuestoClaveService();
            var seleccion = ""; // Simulando que no se ha seleccionado ninguna opción

            // Act
            var result = solicitudService.SeleccionarCantidadPersonas(seleccion);

            // Assert
            Assert.IsFalse(result, "Se esperaba una selección inválida, pero el sistema la aceptó.");
        }
    }
}
