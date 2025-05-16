using System.Diagnostics;
using System.Reflection;
using net.sf.saxon;


namespace net.liberty_development.saxontools.SaxonXQuery;
public class XQuery
{
    static void Main(string[] args)
    {
        Console.WriteLine($"SaxonHE12NetXQuery 12.7.0 on .NET {Environment.Version} {Environment.OSVersion}");
        var stopWatch = new Stopwatch();
        stopWatch.Start();

        //ikvm.runtime.Startup.addBootClassPathAssembly(Assembly.Load("org.xmlresolver.xmlresolver"));
        //ikvm.runtime.Startup.addBootClassPathAssembly(Assembly.Load("org.xmlresolver.xmlresolver_data"));

        Query.main(args);

        stopWatch.Stop();

        Console.WriteLine($"Elapsed time: {stopWatch.Elapsed}");
    }
}
