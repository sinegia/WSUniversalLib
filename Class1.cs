using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSUniversalLib
{
    public  class MaterialCalculator
    {
        // Расчет количества необходимого сырья для производства
        public static int CalculateMaterials(int count, float width, float length, int productType, int materialType)
        {
            if (productType < 1 || productType > 3 || materialType < 1 || materialType > 2 || count < 0 || width < 0 || length < 0)
            {
                return -1;
            }


            double materialCoef = 0;
            double materialDefect = 0;

            switch (productType)
            {
                case 1:
                    materialCoef = 1.1;
                    break;
                case 2:
                    materialCoef = 2.5;
                    break;
                case 3:
                    materialCoef = 8.43;
                    break;
            }

            switch (materialType)
            {
                case 1:
                    materialDefect = 0.3;
                    break;
                case 2:
                    materialDefect = 0.12;
                    break;
            }

            int result = (int)((width * length * count * materialCoef * (1 + materialDefect)));

            return result;
        }
    }
}
