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


        [TestMethod]
        public void Delta()
        {
            double n1 = 1, num2 = 1, num3 = 1; double risultato = -3;
            double risultato2 = EquazioniLibrary.Equazioni.Delta(n1,num2,num3);
            Assert.AreEqual(risultato, risultato2);
        }
        [TestMethod]
        public void Delta2()
        {
            double n1 = 1, num2 = 1, num3 = 0; double risultato = 1;
            double risultato2 = EquazioniLibrary.Equazioni.Delta(n1, num2, num3);
            Assert.AreEqual(risultato, risultato2);
        }
        [TestMethod]
        public void Delta3()
        {
            double n1 = 0, num2 = 1, num3 = 1; double risultato = 1;
            double risultato2 = EquazioniLibrary.Equazioni.Delta(n1, num2, num3);
            Assert.AreEqual(risultato, risultato2);
        }
        [TestMethod]
        public void Delta4()
        {
            double n1 = 0, num2 = 0, num3 = 0; double risultato = 0;
            double risultato2 = EquazioniLibrary.Equazioni.Delta(n1, num2, num3);
            Assert.AreEqual(risultato, risultato2);
        }




    }
}
