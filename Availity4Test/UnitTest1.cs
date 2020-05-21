using Availity4;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Availity4Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.IsTrue(Program.CheckBalanced("(he(l)lo)"));
            Assert.IsTrue(Program.CheckBalanced("(he)l(lo)"));
            Assert.IsFalse(Program.CheckBalanced("(hel(lo)"));
            Assert.IsFalse(Program.CheckBalanced("(he)llo)("));
            Assert.IsFalse(Program.CheckBalanced(")he)llo()("));  // balanced but still invalid
        }
    }
}
