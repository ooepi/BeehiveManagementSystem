﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeehiveManagementSystem
{
    class Bee
    {
        public Bee(string job)
        {
            Job = job;
        }

        public string Job { get; private set; }

        virtual public float CostPerShift { get;}

        virtual public void WorkTheNextShift()
        {
            if (HoneyVault.ConsumeHoney(CostPerShift))
            {
                DoJob();
            }
        }

        protected virtual void DoJob()
        {
            //Subclass overrides this
        }
    }
}
