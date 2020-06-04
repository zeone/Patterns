using patterns.SimpleTests;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Text;
using NUnit.Framework;
using patterns;

namespace patternsTests1.SimpleTests
{
    public class LogEntryReaderTests
    {
        //  private LogEntryReader _reader;

        //фабричный метод в тесте, используеться для того что бы можно было в самом тесте инициализировать с нужными значениями
        public static LogEntryReader CreateLogEntryReader(string content)
        {
            //Arrange
            var memoryStream = new MemoryStream();
            StreamWriter sw = new StreamWriter(memoryStream);
            sw.WriteLine(content);
            sw.Flush();
            memoryStream.Position = 0;

            ILogEntryParser logEntryParser = new SimpleLogEntryParser();
            return new LogEntryReader(memoryStream, logEntryParser);
        }

        //инициализация параметров перед запуском тестов
        //[SetUp]
        //public void SetUp()
        //{
        //    //Arrange
        //    var memoryStream = new MemoryStream();
        //    StreamWriter sw = new StreamWriter(memoryStream);
        //    sw.WriteLine("[2020.11.01][Info] test message");
        //    sw.Flush();
        //    memoryStream.Position = 0;

        //    ILogEntryParser logEntryParser = new SimpleLogEntryParser();
        //    _reader = new LogEntryReader(memoryStream, logEntryParser);
        //}

        [Test]
        public void Test_stream_With_One_Entry()
        {
            //Arrange
            var _reader = CreateLogEntryReader("some content");
            //Act
            var entries = _reader.Read().ToList();

            //Assert
            Assert.That(entries.Count, Is.EqualTo(1));
            LogEntry entry = entries.Single();
            Assert.That(entry.Date.Date, Is.EqualTo(DateTime.Now.Date));
            Assert.AreEqual(entry.Severity, 1);

        }


        [Test]
        public void Test_stream_With_One_Entry_Fixture()
        {
            //Arrange
            var _reader = new LogEntryReaderFixture().WithParser(new SimpleLogEntryParser())
                .WithStreamContent("some content")
                .LogEntryReader;
            //Act
            var entries = _reader.Read().ToList();

            //Assert
            Assert.That(entries.Count, Is.EqualTo(1));
            LogEntry entry = entries.Single();
            Assert.That(entry.Date.Date, Is.EqualTo(DateTime.Now.Date));
            Assert.AreEqual(entry.Severity, 1);

        }

        //определяеться итератор который бедт поочерезно вызывать тест с разными значениями
        [TestCaseSource("SimpleLogEntrySource")]
        public LogEntry Test_simpleLogEntry_Parse(string logEntry)
        {
            //Arrange
            var parser = new SimpleLogEntryParser();

            //Act
            LogEntry result;
            bool res = parser.TryParse("some string", out result);

            //Assert
            return result;
        }

        #region Fixture

        /// <summary>
        /// используеться строитель, если тестируемый оъект сложен, что бы тесты занимались чито етстированием и все
        /// </summary>
        internal class LogEntryReaderFixture
        {
            private ILogEntryParser _parser = new SimpleLogEntryParser();
            private readonly Lazy<LogEntryReader> _lazyCut;
            private string _streamContent;

            public LogEntryReaderFixture()
            {
                //use factory
                // _lazyCut = new Lazy<LogEntryReader>(()=>LogEntryReaderTestFactory.Create(_streamContent,_parser));
                _lazyCut = new Lazy<LogEntryReader>(() => CreateLogEntryReaderWithParser(_streamContent, _parser));
            }

            public LogEntryReaderFixture WithParser(ILogEntryParser parser)
            {
                _parser = parser;
                return this;
            }

            public LogEntryReaderFixture WithStreamContent(string streamContent)
            {
                _streamContent = streamContent;
                return this;
            }

            public LogEntryReader LogEntryReader => _lazyCut.Value;
        }

        //что бы не создавать фабрику для примера, просто обьявил метод
        static LogEntryReader CreateLogEntryReaderWithParser(string content, ILogEntryParser logEntryParser)
        {
            //Arrange
            var memoryStream = new MemoryStream();
            StreamWriter sw = new StreamWriter(memoryStream);
            sw.WriteLine(content);
            sw.Flush();
            memoryStream.Position = 0;
            return new LogEntryReader(memoryStream, logEntryParser);
        }

        #endregion


        #region TestCase

        private static TestCaseData Entry(string entry)
        {
            return new TestCaseData(entry);
        }


        /// <summary>
        /// итератор со значениями
        /// </summary>
        /// <returns></returns>
        private static IEnumerable<TestCaseData> SimpleLogEntrySource()
        {
            //entry: значение которое передаеться в тест
            //returns: то что возвращает тест для сравнения
            yield return
                Entry("some entry row").Returns(new LogEntry()
                { Date = DateTime.Now.Date, Message = "SimpleLogEntry", Severity = 1 });

            yield return Entry("someMesage").Returns(new LogEntry()
            { Date = DateTime.Now, Message = "someMessage", Severity = 2 });


        }
        #endregion
    }
}