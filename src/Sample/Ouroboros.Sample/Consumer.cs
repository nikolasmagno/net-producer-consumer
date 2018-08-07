﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ouroboros.Sample
{
    class Consumer : IConsumer<int>
    {
        public string Id { get; set; }

        public void Process<T>(T item) => Console.WriteLine($"Consumer {Id} - processing item {item}");
    }
}
