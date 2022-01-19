using System;
using System.Collections.Generic;
using Escolar;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EscolarTests {
    [TestClass]
    public class IndiceAcumuladoTest {
        [TestMethod]
        public void Indice4() {
            List<Publicacion> publicaciones = new List<Publicacion>();
            publicaciones.Add(new Publicacion("A", 5));
            publicaciones.Add(new Publicacion("A", 4));
            Assert.AreEqual(4, ProcesoIndice.IndiceCalc(publicaciones), 0.1);
        }

        [TestMethod]
        public void Indice3_4() {
            List<Publicacion> publicaciones = new List<Publicacion>();
            publicaciones.Add(new Publicacion("B", 5));
            publicaciones.Add(new Publicacion("A", 4));
            Assert.AreEqual(3.4, ProcesoIndice.IndiceCalc(publicaciones), 0.1);
        }

        [TestMethod]
        public void Indice3_5() {
            List<Publicacion> publicaciones = new List<Publicacion>();
            publicaciones.Add(new Publicacion("A", 4));
            publicaciones.Add(new Publicacion("B", 4));
            Assert.AreEqual(3.5, ProcesoIndice.IndiceCalc(publicaciones), 0.1);
        }

        [TestMethod]
        public void Indice2_9() {
            List<Publicacion> publicaciones = new List<Publicacion>();
            publicaciones.Add(new Publicacion("A", 4));
            publicaciones.Add(new Publicacion("B", 4));
            publicaciones.Add(new Publicacion("C", 5));
            Assert.AreEqual(2.9, ProcesoIndice.IndiceCalc(publicaciones), 0.1);
        }

        [TestMethod]
        public void Indice2_6() {
            List<Publicacion> publicaciones = new List<Publicacion>();
            publicaciones.Add(new Publicacion("A", 4));
            publicaciones.Add(new Publicacion("C", 4));
            publicaciones.Add(new Publicacion("C", 5));
            Assert.AreEqual(2.6, ProcesoIndice.IndiceCalc(publicaciones), 0.1);
        }
        [TestMethod]
        public void Indice2_3() {
            List<Publicacion> publicaciones = new List<Publicacion>();
            publicaciones.Add(new Publicacion("A", 4));
            publicaciones.Add(new Publicacion("C", 4));
            publicaciones.Add(new Publicacion("C", 5));
            publicaciones.Add(new Publicacion("D", 3));
            Assert.AreEqual(2.3, ProcesoIndice.IndiceCalc(publicaciones), 0.1);
        }

        [TestMethod]
        public void Indice2_5() {
            List<Publicacion> publicaciones = new List<Publicacion>();
            publicaciones.Add(new Publicacion("A", 4));
            publicaciones.Add(new Publicacion("B", 4));
            publicaciones.Add(new Publicacion("C", 4));
            publicaciones.Add(new Publicacion("D", 4));
            Assert.AreEqual(2.5, ProcesoIndice.IndiceCalc(publicaciones), 0.1);
        }

        [TestMethod]
        public void Indice1_9() {
            List<Publicacion> publicaciones = new List<Publicacion>();
            publicaciones.Add(new Publicacion("A", 4));
            publicaciones.Add(new Publicacion("B", 4));
            publicaciones.Add(new Publicacion("C", 4));
            publicaciones.Add(new Publicacion("D", 4));
            publicaciones.Add(new Publicacion("F", 5));
            Assert.AreEqual(1.9, ProcesoIndice.IndiceCalc(publicaciones), 0.1);
        }
    }
}
