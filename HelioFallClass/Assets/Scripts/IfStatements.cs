using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfStatements : MonoBehaviour
{

	public int A;
	public int B;
	public int C;
	
	public string Password;
	public bool OnSwitch;
	
	void Update () {
		
		if (OnSwitch)
		{
			print("The Light is on.");
		}

		if (Password == "OU812")
		{
			print("Correct Password.");
		}

		if (A + B == C)
		{
			print("A pluse B is equal to C.");
		}		
	}
}