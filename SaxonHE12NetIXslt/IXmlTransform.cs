﻿using System.Diagnostics;
using net.sf.saxon;
using org.nineml.coffeesacks;

namespace SaxonHE12NetIXslt;

public class IXmlTransform : Transform
{
    static void Main(string[] args)
    {
        Console.WriteLine($"SaxonHENetIXslt 12.1.0 on .NET {Environment.Version} {Environment.OSVersion}");
        var stopWatch = new Stopwatch();
        stopWatch.Start();

        //ikvm.runtime.Startup.addBootClassPathAssembly(Assembly.Load("org.xmlresolver.xmlresolver"));
        //ikvm.runtime.Startup.addBootClassPathAssembly(Assembly.Load("org.xmlresolver.xmlresolver_data"));

        var invisibleXmlTransformer = new IXmlTransform();

        invisibleXmlTransformer.doTransform(args);

        stopWatch.Stop();

        Console.WriteLine($"Elapsed time: {stopWatch.Elapsed}");
    }

    protected override void initializeConfiguration(Configuration config)
    {
        var coffeeSacksRegister = new RegisterCoffeeSacks();

        coffeeSacksRegister.initialize(config);
    }
}
