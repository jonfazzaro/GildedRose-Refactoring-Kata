namespace GildedRoseTests {
    using ApprovalTests;
    using ApprovalTests.Reporters;
    using GildedRose;
    using NUnit.Framework;
    using System;
    using System.IO;
    using System.Text;

    [TestFixture]
    [UseReporter(typeof(DiffReporter))]
    public class ApprovalTest {
        [Test]
        public void ThirtyDays() {
            StringBuilder fakeoutput = new StringBuilder();
            Console.SetOut(new StringWriter(fakeoutput));
            Console.SetIn(new StringReader("a\n"));

            Program.Main(new string[] { });
            String output = fakeoutput.ToString();
            Approvals.Verify(output);
        }
    }

}