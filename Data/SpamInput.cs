﻿using Microsoft.ML.Data;

namespace AplicacionMachineLearning.Data
{
    public class SpamInput
    {
        [LoadColumn(0)]
        public string Label { get; set; }
        [LoadColumn(1)]
        public string Message { get; set; }
    }
}
