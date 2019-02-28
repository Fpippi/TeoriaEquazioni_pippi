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
            bool risultato2 = EquazioniLibrary.Equazioni.IsDetermined(n1);//lo va
            Assert.AreEqual(risultato, risultato2);
        }
        [TestMethod]
        public void TestisDetermined2()
        {
            double n1 = 0; bool risultato = false;//faccio le variabili
            bool risultato2 = EquazioniLibrary.Equazioni.IsDetermined(n1);//lo va
            Assert.AreEqual(risultato, risultato2);
        }
        [TestMethod]
        public void TestisDetermined3()
        {
            double n1 = -1; bool risultato = true;//faccio le variabili
            bool risultato2 = EquazioniLibrary.Equazioni.IsDetermined(n1);//lo va
            Assert.AreEqual(risultato, risultato2);
        }
        
    }
}
