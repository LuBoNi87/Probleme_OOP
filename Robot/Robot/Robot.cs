using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

enum Intensity
{
    Low = 5,
    Medium = 25,
    High = 50,
    Kill = 100,
}
namespace Robot
{

    internal class Robot
    {
        public int HealthRobot;
        public Intensity EyeLasserIntensity;
        public Target CurrentTarget;
        public Target[] Targets;
        public int target;
        public bool Active;
        public void Initialize()
        {
            target = 0;
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
            if ( target < Targets.Length-1 )
            CurrentTarget = Targets[++target];
            else
            {
                Active = false;
            }
        }



    }
}
