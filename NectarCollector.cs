using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeehiveManagementSystem
{
    class NectarCollector : Bee
    {
        const float NECTAR_COLLECTED_PER_SHIFT = 33.25f;
        const float COST_PER_SHIFT = 1.95f;

        private Queen queen;
        public NectarCollector(Queen queen) : base("NectarCollector")
        {

        }

        protected override void DoJob()
        {
            HoneyVault.ConsumeHoney(COST_PER_SHIFT);
            HoneyVault.CollectNectar(NECTAR_COLLECTED_PER_SHIFT);
        }
    }
}
