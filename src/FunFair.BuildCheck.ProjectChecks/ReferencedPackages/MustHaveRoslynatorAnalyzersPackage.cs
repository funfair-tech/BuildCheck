using System.Diagnostics.CodeAnalysis;
using Microsoft.Extensions.Logging;

namespace FunFair.BuildCheck.ProjectChecks.ReferencedPackages
{
    /// <summary>
    ///     Checks that the Roslynator analyzer is installed.
    /// </summary>
    [SuppressMessage(category: "ReSharper", checkId: "ClassNeverInstantiated.Global", Justification = "Created by DI")]
    public sealed class MustHaveRoslynatorAnalyzersPackage : MustHaveAnalyzerPackage
    {
        /// <summary>
        ///     Constructor.
        /// </summary>
        /// <param name="logger">Logging.</param>
        public MustHaveRoslynatorAnalyzersPackage(ILogger<MustHaveRoslynatorAnalyzersPackage> logger)
            : base(packageId: @"Roslynator.Analyzers", logger: logger)
        {
        }
    }
}