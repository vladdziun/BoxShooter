﻿using UnityEngine;
using System.Collections;

public class LeverReload : MonoBehaviour {
	
	public string nameOfLevelToLoad  = "";
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnTriggerEnter (Collider other)
	{
		if(other.gameObject.tag == "Player" )
		{
			Application.LoadLevel(nameOfLevelToLoad);
		}
	}
}
