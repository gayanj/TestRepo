using System.Diagnostics;
using System.Text;

namespace Msftlayer
{
    //this section pertains to the antivirus
    //optionally modify for use with word / uploaded resumes.
    //this is scanned currently via microsoft essential security, which is free
    //you can use norton's command line to handle this.
    public class ClAvScanner
    {
        public string Avscan(string fname)
        {
            var myProcess = new Process
                                {
                                    StartInfo =
                                        {
                                            RedirectStandardOutput = true,
                                            UseShellExecute = false,
                                            FileName =
                                                "c:\\Program Files\\Microsoft Security Client\\Antimalware\\mpcmdrun.exe",
                                            WindowStyle = ProcessWindowStyle.Minimized,
                                            Arguments = "-Scan -ScanType 3 -File " + fname
                                        }
                                };

            myProcess.Start();
            var q = new StringBuilder();
            while (!myProcess.HasExited)
            {
                q.Append(myProcess.StandardOutput.ReadToEnd());
            }

            return q.ToString();
        }
    }
}