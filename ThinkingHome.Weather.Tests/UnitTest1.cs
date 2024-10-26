using System.Text.Json;
using ThinkingHome.Weather.Api.Model.Enum;

namespace ThinkingHome.Weather.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string json = "\"summer\"";
            var response = JsonSerializer.Deserialize<Season>(json);
            Console.WriteLine(response);
        }
    }
}