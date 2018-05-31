using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UserInterface : MonoBehaviour {

    public Text timerText;
    public float time;

    public GameObject timeUpScreen;
    public GameObject timesUpText;
    public float textFadeIn;

	// Use this for initialization
	void Start () {
        timerText = GetComponent<Text>();
        timeUpScreen.SetActive(false);
        timesUpText.SetActive(false);

	}
	
	// Update is called once per frame
	void Update () {

        timerText.text = "" + Mathf.Round(time);
        time -= Time.deltaTime;

        if(time <= 0)
        {
            timeUpScreen.SetActive(true);
            textFadeIn -= Time.deltaTime;
            if (textFadeIn <= 0)
            {
                timesUpText.SetActive(true);
            }
        }
	}
}
