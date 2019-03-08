using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadartak_8._2._1
{
    class Static_Instanca
    {
        #region STATIC metoda
        public static bool Prost(int broj)
        {
            bool prost = true;

            for (int i = 2; i < broj; i++)
            {
                if (broj % i == 0)
                {
                    prost = false;
                    break;
                }
            }

            return prost;
        }

        #endregion

        #region Metode instance
        public  bool Savrsen(int broj)
        {
            int zbrojDjelitelja = 0;

                for (int i = 1; i < broj; i ++)
                        { 
                       if (broj % i == 0)

                {
                zbrojDjelitelja += i;
                       }
                }

        if (broj == zbrojDjelitelja)
            {
            return true;
            }
            else
            {
            return false;
            }
        }

                         #endregion



    }
}
