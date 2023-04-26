using net_calculator_tester;

namespace TestCalculator
{
    [TestFixture]
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }


        // Addizione
        [Test]
        [TestCase(6.23f, 3.77f)]
        public void AddOK(float num1, float num2)
        {
            Assert.That(Calculator.Add(num1, num2), Is.EqualTo(10f));
        }

        [Test]
        [TestCase(3.23f, 3.77f)]

        public void AddKO(float num1, float num2)
        {
            Assert.That(Calculator.Add(num1, num2), Is.Not.EqualTo(10f));
        }


        // Sottrazione
        [Test]
        [TestCase(6.23f, 3.77f)]
        public void SubstractOK(float num1, float num2)
        {
            Assert.That(Calculator.Substract(num1, num2), Is.EqualTo(2.46f));
        }

        [Test]
        [TestCase(3.23f, 3.77f)]

        public void SubstractKO(float num1, float num2)
        {
            Assert.That(Calculator.Substract(num1, num2), Is.Not.EqualTo(2.46f));
        }


        // Divisione
        [Test]
        [TestCase(2.5f, 5f)]
        public void DivideOK(float num1, float num2)
        {
            Assert.That(Calculator.Divide(num1, num2), Is.EqualTo(0.5f));

        }

        [Test]
        [TestCase(2.1f, 5.3f)]
        public void DivideKO(float num1, float num2)
        {
            Assert.That(Calculator.Divide(num1, num2), Is.Not.EqualTo(0.5f));
        }

        [Test]
        [TestCase(0f, 0f)]
        public void DivideError(float num1, float num2)
        {
            Assert.Throws<Exception>(() => Calculator.Divide(num1, num2));
        }

        
        // Moltiplicazione
        [Test]
        [TestCase(2.5f, 7.5f)]
        public void MultiplyOK(float num1, float num2)
        {
            Assert.That(Calculator.Multiply(num1, num2), Is.EqualTo(18.75f));
        }

        [Test]
        [TestCase(3.5f, 7.2f)]

        public void MultiplyKO(float num1, float num2)
        {
            Assert.That(Calculator.Multiply(num1, num2), Is.Not.EqualTo(18.75f));
        }


        // Elevamento a potenza
        [Test]
        [TestCase(2.3f, 2f)]

        public void ElevaOK(float numBase, float esponente)
        {
            Assert.That(Calculator.Eleva(numBase, esponente), Is.EqualTo(5.29f));
        }

        [Test]
        [TestCase(2.8f, 4.2f)]

        public void ElevaKO(float numBase, float esponente)
        {
            Assert.That(Calculator.Eleva(numBase, esponente), Is.Not.EqualTo(5.29f));
        }

    }
}