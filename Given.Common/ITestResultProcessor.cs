﻿using System.Collections.Generic;

namespace Given.Common
{
    public interface ITestResultProcessor
    {
        void Process(IEnumerable<Story> testResults);
    }
}