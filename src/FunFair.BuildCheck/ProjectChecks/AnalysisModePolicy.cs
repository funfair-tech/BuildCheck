﻿using System;
using System.Xml;
using Microsoft.Extensions.Logging;

namespace FunFair.BuildCheck.ProjectChecks
{
    public sealed class AnalysisModePolicy : IProjectCheck
    {
        private const string EXPECTED = @"AllEnabledByDefault";

        private readonly ILogger<AnalysisModePolicy> _logger;

        public AnalysisModePolicy(ILogger<AnalysisModePolicy> logger)
        {
            this._logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        /// <inheritdoc />
        public void Check(string projectName, XmlDocument project)
        {
            ProjectValueHelpers.CheckValue(projectName: projectName, project: project, nodePresence: @"AnalysisMode", requiredValue: EXPECTED, logger: this._logger);
        }
    }
}