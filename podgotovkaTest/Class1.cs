using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace podgotovkaTest
{
    public class Class1
    {
        public static int GetQuantity(int productType, int materialType, int count, float width, float length)
        {
            List<double> coefficientProductType = new List<double> { 1.1, 2.5, 8.43 };
            List<double> marriageMaterialType = new List<double> { 0.3, 0.12 };
            if (productType != 1 && productType != 2 && productType != 3) 
            {
                return -1;
            }
            if (materialType != 1 && materialType != 2) 
            {
                return -1;
            }
            if (width < 0 || length < 0 || count < 0) 
            {
                return -1;
            }
            double resultWithoutMarriage = count * coefficientProductType[productType - 1] * width * length; 
            int result = (int)Math.Ceiling(resultWithoutMarriage + (resultWithoutMarriage * marriageMaterialType[materialType - 1] / 100));
            if (result == -2147483648) 
            {
                return -1;
            }
            return result;
        }
    }
}
