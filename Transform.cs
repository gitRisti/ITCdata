﻿using System.Collections.Generic;

namespace ITCdata
{
    public struct Transform
    {
        public string title;
        public List<double> heatRate;
        public List<double> subRemaining;
        public int indexMax;
        public int iniDelay;

        public Transform(string name, int maxValueIndex, int iDelay, List<double> subR, List<double> heatR)
        {
            title = name;
            indexMax = maxValueIndex;
            iniDelay = iDelay;
            heatRate = new List<double>(heatR);
            subRemaining = new List<double>(subR);
        }

    }
}
