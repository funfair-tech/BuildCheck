﻿using System;
using System.Diagnostics.CodeAnalysis;
using System.Xml;
using FunFair.BuildCheck.ProjectChecks.Helpers;
using Microsoft.Extensions.Logging;

namespace FunFair.BuildCheck.ProjectChecks
{
    /// <summary>
    ///     Checks that the .net analyzers are enabled appropriately.
    /// </summary>
    [SuppressMessage(category: "ReSharper", checkId: "ClassNeverInstantiated.Global", Justification = "Created by DI")]
    public sealed class EnableNetAnalyzersPolicy : IProjectCheck
    {
        private const string EXPECTED = @"true";

        private readonly ILogger<EnableNetAnalyzersPolicy> _logger;

        /// <summary>
        ///     Constructor.
        /// </summary>
        /// <param name="logger">Logging.</param>
        public EnableNetAnalyzersPolicy(ILogger<EnableNetAnalyzersPolicy> logger)
        {
            this._logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        /// <inheritdoc />
        public void Check(string projectName, string projectFolder, XmlDocument project)
        {
            ProjectValueHelpers.CheckValue(projectName: projectName, project: project, nodePresence: @"EnableNETAnalyzers", requiredValue: EXPECTED, logger: this._logger);
        }
    }
}