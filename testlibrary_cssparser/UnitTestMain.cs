using cssParser;

namespace testlibrary_cssparser
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {

            String FilePath = "main.css";
            modelCSSFile mCSSFile = cssParser.parser.parseFile("main.css", FilePath);
            modelCSS mCSS = cssParser.parser.parseCSS(mCSSFile);

        }

        [Test]
        public void TestMain()
        {
            Assert.Pass();
        }
    }
}