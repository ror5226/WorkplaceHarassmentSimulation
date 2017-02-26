using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSelect : MonoBehaviour {

    public char character = 'k';
    public static GameObject menu;
    public static GameObject game;
    public static GameObject charact;
    public static GameObject ending;

    // Use this for initialization
    void Start () {
        game = GameObject.FindGameObjectWithTag("Main_Game");
        menu = GameObject.FindGameObjectWithTag("Main_Menu");
        charact = GameObject.FindGameObjectWithTag("Main_Character");
        ending = GameObject.FindGameObjectWithTag("end_panel");
    }

    // Update is called once per frame
    void Update () {
		
	}

    public void Character_Selected()
    {
        PathManager pathManager = new PathManager();

        PathManager.pathName += character;
        PathManager.pathName += "1";

        pathManager.Update_Text();

        charact.transform.position = menu.transform.position;
        CharacterSelect.menu.transform.localScale = new Vector3(0.0f, 0.0f, 0.0f);
        CharacterSelect.charact.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
        ;

    }
}
