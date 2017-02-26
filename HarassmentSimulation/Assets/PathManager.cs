using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Xml.Linq;
using UnityEngine.UI;

public class PathManager : MonoBehaviour{

    public static string pathName = "K";
    XDocument doc;

    // Use this for initialization
    void Start () {
        doc = XDocument.Load("XMLFile1.xml");
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Update_Text()
    {
        // pathname is the name on the xml tag we're search for 
        var pathText = doc.Descendants(pathName);
        if(pathName != null)
        {
            foreach (var text in pathText)
            {
                // Add in here searches for additional tags
                Debug.Log(text.Value);
            }
        }

        // Example code to update text 
        GameObject description_text = GameObject.FindGameObjectWithTag("Description_Text");
        if (description_text != null)
        {
            Text desc_text = description_text.GetComponent<Text>();
            desc_text.text = " hello";
        }
        else
        {
            Debug.Log("Couldnt find it");
        }
    }
}

