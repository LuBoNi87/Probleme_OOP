using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

enum Intensity
{
    Low = 10,
    Medium = 20,
    High = 30,
    Kill = 40,
}
namespace Robot
{

    internal class Robot
    {
        public int HealthRobot;
        public Intensity EyeLasserIntensity;
        public Target CurrentTarget;
        public Target[] Targets;
        public int i;
        public bool Active;
        public void Initialize()
        {
            i = 0;
            HealthRobot = 100;
            Active = true;
        }

        public void FireLaserAt(Target CurrentTarget)            
        {
           
            CurrentTarget.Health -=  (int)EyeLasserIntensity;
            CurrentTarget.Health = Math.Max(0, CurrentTarget.Health);
            Console.WriteLine($"The Robot strikes {CurrentTarget} and it deals {(int)EyeLasserIntensity} damage");
            Console.WriteLine($"The {CurrentTarget} has {CurrentTarget.Health} health left");
        }
        public void AcquireNextTarget()
        {
            Console.WriteLine($"The {CurrentTarget} died");
            if ( i < Targets.Length-1 )
            CurrentTarget = Targets[++i];
            else
            {
                Active = false;
            }
        }



    }
}
