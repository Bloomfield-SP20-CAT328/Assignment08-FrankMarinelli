﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FieldOfVision : MonoBehaviour
{

	[SerializeField]
	private bool trigger;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider collider)
	{
        if(collider.gameObject.tag == "Player")
		{
			trigger = true;
		}
	}

    private void OnTriggerExit(Collider collider)
	{
        if(collider.gameObject.tag == "Player")
		{
			trigger = false;
		}
	}
}
