namespace Creations.Core.Tests
{
    [TestClass]
    public class CreationTests
    {
        [TestMethod]
        public void TestCreationIsHere()
        {
            var creation = new Creation();
            Assert.Equals(0, creation.Id);
        }
    }
}