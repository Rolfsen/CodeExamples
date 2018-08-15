using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventSender : MonoBehaviour {

	public delegate void NewEvent();
	public static event NewEvent newEvent;

	private void Update()
	{
		if (Input.GetKeyDown(KeyCode.Alpha1) && newEvent != null)
		{
			newEvent();
		}
	}



}
