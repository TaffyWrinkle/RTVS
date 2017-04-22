﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

using System.Diagnostics.CodeAnalysis;
using System.Threading.Tasks;
using FluentAssertions;
using Microsoft.Common.Core.Services;
using Microsoft.Common.Core.Shell;
using Microsoft.Common.Core.Test.Fakes.Shell;
using Microsoft.R.Components.InteractiveWorkflow;
using Microsoft.R.Host.Client;
using Microsoft.R.Support.Help;
using Microsoft.R.Support.Help.Functions;
using Microsoft.R.Support.Help.Packages;
using Microsoft.R.Support.Test.Utility;
using Microsoft.UnitTests.Core.Threading;
using Microsoft.UnitTests.Core.XUnit;
using Xunit;

namespace Microsoft.R.Editor.Test.Completions {
    [ExcludeFromCodeCoverage]
    [Category.R.Completion]
    [Collection(CollectionNames.NonParallel)]
    public class PackageIndexTest : IAsyncLifetime {
        private readonly ICoreShell _coreShell;
        private readonly IRInteractiveWorkflowProvider _workflowProvider;
        private readonly IRSessionProvider _sessionProvider;

        public PackageIndexTest(IServiceContainer services) {
            _coreShell = services.GetService<ICoreShell>();
            _workflowProvider = services.GetService<IRInteractiveWorkflowProvider>();
            _sessionProvider = UIThreadHelper.Instance.Invoke(() => _workflowProvider.GetOrCreate()).RSessions;
        }
        
        public Task InitializeAsync() => _sessionProvider.TrySwitchBrokerAsync(nameof(PackageIndexTest));

        public Task DisposeAsync() => Task.CompletedTask;

        [Test]
        public async Task BuildPackageIndexTest() {
            string[] packageNames = {
                "base",
                "boot",
                "class",
                "cluster",
                "codetools",
                "compiler",
                "datasets",
                "foreign",
                "graphics",
                "grDevices",
                "grid",
                "KernSmooth",
                "lattice",
                "MASS",
                "Matrix",
                "methods",
                "mgcv",
                "nlme",
                "nnet",
                "parallel",
                "rpart",
                "spatial",
                "splines",
                "stats",
                "stats4",
                "survival",
                "tcltk",
                "tools",
                "translations",
                "utils",
             };

            IPackageIndex packageIndex;
            using (var host = new IntelliSenseRSession(_coreShell, _workflowProvider)) {
                await host.StartSessionAsync();
                var functionIndex = new FunctionIndex(_coreShell, null, host);
                packageIndex = new PackageIndex(_workflowProvider, _coreShell, host, functionIndex);
                await packageIndex.BuildIndexAsync();
            }

            foreach (var name in packageNames) {
                IPackageInfo pi = await packageIndex.GetPackageInfoAsync(name);
                pi.Should().NotBeNull();
                pi.Name.Should().Be(name);
            }
        }

        [Test]
        public async Task PackageDescriptionTest() {
            PackageIndex packageIndex;
            using (var host = new IntelliSenseRSession(_coreShell, _workflowProvider)) {
                await host.StartSessionAsync();
                var functionIndex = new FunctionIndex(_coreShell, null, host);
                packageIndex = new PackageIndex(_workflowProvider, _coreShell, host, functionIndex);
                await packageIndex.BuildIndexAsync();
            }
            IPackageInfo pi = await packageIndex.GetPackageInfoAsync("base");
            pi.Description.Should().Be("Base R functions.");
        }
    }
}
