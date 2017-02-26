using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSelect : MonoBehaviour {

    public char character = 'k';
    public static GameObject menu;
    public static GameObject game;
    public static GameObject charact;

    // Use this for initialization
    void Start () {
        game = GameObject.FindGameObjectWithTag("Main_Game");
        menu = GameObject.FindGameObjectWithTag("Main_Menu");
        charact = GameObject.FindGameObjectWithTag("Main_Character");

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
        menu.SetActive(false);
    }
}
