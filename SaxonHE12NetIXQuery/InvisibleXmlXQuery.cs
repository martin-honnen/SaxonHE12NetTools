using net.sf.saxon;
using org.nineml.coffeesacks;
using System.Diagnostics;
using System.Reflection;

namespace SaxonHE12NetIXQuery;

public class InvisibleXmlXQuery : Query
{
    static void Main(string[] args)
    {
        Console.WriteLine($"SaxonHENetIXQuery 12.8.1 on .NET {Environment.Version} {Environment.OSVersion}");

        var stopWatch = new Stopwatch();
        stopWatch.Start();

        //ikvm.runtime.Startup.addBootClassPathAssembly(Assembly.Load("org.xmlresolver.xmlresolver"));
        //ikvm.runtime.Startup.addBootClassPathAssembly(Assembly.Load("org.xmlresolver.xmlresolver_data"));
        //ikvm.runtime.Startup.addBootClassPathAssembly(Assembly.Load("coffeegrinder"));
        //ikvm.runtime.Startup.addBootClassPathAssembly(Assembly.Load("coffeefilter"));


        var invisbleXmlXQuery = new InvisibleXmlXQuery();

        invisbleXmlXQuery.doQuery(args, "IXQuery");

        stopWatch.Stop();

        Console.WriteLine($"Elapsed time: {stopWatch.Elapsed}");
    }

    protected override void initializeConfiguration(Configuration config)
    {
        var coffeeSacksRegister = new RegisterCoffeeSacks();

        coffeeSacksRegister.initialize(config);
    }
}
