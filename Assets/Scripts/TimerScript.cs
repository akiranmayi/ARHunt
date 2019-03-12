﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerScript : MonoBehaviour {

    public Text counterText;
    public GameObject text;
    public float seconds, minutes;

    void Awake()
    {
        DontDestroyOnLoad(text);
    }
	// Use this for initialization
	void Start () {
        counterText = GetComponent<Text>() as Text;
	}
	
	// Update is called once per frame
	void Update () {
        minutes = (int)(Time.time/60f);
        seconds = (int)(Time.time % 60f);
        counterText.text = minutes.ToString("00") + ":" + seconds.ToString("00");
    }
}
