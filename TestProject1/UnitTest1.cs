using Microsoft.VisualStudio.TestPlatform.TestHost;
using NUnit.Framework;
namespace TestProject1
{
    [TestFixture]
    public class Tests
    {
        [TestCase("<>")]
        [TestCase("()")]
        [TestCase("[]")]
        [TestCase("")]
        [Test]
        public void SimpleCorrect(string input)
        {
            var result = Analysis.Program.IsCorrectString(input);
            Assert.IsTrue(result);
        }


        [TestCase("<")]
        [TestCase(")")]
        [TestCase("[>")]
        [TestCase("a")]
        [Test]
        public void SimpleIncorrect(string input)
        {
            var result = Analysis.Program.IsCorrectString(input);
            Assert.IsFalse(result);
        }

        [Test]
        public void ExtraClosing()
        {
            var result = Analysis.Program.IsCorrectString("())");
            Assert.IsFalse(result);
        }

        [Test]
        public void ExtraOpening()
        {
            var result = Analysis.Program.IsCorrectString("(()");
            Assert.IsFalse(result);
        }

        [Test]
        public void WrongOrder()
        {
            var result = Analysis.Program.IsCorrectString("[(])");
            Assert.IsFalse(result);
        }
    }
}