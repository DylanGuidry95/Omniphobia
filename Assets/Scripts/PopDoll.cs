﻿using UnityEngine;
using System.Collections;

public class PopDoll : MonoBehaviour {

    private GameObject _player;
    private GameObject _parent;
    private bool _popped;

	// Use this for initialization
	void Start () {
        _player = GameObject.Find("OVRPlayerController");
        _parent = transform.parent.gameObject;
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    private void OnTriggerEnter(Collider other)
    {
        if (!_popped)
        {
            if (other.name == _player.name)
            {
                _parent.GetComponent<Rigidbody>().AddForce(_parent.transform.forward * 5, ForceMode.Impulse);
                _popped = true;
            }
        }
    }
}