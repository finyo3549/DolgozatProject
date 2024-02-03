using DolgozatProject;
namespace TestDolgozatProject

{
    public class DolgozatTest
    {
        [Test]
        public void PontFelvesz()
        {
            Dolgozat dolgozat = new Dolgozat();
            dolgozat.PontFelvesz(80);

            Assert.AreEqual(1, dolgozat.Pontok.Count);
            Assert.AreEqual(80, dolgozat.Pontok[0]);
        }
        [Test]
        public void PontFelvesz_Hibas()
        {
            Dolgozat dolgozat = new Dolgozat();
            
            // Asserting that ArgumentException is thrown for invalid input
            Assert.Throws<ArgumentException>(() => dolgozat.PontFelvesz(-2));
            Assert.Throws<ArgumentException>(() => dolgozat.PontFelvesz(101));
        }
        [Test]
        public void MindenkiMegirta_hibas()
        {
            Dolgozat dolgozat = new Dolgozat();
            dolgozat.PontFelvesz(75);
            dolgozat.PontFelvesz(-1); // Diák nem írta meg a dolgozatot

            Assert.Throws<ArgumentException>(() => dolgozat.MindenkiMegirta());

            Assert.Pass();

        }

        [Test]
        public void MindenkiMegirta()
        {
            Dolgozat dolgozat = new Dolgozat();
            dolgozat.PontFelvesz(85);
            dolgozat.PontFelvesz(70);

            Assert.IsTrue(dolgozat.MindenkiMegirta());
        }
        [Test]
        public void Bukas()
        {
            Dolgozat dolgozat = new Dolgozat();
            dolgozat.PontFelvesz(60);
            dolgozat.PontFelvesz(40);

            Assert.AreEqual(1, dolgozat.Bukas);
        }

        [Test]
        public void Elegseges()
        {
            Dolgozat dolgozat = new Dolgozat();
            dolgozat.PontFelvesz(55);
            dolgozat.PontFelvesz(58);

            Assert.AreEqual(2, dolgozat.Elegseges);
        }

        [Test]
        public void Kozepes()
        {
            Dolgozat dolgozat = new Dolgozat();
            dolgozat.PontFelvesz(63);
            dolgozat.PontFelvesz(67);

            Assert.AreEqual(2, dolgozat.Kozepes);
        }

        [Test]
        public void Jo()
        {
            Dolgozat dolgozat = new Dolgozat();
            dolgozat.PontFelvesz(73);
            dolgozat.PontFelvesz(78);

            Assert.AreEqual(2, dolgozat.Jo);
        }

        [Test]
        public void Jeles()
        {
            Dolgozat dolgozat = new Dolgozat();
            dolgozat.PontFelvesz(85);
            dolgozat.PontFelvesz(90);

            Assert.AreEqual(2, dolgozat.Jeles);
        }
        [Test]
        public void Ervenytelen()
        {
            Dolgozat dolgozat = new Dolgozat();
            dolgozat.PontFelvesz(85);
            dolgozat.PontFelvesz(90);
            dolgozat.PontFelvesz(-1);
            dolgozat.PontFelvesz(-1);
            dolgozat.PontFelvesz(-1);
            dolgozat.PontFelvesz(45);
            Assert.IsTrue(dolgozat.Ervenytelen);
            
        }
        [Test]
        public void GyanusNegativ()
        {
            Dolgozat dolgozat = new Dolgozat();
            Assert.Throws<ArgumentException>(() => dolgozat.Gyanus(-1));
        }
        [Test]
        public void Gyanus()
        {
            Dolgozat dolgozat = new Dolgozat();
            dolgozat.PontFelvesz(85);
            dolgozat.PontFelvesz(90);
            dolgozat.PontFelvesz(85);
            dolgozat.PontFelvesz(90);
            Assert.Throws<ArgumentException>(() => dolgozat.Gyanus(3));
        }
    }
    

}