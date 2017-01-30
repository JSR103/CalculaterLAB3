using System;
using System.Collections.Generic;
using System.Text;

namespace CalculaterLAB3
{
    class CalculaterMethods
    {
        public static string PLUS(string gMiles, string mGallons)
        {
            string results = gMiles + mGallons;
            return results;
        }

        public static double SUBTRACT(double gMiles, double mGallons)
        {
            double results = gMiles - mGallons;
            return results;
        }

        public static double MULTIPLY(double gMiles, double mGallons)
        {
            double results = gMiles * mGallons;
            return results;
        }

        public static double DIVIDE(double gMiles, double mGallons)
        {
            double results = gMiles / mGallons;
            return results;
        }
    }
}
