using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassesPropriete;

namespace Tests
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void TestCompteur2()
        {
            //int nbBcpBoites = 0;
            Boite[] testBcpBoites = new Boite[76];
            for (int i = 0; i < 76; i++)
            {
                testBcpBoites[i] = new Boite();
                //nbBcpBoites = Boite.NbBoites;
                //NbBcpBoites++;
            }
            Assert.AreEqual(76, Boite.NbBoites);
        }


        [TestMethod]
        public void TestCalculVolume()
        {
            Boite newBoite = new Boite(10, 5, 6);
            double d = newBoite.Volume;
            Assert.AreEqual(300, d);


        }

        [TestMethod]
        public void TestCompteur()
        {
            Boite b1 = new Boite();
            Boite b2 = new Boite();
            int x = Boite.NbBoites;
            Assert.AreEqual(79, x);

        }

      
    }


}
