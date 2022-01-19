using System;
using Escolar;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EscolarTests {
    [TestClass]
    public class HonorTest {
        [TestMethod]
        public void Honor4() {
            string result = ProcesoIndice.HonorCalc(4);
            Assert.AreEqual("Summa Cum Laude", result);
        }
        [TestMethod]
        public void Honor3_9() {
            string result = ProcesoIndice.HonorCalc(3.9);
            Assert.AreEqual("Summa Cum Laude", result);
        }
        [TestMethod]
        public void Honor3_8() {
            string result = ProcesoIndice.HonorCalc(3.8);
            Assert.AreEqual("Summa Cum Laude", result);
        }

        [TestMethod]
        public void Honor3_7() {
            string result = ProcesoIndice.HonorCalc(3.7);
            Assert.AreEqual("Summa Cum Laude", result);
        }
        [TestMethod]
        public void Honor3_6() {
            string result = ProcesoIndice.HonorCalc(3.6);
            Assert.AreEqual("Magna Cum Laude", result);
        }
        [TestMethod]
        public void Honor3_5() {
            string result = ProcesoIndice.HonorCalc(3.5);
            Assert.AreEqual("Magna Cum Laude", result);
        }
        [TestMethod]
        public void Honor3_4() {
            string result = ProcesoIndice.HonorCalc(3.4);
            Assert.AreEqual("Magna Cum Laude", result);
        }
        [TestMethod]
        public void Honor3_3() {
            string result = ProcesoIndice.HonorCalc(3.3);
            Assert.AreEqual("Cum Laude", result);
        }
        [TestMethod]
        public void Honor3_2() {
            string result = ProcesoIndice.HonorCalc(3.2);
            Assert.AreEqual("Cum Laude", result);
        }
        [TestMethod]
        public void Honor3_1() {
            string result = ProcesoIndice.HonorCalc(3.1);
            Assert.AreEqual("Cum Laude", result);
        }
        [TestMethod]
        public void Honor3() {
            string result = ProcesoIndice.HonorCalc(3);
            Assert.AreEqual("Sin Honor", result);
        }
        [TestMethod]
        public void Honor0() {
            string result = ProcesoIndice.HonorCalc(0);
            Assert.AreEqual("Sin Honor", result);
        }
    }
}
