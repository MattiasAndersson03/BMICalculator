using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    class BMICalculator
    {
        private double height;
        private double weight;

        private UnitTypes unit;

        public BMICalculator()
        {            
            unit = UnitTypes.Metric;
        }

        #region Setters and Getters
        public double GetHeight()
        {
            return height;
        }
        public void SetHeight(double height) 
        { 
            if (height >= 0.0) 
                this.height = height;
        }
        public double GetWeight() 
        { 
            return weight;
        }
        public void SetWeight(double weight) 
        { 
            if (weight >= 0)
                this.weight = weight;
        }
        public UnitTypes GetUnit() 
        { 
            return unit;
        }       
        public void SetUnit(UnitTypes unit)
        {
            this.unit = unit;
        }
        #endregion

        // Calculates out the bmi value from the inputs from the gui
        public double CalculateBMI()
        {
            double bmivalue = 0.0;
            double factor = 1.0; 

            if (unit == UnitTypes.Imperial) 
            {
                factor = 703.0;
            }

            bmivalue = factor * weight / (height * height);

            return bmivalue;
        }

        // Uses the bmi value to get the weight category
        public string BmiWeightCategory()
        {
            double bmi = CalculateBMI();
            string stringout = string.Empty;

            if (bmi < 18.5)
                stringout = "Underweight";
            else if (bmi <= 24.9)
                stringout = "Normal Weight";
            else if (bmi <= 29.9)
                stringout = "Overweight (pre-obesity )";
            else if (bmi <= 34.9)
                stringout = "Overweight (Obesity class I)";
            else if (bmi <= 39.9)
                stringout = "Overweight (Obesity class II)";
            else if (bmi >= 40)
                stringout = "Overweight (Obesity class III)";

            return stringout;
        }

        
    }
}
