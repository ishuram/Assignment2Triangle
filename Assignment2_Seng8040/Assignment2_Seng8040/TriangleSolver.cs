using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2_Seng8040
{
    public static class TriangleSolver
    {

        public static string Analyze(int side1, int side2, int side3)
        {
            string result = null;
            if ((side1 + side2 <= side3) || (side2 + side3 <= side1) || (side3 + side1 <= side2))
            {
                result = "Cannot form triangle";
            }

            else
            {
                if (side1 == side2 && side2 == side3 && side3 == side1)
                {
                    result = "A triangle is formed. This is an Equilateral Triangle";
                }

                else if (side1 == side2 || side1 == side3 || side2 == side3)
                {
                    result = "A triangle is formed. This is an Isosceles Triangle";
                }

                else if (side1 != side2 && side2 != side3 && side1 != side3)
                {
                    result = "A triangle is formed. This is a Scalene Triangle";
                }
            }
            return result;            

        }
    }
    
}
