﻿using System;

namespace ClangSharpPInvokeGenerator
{
    internal sealed class ConfigurationOptions
    {
        public ConfigurationOptions(string[] options)
        {
            foreach (var option in options)
            {
                if (option.EndsWith("multi-file"))
                {
                    GenerateMultipleFiles = true;
                }

                if (option.Equals("unsafe"))
                {
                    GenerateUnsafeCode = true;
                }
            }
        }

        public string[] ExcludedFunctions { get; set; }

        public bool GenerateMultipleFiles { get; set; }

        public bool GenerateUnsafeCode { get; set; }

        public string LibraryPath { get; set; }

        public string MethodClassName { get; set; }

        public string MethodPrefixToStrip { get; set; }

        public string Namespace { get; set; }

        public string OutputLocation { get; set; }
    }
}
