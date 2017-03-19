using System;

namespace Billiards
{
	public static class BilliardsTask
	{
		public static double BounceWall(double directionRadians, double wallInclinationRadians)
		{
            wallInclinationRadians += 90;
            directionRadians += 180;
		    double res = (directionRadians +(wallInclinationRadians - directionRadians)*2 + 360 * 5) % 360;
            if (res > 180)
                res -= 360;
            return res;
		}
	}
}