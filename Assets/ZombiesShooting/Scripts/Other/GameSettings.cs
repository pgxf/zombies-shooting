using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine;
using System.Collections.Generic;

/* Description 

This global setting behavior of the project. (Asset/Resources/Settings) 
variables of the script used in many scripts play. Singolton ideal for such an implementation.
Singolton ideal for such an implementation.

Description */
[CreateAssetMenu(menuName = "MySubMenu/Create GameSettings")]
public class GameSettings : ScriptableObject
{
	public static GameSettings instance;

	public static GameSettings In
	{
		get
		{
			if (instance == null)
			{
				instance = Resources.Load("Settings") as GameSettings;
				instance.positions.Add(new Vector3(1, 0, -1));
				instance.positions.Add(new Vector3(8, -10, -1));
				instance.positions.Add(new Vector3(-16, -9, -1));
				instance.positions.Add(new Vector3(-16, -1, -1));
			}
			return instance;
		}
	}

	public byte maxPlayer = 4;

	public List<Vector3> positions = new List<Vector3>();
}