namespace UnitTesting
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestCariTandaBilangan1()
        {
            //Arrange
            int a = 69;

            string expected = "Positif";

            //Act
            string cekHasil = CariTandaBilangan(a);

            //Assert
            Assert.AreEqual(expected, cekHasil);
        }

        // [TestMethod]
        public void TestCariTandaBilangan2()
        {
            //Arrange
            int a = -420;

            string expected = "Negatif";

            //Act
            string cekHasil = CariTandaBilangan(a);

            //Assert
            Assert.AreEqual(expected, cekHasil);

        }

        // [TestMethod]
        public void TestCariTandaBilangan3()
        {
            //Arrange
            int a = 0;

            string expected = "Nol";

            //Act
            string cekHasil = CariTandaBilangan(a);

            //Assert
            Assert.AreEqual(expected, cekHasil);

        }

        public static string CariTandaBilangan(int a)
        {
            string hasil;

            if (a < 0)
            {
                hasil = "Negatif";
            }
            else if (a > 0)
            {
                hasil = "Positif";
            }
            else
            {
                hasil = "Nol";
            }

            return hasil;

        }
    }
}