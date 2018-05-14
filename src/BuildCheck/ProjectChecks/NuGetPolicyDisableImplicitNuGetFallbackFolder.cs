﻿using System;
using System.Xml;
using Microsoft.Extensions.Logging;

namespace BuildCheck.ProjectChecks
{
    public class NuGetPolicyDisableImplicitNuGetFallbackFolder : IProjectCheck
    {
        private readonly ILogger<ErrorPolicyWarningAsErrors> _logger;

        public NuGetPolicyDisableImplicitNuGetFallbackFolder(
            ILogger<ErrorPolicyWarningAsErrors> logger)
        {
            this._logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public void Check(string projectName, XmlDocument project)
        {
            ProjectValueHelpers.CheckValue(projectName, project, @"DisableImplicitNuGetFallbackFolder", "true", this._logger);
        }
    }
}