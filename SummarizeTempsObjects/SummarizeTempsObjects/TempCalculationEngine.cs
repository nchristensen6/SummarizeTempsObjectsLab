using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace SummarizeTempsObjects
{
    public class TempCalculationEngine
    {
        List<int> _temperatures;
        public TempCalculationEngine(List<int> temperatures)
        {
            _temperatures = temperatures;
        }

        public int AverageTemperature()
        {
            // add logic to calculate the average
            int AverageTemperature = 0;
                foreach (int element in _temperatures)
            {
                AverageTemperature = AverageTemperature + element; 
            }

            return AverageTemperature / _temperatures.Count;
        }

        public int TempsAboveThreshold(int threshold)
        {
            // add logic to calculate temps above the threshold
            int HighTemps=0;
            foreach( int element in _temperatures)
            {
                if (element > threshold) ;
                {
                    count++;
                }
            }
            return count; // <-- Replace this with the number
        }

        public int TempsBelowThreshold(int threshold)
        {
            int count = 0;
            foreach( int element in _temperatures)
            {
               if (element < threshold)
                {
                    count++;
                }
            }

            return count; // <-- Replace this with the number
        }

        public int TempsAtThreshold(int threshold)
        {
            // add logic to calculate and return temps at the threshold
            return 0; // <-- Replace this with the number
        }

        public int NumberOfTemperatures()
        {
            // add logic to return the number of temparature readings
            return _temperatures.Count ; // <-- Replace this with the number
        }
    }
}
