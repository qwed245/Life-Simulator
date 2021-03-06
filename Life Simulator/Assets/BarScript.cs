﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarScript : MonoBehaviour {

	float fillAmout;

	[SerializeField]
	float lerpSpeed;

	[SerializeField]
	Image content;

	public float MaxValue { get; set; }
	public float Value {
		set {
			fillAmout = Map (value, 0, MaxValue, 0, 1);
		}
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		HandleBar ();
	}

	void HandleBar()
	{
		if (fillAmout != content.fillAmount) {
			content.fillAmount = Mathf.Lerp (content.fillAmount, fillAmout, Time.deltaTime * lerpSpeed);
		}
	}

	float Map(float value, float inMin, float inMax, float outMin, float outMax)
	{
		return (value - inMin) * (outMax - outMin) / (inMax - inMin) + outMin;
	}
}
