using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndButton : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Button_Pressed()
    {
        CharacterSelect.ending.transform.localScale = new Vector3(0.0f, 0.0f, 0.0f);
        CharacterSelect.menu.transform.localScale = new Vector3(2.0f, 1.3f, 0.0f);

    }
}
