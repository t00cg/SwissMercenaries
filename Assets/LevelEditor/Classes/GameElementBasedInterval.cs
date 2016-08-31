﻿using UnityEngine;
using System.Collections;

public class GameElementBasedInterval : GameElementBased {

	public float interval = 4.0f;
	public void SetIntervalTime( float iinterval ) {
		interval = iinterval;
	}
	public float timeForNextInterval = 0.0f;

	public int intervalCounter = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	
		if (Time.time>timeForNextInterval) {
			timeForNextInterval = Time.time + interval;
			OnInterval();
			intervalCounter++;
		}

		UpdatePositionToElement();

	}

	public virtual void  OnInterval() {
		// intervalCounter !!!

	}

	public bool FirstInterval() {
		if (intervalCounter==0) return true;
		return false;
	}

}
