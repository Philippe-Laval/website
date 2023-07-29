﻿// Copyright (c) 2023 .NET Foundation and Contributors. All rights reserved.
// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for full license information.

await Bootstrapper
        .Factory
        .CreateDocs(args)
        .ConfigureLinks(args)
        .AddSetting(MarkdownKeys.MarkdownExtensions, "bootstrap")
        .AddSourceFiles(
            "dynamicdata".WithSourceFilter(),
            "splat".WithSourceFilter("*.Drawing"),
            "reactiveui".WithSourceFilter("Benchmarks", "*.Test", "*.LeakTests", "*.TestRunner", "*.Uwp"),
            "akavache".WithSourceFilter(),
            "punchclock".WithSourceFilter(),
            "fusillade".WithSourceFilter())
        .RunAsync();
