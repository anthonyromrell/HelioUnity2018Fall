using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Transfer : MonoBehaviour
{
	public FloatData TotalMoney;
	public Text MoneyLabel;
	
	void Update ()
	{
		MoneyLabel.text = TotalMoney.Value.ToString();
	}
}