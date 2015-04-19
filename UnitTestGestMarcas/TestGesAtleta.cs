using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using gestorMarcas.Models;

namespace UnitTestGestMarcas
{
    [TestClass]
    public class TestGesAtleta
    {

        public IPerson GetAthlete(DateTime BornDate)
        {
            IPerson atleta = new Athlete();
            atleta.Sex = eSex.M;
            atleta.BornDate = BornDate;
            return atleta;
        }

        [TestMethod]
        public void ObtenerCategoriaM35()
        {
            //Arrange
            ICategory mastersCategory = new MastersCategory();
            //Action
            var result = mastersCategory.GetCategory(GetAthlete(DateTime.Parse("03/05/1976")));
            //Assert
            Assert.AreEqual("M35",result,"La categoría es erronea, debería ser M35");
        }

        [TestMethod]
        public void ObtenerCategoriaAnyoExactoM38()
        {
            //Arrange            
            ICategory mastersCategory = new MastersCategory();
            //Action
            var result = mastersCategory.GetYearCategory(GetAthlete(DateTime.Parse("03/05/1976")));
            //Assert
            Assert.AreEqual("M38", result, "La categoría debería ser M38");
        }

        [TestMethod]
        public void ObtenerCategoriaAnyoExactoSiendoHoyMiCumpleanyos()
        {
            //Arrange            
            ICategory mastersCategory = new MastersCategory();
            //Action
            var result = mastersCategory.GetYearCategory(GetAthlete(DateTime.Parse(DateTime.Today.Day.ToString() + "/" + DateTime.Today.Month.ToString() + "/" + "1976")));
            //Assert
            Assert.AreEqual("M39", result, "La categoría debería ser M39 por que hoy es mi cumpleaños");
        }

        [TestMethod]
        public void ObtenerCategoriaAnyoExactoSiendoAyerMiCumpleanyos()
        {
            //Arrange            
            ICategory mastersCategory = new MastersCategory();
            //Action
            var result = mastersCategory.GetYearCategory(GetAthlete(DateTime.Parse((DateTime.Today.Day-1).ToString() + "/" + DateTime.Today.Month.ToString() + "/" + "1976")));
            //Assert
            Assert.AreEqual("M39", result, "La categoría debería ser M39 por que ayer fue mi cumpleaños");
        }

        [TestMethod]
        public void ObtenerCategoriaAnyoExactoSiendoManyanaMiCumpleanyos()
        {
            //Arrange            
            ICategory mastersCategory = new MastersCategory();
            //Action
            var result = mastersCategory.GetYearCategory(GetAthlete(DateTime.Parse((DateTime.Today.Day + 1).ToString() + "/" + DateTime.Today.Month.ToString() + "/" + "1976")));
            //Assert
            Assert.AreEqual("M38", result, "La categoría debería ser M38 por que ayer fue mi cumpleaños");
        }

        [TestMethod]
        public void ObtenerPorcentage60lisosM38()
        {
            //Arrange            
            AthleticEvent athleticEvent = new AthleticEvent();
            int yearBorn = 38;
            eSex sex = eSex.M;
            decimal personalMark = 7.98m;
            VelocityRace velocityRaceEvent = new VelocityRace();
            velocityRaceEvent.VelocityRaceType = eVelocityRaceType.m60ll;
            decimal expected = 80.95m;
            //Action
            var result = athleticEvent.GetPercentage(sex, yearBorn, velocityRaceEvent, personalMark);
            //Assert
            Assert.AreEqual(expected, result, "El porcentage obtenido no es correcto");
        }

        [TestMethod]
        public void ObtenerPorcentageSaltoLongitudM38()
        {
            //Arrange            
            AthleticEvent athleticEvent = new AthleticEvent();
            int yearBorn = 38;
            eSex sex = eSex.M;
            decimal personalMark = 6.05m;
            JumpConcourse longJumpEvent = new JumpConcourse();
            decimal expected = 73.42m;
            //Action
            var result = athleticEvent.GetPercentage(sex, yearBorn, longJumpEvent, personalMark);
            //Assert
            Assert.AreEqual(expected, result, "El porcentage obtenido no es correcto");
        }
    }
}
