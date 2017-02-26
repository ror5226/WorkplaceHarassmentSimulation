using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonFunctionality : MonoBehaviour {

    public int buttonValue = 1;
    static bool go = true;
    int count = 0; 

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
        else if ((PathManager.pathName == "k111111111" && buttonValue == 2))
        {
            CharacterSelect.game.transform.localScale = new Vector3(0.0f, 0.0f, 0.0f);
            CharacterSelect.ending.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
            CharacterSelect.ending.transform.position = CharacterSelect.game.transform.position;

        }
        else if ((PathManager.pathName == "k1111111111" && buttonValue == 2))
        {
            CharacterSelect.game.transform.localScale = new Vector3(0.0f, 0.0f, 0.0f);
            CharacterSelect.ending.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
            CharacterSelect.ending.transform.position = CharacterSelect.game.transform.position;

        }
        else if ((PathManager.pathName == "k11111111" && buttonValue == 1))
        {
            PathManager.pathName += '1';
            pathManager.Update_Text();

        }
        else if ((PathManager.pathName == "k1111111111" && buttonValue == 1))
        {
            PathManager.pathName = "k11111111";
            pathManager.Update_Text();

        }


        else if ((PathManager.pathName == "k1111211" && buttonValue == 2))
        {
            PathManager.pathName = "k11111";
            pathManager.Update_Text();

        }
        else if ((PathManager.pathName == "k1111211" && buttonValue == 1 && count < 2))
        {
            if(count == 0)
            {
                pathManager.Update_Desc("\"Its fine, My wife and I are in an open relationship.\"");
                count++;

            }
            else
            {
                pathManager.Update_Desc("\"This is going to hurt your performance review next month.\"");
                count = 0;
            }

        }
        else if ((PathManager.pathName == "k1111"))
        {
            PathManager.pathName = "k11112";
            pathManager.Update_Text();

        }

        else if ((PathManager.pathName == "k11111"))
        {
            PathManager.pathName = "k111111";
            if(buttonValue == 2)
            {
                go = false;
            }
            pathManager.Update_Text();

        }
        else if ((PathManager.pathName == "k111111") && go)
        {
            PathManager.pathName = "k11112"; 
            go = false;
            pathManager.Update_Text();

        }
        else if (PathManager.pathName == "k1111111" && buttonValue == 2)
        {
            pathManager.Update_Text();
        }
        else if ((PathManager.pathName == "k111111111111") && go)
        {
            PathManager.pathName = "k111111"; 
            go = false;
            pathManager.Update_Text();

        }
        else if ((PathManager.pathName == "k1111211"))
        {
            pathManager.Update_Text();

        }
        else 
        {
            PathManager.pathName += buttonValue.ToString();
            pathManager.Update_Text();

        }

    }
}
