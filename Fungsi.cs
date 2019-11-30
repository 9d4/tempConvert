using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tempConvert
{
    class Fungsi
    {
        //=====
        //to Fahrenheit
        //from C
        public decimal CToF(decimal value)
        {
            decimal result = (value * 1.8M) + 32;
            return result;
        }

        //from R
        public decimal RToF(decimal value)
        {
            return (value * 2.25M) + 32;
        }

        //from K
        public decimal KToF(decimal value)
        {
            return (value * 1.8M) - 459.67M;
        }

        //===========
        //to Celcius
        //from Fahrn
        public decimal FToC(decimal value)
        {
            return (value - 32M) * (5M / 9M);
        }

        //from Reamur
        public decimal RToC(decimal value)
        {
            return value * (5M / 4M);
        }

        //from kelvin
        public decimal KToC(decimal value)
        {
            return value - 273.15M;
        }

        //==========   
        //to Reamur
        //from celcius
        public decimal CToR(decimal value)
        {
            return value * (4M / 5M);
        }

        //from Fahrn
        public decimal FToR(decimal value)
        {
            return (value - 32) * (4M / 9M);
        }

        //from Kelvin
        public decimal KToR(decimal value)
        {
            return (value - 273.15M) * (4M / 5M);
        }

        //=========
        //to Kelvin
        //from Celcius
        public decimal CToK(decimal value)
        {
            return value + 273.15M;
        }
    }
}
