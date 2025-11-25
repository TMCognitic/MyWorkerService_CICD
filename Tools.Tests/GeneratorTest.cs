namespace Tools.Tests
{
    public class GeneratorTest
    {
        [Fact]
        public void TestCreateGuid()
        {
            //Arrange
            Guid? guid = null;

            //Act
            guid = Generator.CreateGuid();

            //Asserts
            Assert.NotNull(guid);
            Assert.NotEqual(Guid.Empty, guid);
        }
    }
}
