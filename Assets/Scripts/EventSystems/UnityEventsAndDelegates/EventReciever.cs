using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventReciever : MonoBehaviour {

	
	private void OnEnable()
	{
		EventSender.newEvent +=	IRecievedEvent;
	}

	private void OnDisable()
	{
		EventSender.newEvent -= IRecievedEvent;
	}



	public void IRecievedEvent ()
	{
		print("I just Recieved an Event");
	}
}
