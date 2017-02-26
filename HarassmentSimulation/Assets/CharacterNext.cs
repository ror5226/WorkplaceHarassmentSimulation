using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterNext : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void Button_Pressed()
    {
        CharacterSelect.game.transform.position = CharacterSelect.charact.transform.position;
        CharacterSelect.charact.SetActive(false);
    }
}
