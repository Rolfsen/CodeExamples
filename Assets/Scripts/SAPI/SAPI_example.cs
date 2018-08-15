using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SpeechLib;

public class SAPI_example : MonoBehaviour {

	[SerializeField]
	SpVoice ttsVoice;

	[SerializeField]
	int rate;
	[SerializeField]
	int volume;
	[SerializeField]
	int voiceID;

	// Use this for initialization
	void Start () {
		ttsVoice = new SpVoice();
		ttsVoice.Volume = volume;
		ttsVoice.Rate = rate;
		ttsVoice.Voice = ttsVoice.GetVoices().Item(voiceID);
		Invoke("SpeakEvent", 5);
	}
	

	void SpeakEvent()
	{
		ttsVoice.Speak("Hello, this is tts", SpeechVoiceSpeakFlags.SVSFlagsAsync);
	}
}
