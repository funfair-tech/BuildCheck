﻿using Microsoft.Extensions.Logging;

namespace FunFair.BuildCheck.ProjectChecks
{
    // ReSharper disable once ClassNeverInstantiated.Global
    public sealed class ShouldUseFluentValidationAspNetCoreRatherThanFluentValidationPackage : ShouldUseAbstractionsPackage
    {
        /// <summary>
        ///     Constructor.
        /// </summary>
        /// <param name="logger">Logging.</param>
        public ShouldUseFluentValidationAspNetCoreRatherThanFluentValidationPackage(ILogger<ShouldUseFluentValidationAspNetCoreRatherThanFluentValidationPackage> logger)
            : base(matchPackageId: @"FluentValidation", usePackageId: @"FluentValidation.AspNetCore", logger: logger)
        {
        }
    }
}