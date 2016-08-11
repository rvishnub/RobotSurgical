using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotSurgical
{
    public class Robot
    {
        public string robot;
        public string robotName;
        public double energy;
        string function;
        string problem;
        string reaction;
        string motion;
        public Robot()
        {
            this.robot = "";
            this.robotName = "";
            this.energy = 0;
        }

        public string GetRobotFunction()
        {
            return function;
            //anaesthesiologist, orthopedic surgeon, vascular surgeon, brain surgeon
        }

        public double GetEnergyLevel()
        {
            return energy;
        }

        public void RechargeBattery()
        {
            energy = 100;
            //joules
        }

        public void Move()
        {
            if (energy == 0)
            {
                motion = "Out";
            }
            else
            { 
                motion = "In";
            }
        }

    }
}