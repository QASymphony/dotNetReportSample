using NUnit.Framework;
using NUnitReportSample.Library;
using System;
using System.Diagnostics;
using System.Threading;

namespace NUnitReportSample.Test
{
    [TestFixture]
    public class BrowserTest
    {
        [Test]
        public void ShouldGoToGoogleSite()
        {
            const string PROCESS_NAME = "IExplore.exe";
            const int SLEEP = 3000;

            Process process = Process.Start(PROCESS_NAME);
            Process[] pname = Process.GetProcessesByName("IExplore");
            Assert.That(pname.Length != 0);
            Thread.Sleep(SLEEP);
            process.Kill();
        }
    }
}
