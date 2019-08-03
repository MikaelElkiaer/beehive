﻿using System.Threading;

namespace beehive.Config
{
    public class ProgramContext
    {
        public ProgramContext(CancellationTokenSource cancellationTokenSource)
        {
            CancellationTokenSource = cancellationTokenSource;
        }

        public CancellationTokenSource CancellationTokenSource { get; }
    }
}
