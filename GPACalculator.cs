using System;
using System.Collections.Generic;
using System.Linq;

namespace GPACalculator
{
    internal class GPACalculator
    {
        private List<double> gpaList = new List<double>();

        public void AddGPA(double gpa)
        {
            gpaList.Add(gpa);
        }

        public double GetAverageGPA()
        {
            return gpaList.Count > 0 ? gpaList.Average() : 0.00;
        }

        public double GetMaxGPA()
        {
            return gpaList.Count > 0 ? gpaList.Max() : 0.00;
        }

        // คืนค่า GPA ต่ำสุด
        public double GetMinGPA()
        {
            return gpaList.Count > 0 ? gpaList.Min() : 0.00;
        }

        // คืนค่าจำนวนคนที่กรอก GPA
        public int GetTotalStudents()
        {
            return gpaList.Count;
        }
    }
}
