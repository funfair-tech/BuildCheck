﻿using Microsoft.Extensions.Logging;

namespace BuildCheck.ProjectChecks
{
    public sealed class UsingNSubstituteMustIncludeAnalyzer : HasAppropriateAnalysisPackages
    {
        public UsingNSubstituteMustIncludeAnalyzer(ILogger<NoPreReleaseNuGetPackages> logger)
            : base(detectPackageId: @"NSubstitute", mustIncludePackageId: @"NSubstitute.Analyzers.CSharp", logger)
        {
        }
    }
}