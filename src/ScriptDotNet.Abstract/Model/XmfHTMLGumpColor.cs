﻿// -----------------------------------------------------------------------
// <copyright file="XmfHTMLGumpColor.cs" company="ScriptDotNet">
// Copyright (c) ScriptDotNet. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// -----------------------------------------------------------------------

using System.Runtime.InteropServices;

namespace ScriptDotNet
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct XmfHTMLGumpColor
    {
        public int X;
        public int Y;
        public int Width;
        public int Height;
        public uint ClilocId;
        public int Background;
        public int Scrollbar;
        public int Hue;
        public int Page;
        public int ElemNum;
    }
}
