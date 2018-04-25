﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerMoveController : MonoBehaviour {

    private NavMeshAgent agent;

	void Start ()
    {
        agent = GetComponent<NavMeshAgent>();
	}
	
	void Update ()
    {
		if (Input.GetMouseButton(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            Physics.Raycast(ray, out hit);
            if(hit.transform)
            {
                agent.SetDestination(hit.point);
            }
        }
	}
}
