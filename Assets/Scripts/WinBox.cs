﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinBox : MonoBehaviour
{
	private void OnTriggerEnter(Collider other)
	{
		GameObject.Find("FPSController").SendMessage("Finish");
	}
}
