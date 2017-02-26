using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonFunctionality : MonoBehaviour {

    public int buttonValue = 1; 

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Button_Pressed()
    {
        PathManager pathManager = new PathManager();
        
        // Add in real num here later
        if(PathManager.pathName != "K111")
        {
            PathManager.pathName += buttonValue.ToString();

        }
        pathManager.Update_Text();
    }
}
