using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeehiveManagementSystem
{
    class HoneyManufacturer : Bee
    {
        const float NECTAR_PROCESSED_PER_SHIFT = 33.15f;
        const float COST_PER_SHIFT = 1.7f;

        private Queen queen;
        public HoneyManufacturer(Queen queen) : base("HoneyManufacturer")
        {

        }

        protected override void DoJob()
        {
            HoneyVault.ConvertNectarToHoney(NECTAR_PROCESSED_PER_SHIFT);
            HoneyVault.ConsumeHoney(COST_PER_SHIFT);
        }
    }
}
