using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {

    public char character = 'K';

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Character_Selected()
    {
        PathManager pathManager = new PathManager();
        PathManager.pathName += character;
        pathManager.Update_Text();
    }
}
