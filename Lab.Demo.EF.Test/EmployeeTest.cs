using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab.Demo.EF.Logic;
using Lab.Demo.EF.Entities;

namespace Lab.Demo.EF.Test
{
    /// <summary>
    /// Descripción resumida de EmployeeTest
    /// </summary>
    [TestClass]
    public class EmployeeTest
    {

        EmployeeLogic logic;

        [TestInitialize]

        public void setup() {

           logic = new EmployeeLogic();

        }

        private TestContext testContextInstance;

        /// <summary>
        ///Obtiene o establece el contexto de las pruebas que proporciona
        ///información y funcionalidad para la serie de pruebas actual.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Atributos de prueba adicionales
        //
        // Puede usar los siguientes atributos adicionales conforme escribe las pruebas:
        //
        // Use ClassInitialize para ejecutar el código antes de ejecutar la primera prueba en la clase
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup para ejecutar el código una vez ejecutadas todas las pruebas en una clase
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Usar TestInitialize para ejecutar el código antes de ejecutar cada prueba 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup para ejecutar el código una vez ejecutadas todas las pruebas
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void ObtenerEmpleados()
        {

            // Arrange

            int cantidadEmpleados = 9 ;

            // Act

            var empleados = logic.GetAll();

            //Assert

            Assert.AreEqual(empleados.Count, cantidadEmpleados);

        }

        [TestMethod]

        public void ObtenerEmpleadosOrdenadosAP() {

            //Arrange

            int cantidadEmpleados = 9;

            //Act

            var empleadosOrder = logic.GetAllOrderAP();
            //Assert

            Assert.AreEqual(empleadosOrder.Count, cantidadEmpleados);

        }

        [TestMethod]

        public void ObtenerLos3empleadosMasViejos() {

            //Arrange

            int cantidadOlder = 3;

            //Act

            var empleadosViejos = logic.GetTresOlder();
            //Assert

            Assert.AreEqual(empleadosViejos.Count, cantidadOlder);
        
        }

        [TestMethod]
        public void ObtenerEmpleadosConCodigoPostal() {

            //Arrange

            int cantidadEmpleadosConPC = 1;
            int postalCode = 98401;

            //Act

            var empleadosWithPC = logic.GetWithPC(postalCode);

            //Assert

            Assert.AreEqual(empleadosWithPC.Count, cantidadEmpleadosConPC);
        
        
        }

        [TestMethod]
        public void ObtenerEmpleadosConTerritorios() {

            //Arrange

            //Act

            var empleadosWithTerritorios = logic.GetEmpWithTerritories();

            //Assert

            Assert.IsTrue(empleadosWithTerritorios.Count <10 );
        }
    }
}
