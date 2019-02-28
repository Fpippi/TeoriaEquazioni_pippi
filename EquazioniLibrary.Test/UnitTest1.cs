using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EquazioniLibrary.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestisDetermined()
        {
            double n1 = 1;bool risultato = true;//faccio le variabili
            bool risultato2 = EquazioniLibrary.Equazioni.IsDetermined(n1);//lo vado a richiamare
            Assert.AreEqual(risultato, risultato2);//lo confronto
        }
        [TestMethod]
        public void TestisDetermined2()
        {
            double n1 = 0; bool risultato = false;
            bool risultato2 = EquazioniLibrary.Equazioni.IsDetermined(n1);
            Assert.AreEqual(risultato, risultato2);
        }
        [TestMethod]
        public void TestisDetermined3()
        {
            double n1 = -1; bool risultato = true;
            bool risultato2 = EquazioniLibrary.Equazioni.IsDetermined(n1);
            Assert.AreEqual(risultato, risultato2);
        }

        
        [TestMethod]
        public void TestIsconsisted1()
        {
            double n1 = 0, num2 = 0; bool risultato = false;
            bool risultato2 = EquazioniLibrary.Equazioni.IsInconsisted(n1,num2);
            Assert.AreEqual(risultato, risultato2);
        }
        [TestMethod]
        public void TestIsconsisted2()
        {
            double n1 = 0, num2 = 1; bool risultato = true;
            bool risultato2 = EquazioniLibrary.Equazioni.IsInconsisted(n1, num2);
            Assert.AreEqual(risultato, risultato2);
        }
        [TestMethod]
        public void TestIsconsisted3()
        {
            double n1 = 0, num2 = -1; bool risultato = true;
            bool risultato2 = EquazioniLibrary.Equazioni.IsInconsisted(n1, num2);
            Assert.AreEqual(risultato, risultato2);
        }
        [TestMethod]
        public void TestIsconsisted4()
        {
            double n1 = 1, num2 = 0; bool risultato = false;
            bool risultato2 = EquazioniLibrary.Equazioni.IsInconsisted(n1, num2);
            Assert.AreEqual(risultato, risultato2);
        }
        [TestMethod]
        public void TestIsconsisted5()
        {
            double n1 = -1, num2 = 0; bool risultato = false;
            bool risultato2 = EquazioniLibrary.Equazioni.IsInconsisted(n1, num2);
            Assert.AreEqual(risultato, risultato2);
        }


        [TestMethod]
        public void TestIsdegree1()
        {
            double n1 = 0; bool risultato = false;
            bool risultato2 = EquazioniLibrary.Equazioni.IsDegree2(n1);
            Assert.AreEqual(risultato, risultato2);
        }
        [TestMethod]
        public void TestIsdegree2()
        {
            double n1 = -1; bool risultato = true;
            bool risultato2 = EquazioniLibrary.Equazioni.IsDegree2(n1);
            Assert.AreEqual(risultato, risultato2);
        }
        [TestMethod]
        public void TestIsdegree3()
        {
            double n1 = 1; bool risultato = true;
            bool risultato2 = EquazioniLibrary.Equazioni.IsDegree2(n1);
            Assert.AreEqual(risultato, risultato2);
        }

    }
}
