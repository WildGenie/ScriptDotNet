﻿// -----------------------------------------------------------------------
// <copyright file="RadioButton.cs" company="ScriptDotNet">
// Copyright (c) ScriptDotNet. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// -----------------------------------------------------------------------

using System.Runtime.InteropServices;

namespace ScriptDotNet
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct RadioButton
    {
        public int X;
        public int Y;
        public int ReleasedId;
        public int PressedId;
        public int Status;
        public int ReturnValue;
        public int Page;
        public int ElemNum;
    }
}