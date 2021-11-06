﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TagsCloudVisualization
{
    public static class PointExtensions
    {
        public static double DistanceTo(this Point sourcePoint, Point destinationPoint)
        {
            var dx = sourcePoint.X - destinationPoint.X;
            var dy = sourcePoint.Y - destinationPoint.Y;
            return Math.Sqrt(dx * dx + dy * dy);
        }
    }
}
