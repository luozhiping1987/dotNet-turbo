﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qoollo.Turbo.Queues.DiskQueueComponents
{
    public abstract class DiskQueueSegmentFactory<T>
    {
        public virtual int SegmentCapacity { get { return -1; } }
        public abstract DiskQueueSegment<T> CreateSegment(string path, long number);
        public abstract DiskQueueSegment<T>[] DiscoverSegments(string path);
    }
}
