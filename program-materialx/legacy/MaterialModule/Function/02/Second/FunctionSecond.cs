﻿using Core;

namespace Core
{
    using System;

    public partial class FunctionSecond
    {
        public FunctionTwenty Function;

        public FunctionSecond(FunctionTwenty function)
        {
            this.Function = function;

            return;
        }

        ~FunctionSecond()
        {
            return;
        }
    }
}
