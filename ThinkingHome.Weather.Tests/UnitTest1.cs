using System.Text.Json;
using ThinkingHome.Weather.Api.Model.Converters;
using ThinkingHome.Weather.Api.Model.Enum;

namespace ThinkingHome.Weather.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string json = "0.5";
            var response = JsonSerializer.Deserialize<Cloudness>(json);
            var json2 = JsonSerializer.Serialize(response);
            Console.WriteLine(response);
            Console.WriteLine(json2);
        }
    }
}