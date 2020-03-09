using Lab.Demo.EF.Entities;
using Lab.Demo.EF.Logic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Demo.EF.Test
{
    [TestClass]
    public class RegionTest
    {

        ILogic<Region> logic;

        [TestInitialize]

        public void setup() {

            logic = new RegionLogic();

        }

        [TestMethod]

        public void ObtenerRegion() {

            //Arrange

            int id = 1;
            string name = "Eastern";

            //Act

            var regiones = logic.GetOne(id);

            //Assert

            Assert.AreEqual(regiones.RegionDescription.Trim(), name);
        }

        [TestMethod]
        public void ObtenerRegiones() {

            //Arrange

            //Act

            var listaRegiones = logic.GetAll();

            //Assert
            Assert.IsTrue(listaRegiones.Count > 0);


        }

        [TestMethod]

        public void EliminarRegion()
        {

            //Arrange

            int idMax = 5;

            var regionDelete = logic.GetOne(idMax);

            //Act

            var regiones = logic.Delete(regionDelete);

            //Assert

            Assert.IsTrue(regiones.Count < idMax);

        }

        [TestMethod]

        public void GuardarRegion()
        {

            //Arrange

            //¿Esto esta bien? 
            //Creo que rompe con la idea de que no deben depender de otro test. Aca estariamos dependiendo del test de ObtenerRegiones
            var regionAnterior = logic.GetAll();

            var region = new Region();

            region.RegionID = 5;
            region.RegionDescription = "Rosario";


            //No puedo manipular datos de PK y si trato de ingresar una PK duplicada entity lo detecta y detiene el guardado
            //region = logic.GetOne(4);
            //region.RegionID = region.RegionID + 1;

            //Act

            var regionPosterior = logic.Add(region);

            //Assert

            Assert.IsTrue(regionPosterior.Count > regionAnterior.Count);

        }

        [TestMethod]

        public void ActualizarRegion() {

            //Arrange

            var reg = new Region();
            reg.RegionID = 5;
            reg.RegionDescription = "RosarioMOD";

            //Act

            var regionActualizada = logic.Update(reg);


            //Assert


            Assert.AreEqual(regionActualizada.RegionDescription.Trim(), "RosarioMOD");

        }


    }
}
