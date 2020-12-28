﻿// -----------------------------------------------------------------------
// <copyright file="ServerEventArgs.cs" company="ScriptDotNet">
// Copyright (c) ScriptDotNet. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// -----------------------------------------------------------------------

using System;

namespace ScriptDotNet.Network
{
    public class ServerEventArgs : EventArgs
    {
        public ServerEventArgs()
        {
        }

        public ServerEventArgs(ExecEventProcData data)
        {
            Data = data;
        }

        public ExecEventProcData Data { get; set; }
    }
}
