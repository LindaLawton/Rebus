﻿using System.Threading.Tasks;

namespace Rebus.Config
{
    public class Options
    {
        public Options()
        {
            NumberOfWorkers = 10;
            MaxParallelism = 10;
        }

        /// <summary>
        /// Configures the number of workers
        /// </summary>
        public int NumberOfWorkers { get; set; }

        /// <summary>
        /// Configures how many outstanding continuations (i.e. async <see cref="Task"/>-based parallel operations) we
        /// allow per worker
        /// </summary>
        public int MaxParallelism { get; set; }
    }
}