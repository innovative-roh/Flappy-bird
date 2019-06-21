using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour {
    public static int value = 0;
    Text scoree;


	// Use this for initialization
	void Start () {
        scoree = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
        scoree.text = "score:" + value;
	}
}
