﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CycloidGenerator.Solvers
{
    public class SolverPoint
    {
        public static readonly SolverPoint Default = new SolverPoint(double.MinValue, double.MinValue);

        public double X;
        public double Y;

        public SolverPoint()
        { 
        
        }

        public SolverPoint(double x, double y)
        {
            X = x;
            Y = y;
        }

        // def toRect(r, a):
        //     return r*math.cos(a), r*math.sin(a)
        public static SolverPoint FromPolar(double r, double angle)
        {
            return new SolverPoint(r * Math.Cos(angle), r * Math.Sin(angle));
        }

        public override string ToString()
        {
            return string.Format("({0:0.0000}, {1:0.0000})", X, Y);
        }
    }


    public struct SolverPolar
    {
        public double D;
        public double Angle;

        public SolverPolar(double d, double angle)
        {
            D = d;
            Angle = angle;
        }

        // def toPolar(x, y):
        //     return (x**2 + y**2)**0.5, math.atan2(y, x)
        public static SolverPolar FromRect(double x, double y)
        {
            return new SolverPolar(Math.Sqrt(x * x + y * y), Math.Atan2(y, x));
        }
    }
}
