using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonFunctionality : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void NextButton_Pressed()
    {

        GameObject description_text = GameObject.FindGameObjectWithTag("Description_Text");
        if(description_text != null)
        {
            Text desc_text = description_text.GetComponent<Text>();
            desc_text.text = " hello";
        }
        else
        {
            Debug.Log("Couldnt find it");
        }
    }
}
