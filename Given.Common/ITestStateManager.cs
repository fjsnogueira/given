﻿using System;
using System.Reflection;

namespace Given.Common
{
    public interface ITestStateManager
    {
        void AddGiven(string text, Delegate method);
        void AddWhen(string text, when method);
        void AddThen(string text, MethodInfo method);
        void SetThenState(string then, TestState state, string message);
        void WriteSpecification(Action<string, object[]> consoleAction = null);
    }
}