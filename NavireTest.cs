using UnitTest___Navire;
namespace TP_Navire_Unit
{
    public class NavireTest
    {
        private TestContext textContextInstance;
        public TestContext TestContext;

        private Navire _navire;

        private Navire _n1;
        private Navire _n2;

        [SetUp]
        public void Setup()
        {
            // Création d'un navire
            _navire = new Navire("001", "NavireTest", "Destroyer", 50);
            _n1 = new Navire("A12345", "Navira A", "Minerai", 1000);
            _n2 = new Navire("B4710", "Navire B", "Pétrole", 0);
        }

        [Test]
        public void EstDechargerTestCasNavireNonDeCharge()
        {
            bool expected = false;
            bool actual = _n1.EstDecharger();
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void EstDechargerTestCasNavireDecharger()
        {
            bool test = _n2.EstDecharger();
            Assert.IsTrue(test);
        }


        [Test]
        public void DechargerTest()
        {
            int nb = 25;
            _navire.Decharger(nb);
            Assert.AreEqual(25, _navire.GetQteFret());
        }

        [Test]
        public void EstDechargerTest()
        {
            _navire.Decharger(50);
            Assert.IsTrue(_navire.EstDecharger());
        }

        [Test]
        public void GetTypeFretTest()
        {
            Assert.AreEqual(50, _navire.GetQteFret());

        }


        [TearDown]
        public void Teardown()
        {

        }
    }
}