using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Firs_Lesson : MonoBehaviour {

	// Use this for initialization
	void Start () {
        PlayerPrefs.SetFloat("Rist", 170.5f);

        Debug.Log(PlayerPrefs.GetFloat("Comone", -90.1f));

        PlayerPrefs.SetInt("Age", 14);

        Debug.Log(PlayerPrefs.GetInt("Age", 14));

        PlayerPrefs.SetString("Name", "Denial");

        Debug.Log(PlayerPrefs.GetString("Name", "Denial"));
    }
	
	
		
	
}
