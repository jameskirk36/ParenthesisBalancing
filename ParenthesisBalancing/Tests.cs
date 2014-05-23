
using NUnit.Framework;

namespace ParenthesisBalancing
{
    [TestFixture]
    public class Tests
    {
        /*
         * Remember the rules:
         *      No for loops
         *      No LINQ
         *      All variables must be declared within the scope of IsBalanced, (i.e no static variables or class members)
         */

        [Test]
        public void CorrectlyPairedNestedShouldReturnTrue()
        {
            Assert.True(Balancer.IsBalanced("(if (zero? x) max (/ 1 x))"));
        }
     
        [Test]
        public void CorrectlyPairedSequenceShouldReturnTrue()
        {
            Assert.True(Balancer.IsBalanced("I told him (that it’s not yet done). (But he wasn’t listening)"));
        }
        [Test]
        public void OneSingleParenthesisShouldReturnFalse()
        {
            Assert.False(Balancer.IsBalanced(":-)"));
        }
        [Test]
        public void SimplyCountingParenthesisIsNotEnough()
        {
            Assert.False(Balancer.IsBalanced("())("));
        }
    }
}
