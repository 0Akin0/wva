namespace wvaUnitTest {
    public class Tests {
        ClothingSuggestion suggester;
        WeatherData data;

        [SetUp]
        public void Setup() {
            data = new WeatherData();
            suggester = new ClothingSuggestion(data);
        }

        [Test]
        public void TestRainyWeather() {
            data.Status = WeatherStatus.Rain;
            var result = suggester.SuggestClothing();
            Assert.IsTrue(result.Contains("umbrella"));
        }

        [Test]
        public void TestRainyAndWindyWeather() {
            data.Status = WeatherStatus.Rain;
            data.WindStrength = 100;
            var result = suggester.SuggestClothing();
            Assert.IsTrue(result.Contains("raincoat"));
            Assert.IsFalse(result.Contains("umbrella"));
        }

        [Test]
        public void TestHotWeather() {
            data.Temperature = 100;
            var result = suggester.SuggestClothing();
            Assert.IsTrue(result.Contains("t-shirt"));
            Assert.IsFalse(result.Contains("sweater"));
        }

        [Test]
        public void TestColdWeather() {
            data.Temperature = -100;
            var result = suggester.SuggestClothing();
            Assert.IsTrue(result.Contains("sweater"));
            Assert.IsFalse(result.Contains("t-shirt"));
        }


    }
}