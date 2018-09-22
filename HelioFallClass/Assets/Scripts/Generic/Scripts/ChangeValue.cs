using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]
public class ChangeValue : ScriptableObject
{
	public FloatData DataObject;
	
	public void AddValue(FloatData data)
	{
		DataObject.Value += data.Value;
	}
	
	public void SubtractValue(FloatData data)
	{
		DataObject.Value -= data.Value;
	}
}