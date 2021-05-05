using System;
using UnityEngine;
using System.IO;
using System.Reflection;
namespace BDMk22Plugin
{
	public static class Utils
	{

		public static Vector2 RotateAroundPoint(Vector2 input, Vector2 pivotPoint, float angle)
		{
			Vector2 relVector = input-pivotPoint;
			relVector = Quaternion.AngleAxis(angle, Vector3.forward) * relVector;
			return pivotPoint+relVector;
		}


		public static float GetRadarAltitude(Vessel vessel)
		{
			float radarAlt = Mathf.Clamp((float)(vessel.mainBody.GetAltitude(vessel.CoM)-vessel.terrainAltitude), 0, (float)vessel.altitude);
			return radarAlt;
		}

	}
}

