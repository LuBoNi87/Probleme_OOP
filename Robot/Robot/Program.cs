using System;

namespace Robot
{
    internal class Program
    {
        static void Main()
        {
            Robot robot = new();
            robot.Initialize();
            robot.EyeLasserIntensity = Intensity.Kill;
            robot.Targets = new Target[] { new Animals(), new SuperHeroes(), new Humans() };
            robot.CurrentTarget = robot.Targets[0];
            Planets earth = new Earth();
            while ( robot.Active && earth.ContainsLife())
            {
                if (robot.CurrentTarget.Alive())
                {
                    robot.FireLaserAt(robot.CurrentTarget);
                }
                else
                    robot.AcquireNextTarget();
            }
            Console.WriteLine("All life has been destroyed");
        }
    }
}
