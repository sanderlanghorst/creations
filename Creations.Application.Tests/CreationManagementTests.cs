namespace Creations.Application.Tests
{
    [TestClass]
    public class CreationManagementTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestGetCreation_ArgumentOutOfRangeException()
        {
            var manager = new CreationManagement(null, null);
            manager.GetCreation(0);
        }
    }
}