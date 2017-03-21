﻿// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using Microsoft.EntityFrameworkCore.Tools.Properties;
using Microsoft.Extensions.CommandLineUtils;

namespace Microsoft.EntityFrameworkCore.Tools.Commands
{
    internal class DbContextCommand : HelpCommandBase
    {
        public override void Configure(CommandLineApplication command)
        {
            command.Description = Resources.DbContextDescription;

            command.Command("info", new DbContextInfoCommand().Configure);
            command.Command("list", new DbContextListCommand().Configure);
            command.Command("scaffold", new DbContextScaffoldCommand().Configure);

            base.Configure(command);
        }
    }
}
