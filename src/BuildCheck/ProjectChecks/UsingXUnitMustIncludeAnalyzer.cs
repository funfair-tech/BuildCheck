﻿using Microsoft.Extensions.Logging;

namespace BuildCheck.ProjectChecks
{
    public sealed class UsingXUnitMustIncludeAnalyzer : HasAppropriateAnalysisPackages
    {
        public UsingXUnitMustIncludeAnalyzer(ILogger<NoPreReleaseNuGetPackages> logger)
            : base(detectPackageId: @"xunit", mustIncludePackageId: @"xunit.analyzers", logger)
        {
        }
    }
}