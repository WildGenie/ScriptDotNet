﻿// -----------------------------------------------------------------------
// <copyright file="MapFigure.cs" company="ScriptDotNet">
// Copyright (c) ScriptDotNet. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// -----------------------------------------------------------------------

using System.Runtime.InteropServices;

namespace ScriptDotNet
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct MapFigure
    {
        public FigureKind Kind;
        public FigureCoord Coord;
        public int X1;
        public int Y1;
        public int X2;
        public int Y2;
        public System.Drawing.Color BrushColor;
        public uint BrushStyle;
        public System.Drawing.Color Color;
        public string Text;
    }
}
