using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeehiveManagementSystem
{
    static class HoneyVault
    {
        const float NECTAR_CONVERSION_RATIO = 0.19f;
        const float LOW_LEVEL_WARNING = 10f;

        static private float honey = 25f;
        static private float nectar = 100f;

        public static void ConvertNectarToHoney(float amount)
        {
            if (amount >= nectar){ amount = nectar; }
                
            nectar -= amount;
            honey += amount * NECTAR_CONVERSION_RATIO;
        }

        public static bool ConsumeHoney(float amount)
        {
            if (amount <= honey)
            {
                honey -= amount;
                return true;
            }
            return false;
        }

        public static void CollectNectar(float amount)
        {
            if (amount > 0f)
            {
                nectar += amount;
            }
        }

        public static string StatusReport 
        {
            get
            {
                string honeyWarning = "";
                string nectarWarning = "";
                if (honey < LOW_LEVEL_WARNING) { honeyWarning = "\nLOW HONEY - ADD A HONEY MANUFACTURER"; }
                if (nectar < LOW_LEVEL_WARNING) { nectarWarning = "\nLOW NECTAR - ADD A HONEY MANUFACTURER"; }


                return $"Honey: {honey} {honeyWarning} \nNectar: {nectar} {nectarWarning}";
            }
                
        }
    }
}
