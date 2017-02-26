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

        if (((PathManager.pathName == "k111111" || PathManager.pathName == "k11211") && buttonValue == 2))
        {
            CharacterSelect.game.transform.localScale = new Vector3(0.0f, 0.0f, 0.0f);
            CharacterSelect.ending.transform.position = CharacterSelect.game.transform.position;

        }
        if (!((PathManager.pathName == "k111111" || PathManager.pathName == "k11211") && buttonValue == 1))
        {
            PathManager.pathName += buttonValue.ToString();

        }

        pathManager.Update_Text();
    }
}
