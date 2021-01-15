using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kinect1
{
    public class Vector
    {
        public CoordenadaDeVector Punto1 { get; }
        public CoordenadaDeVector Punto2 { get; }

        public Vector(CoordenadaDeVector punto1, CoordenadaDeVector punto2)
        {
            Punto1 = punto1;
            Punto2 = punto2;
        }
    }

    public class CoordenadaDeVector
    {
        public float X { get; }
        public float Y { get; }

        public CoordenadaDeVector(float x, float y)
        {
            X = x;
            Y = y;
        }
    }
}
