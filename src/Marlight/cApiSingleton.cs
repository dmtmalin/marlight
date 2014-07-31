using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marlight
{
    public class cApiSingleton : cMarlightAPI
    {
        private static cApiSingleton instance;

        private cApiSingleton() { }

        public static cApiSingleton Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new cApiSingleton();
                }
                return instance;
            }
        }
    }
} 