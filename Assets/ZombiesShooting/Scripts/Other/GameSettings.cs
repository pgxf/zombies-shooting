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
			}
			return instance;
		}
	}

	public byte maxPlayer = 2;
}