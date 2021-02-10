using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeehiveManagementSystem
{
    class EggCare : Bee
    {

        const float CARE_PROGRESS_PER_SHIFT = 0.15f;
        const float COST_PER_SHIFT = 1.35f;

        private Queen queen;
        public EggCare(Queen queen) : base("Egg Care")
        {

        }

        protected override void DoJob()
        {
            queen.CareForEggs(CARE_PROGRESS_PER_SHIFT);
            HoneyVault.ConsumeHoney(COST_PER_SHIFT);
        }
    }
}
