using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonFunctionality : MonoBehaviour {

    public int buttonValue = 1;
    bool go = true;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Button_Pressed()
    {
        PathManager pathManager = new PathManager();

        if ((PathManager.pathName == "k11111111" && buttonValue == 2))
        {
            CharacterSelect.game.transform.localScale = new Vector3(0.0f, 0.0f, 0.0f);
            CharacterSelect.ending.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
            CharacterSelect.ending.transform.position = CharacterSelect.game.transform.position; 
        }
        else if ((PathManager.pathName == "k1111211" && buttonValue == 2))
        {
            PathManager.pathName = "k11111"; 
        }
        else if ((PathManager.pathName == "k11111"))
        {
            PathManager.pathName = "k111111";

        }
        else if ((PathManager.pathName == "k111111") && go)
        {
            PathManager.pathName = "k11112"; 
            go = false;
        }
        else if ((PathManager.pathName == "k111111111111") && go)
        {
            PathManager.pathName = "k111111"; 
            go = false;
        }
        else if (!(PathManager.pathName == "k1111211") && buttonValue == 1)
        {
            PathManager.pathName += buttonValue.ToString();

        }

        pathManager.Update_Text();
    }
}
