﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenderButton : MonoBehaviour {

	void OnMouseDown()
	{
		var buttons = FindObjectsOfType<DefenderButton>();

		foreach (DefenderButton button in buttons)
		{
			button.GetComponent<SpriteRenderer>().color = new Color32(69, 69, 69, 255);
		}

		GetComponent<SpriteRenderer>().color = Color.white;
	}

}
