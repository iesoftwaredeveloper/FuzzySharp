﻿using System;
using FuzzySharp.SimilarityRatio.Strategy.Generic;

namespace FuzzySharp.SimilarityRatio.Algorithm.StrategySensitive.TokenDifference
{
    public class PartialTokenDifferenceScorer : TokenDifferenceScorerBase
    {
        protected override Func<string[], string[], int> Scorer => PartialRatioStrategy<string>.Calculate;
    }
}
