using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot
{
    internal class Program
    {
        static void Main()
        {
            GiantKillerRobotRobot robot = new GiantKillerRobotRobot();
            robot.initialize();


            robot.EyeLaserIntensity = Intensity.Kill;
            robot.Target = { Animals, Humans, Superheroes};


            Planets earth = Planets.Earth;
            while (robot.Active && earth.ContainsLife)
                if (robot.CurrentTarget.IsAlive)
                    robot.FireLaserAt(robot.CurrentTarget);
                else
                    robot.AcquireNextTarget();
        }
    }
}
