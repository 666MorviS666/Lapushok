using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSUniversalLib
{
    public class Calculation

    {
        public int GetQuantityForProduct(int productType, int materialType, int count, float width, float length)
        {

            int prType = productType;
            int maType = materialType;
            int cou = count;
            float wid = width;
            float le = length;

            if (prType == 1 && maType == 1)
            {
                cou = (int)(wid * le * 1.1 * 0.003);
            }
            else if (prType == 2 && maType == 1)
            {
                cou = (int)(wid * le * 2.5 * 0.003);
            }
            else if (prType == 3 && maType == 1)
            {
                cou = (int)(wid * le * 8.43 * 0.003);
            }
            else if (prType == 1 && maType == 2)
            {
                cou = (int)(wid * le * 1.1 * 0.0012);
            }
            else if (prType == 2 && maType == 2)
            {
                cou = (int)(wid * le * 2.5 * 0.0012);
            }
            else if (prType == 3 && maType == 2)
            {
                cou = (int)(wid * le * 8.43 * 0.0012);
            }
            else
            {
                cou = -1;
            }
            return cou;
        }
    }
}
