﻿using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Text;

namespace GeneratorV2.Overloading
{
    public interface ILayer
    {
        void WriteLayer(IndentedTextWriter writer, string methodName);
    }
}