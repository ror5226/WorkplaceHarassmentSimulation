using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSelect : MonoBehaviour {

    public char character = 'k';
    public static GameObject menu;
    public static GameObject game;

    // Use this for initialization
    void Start () {
        game = GameObject.FindGameObjectWithTag("Main_Game");
        menu = GameObject.FindGameObjectWithTag("Main_Menu");
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Character_Selected()
    {
        PathManager.pathName += character;

        game.transform.position = menu.transform.position;
        menu.SetActive(false);
    }
}
