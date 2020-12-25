﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TIMERS : MonoBehaviour 
{
	[SerializeField] private Text uiText;
	[SerializeField] private float mainTIMER;

	[SerializeField] private GameObject lose ;
	[SerializeField] private GameObject character ;

	private float timer;
	private bool canCount=true;
	private bool doOnce=false;

	void Start(){
		timer = mainTIMER;
	}

	void Update(){
		if (timer >= 0.0f && canCount) {
			timer -= Time.deltaTime;
			uiText.text = timer.ToString ("F");
		}
		else if(timer<=0.0f && !doOnce)
		{
			canCount = false;
			doOnce=true;
			uiText.text="0.00";
			timer = 0.0f;
			lose.SetActive(true);
			Destroy(character);
		}
	}
}
