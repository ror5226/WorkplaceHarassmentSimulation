using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Xml.Linq;
using UnityEngine.UI;

public class PathManager : MonoBehaviour{

    public static string pathName = "";
    public static XDocument doc;

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
		var pathText = doc.Descendants("game").Descendants(pathName).Descendants("text");
            foreach (var text in pathText)
            {
                // Add in here searches for additional tags
				Update_Desc(text.Value);
            }

		var pathButton = doc.Descendants ("game").Descendants (pathName).Descendants ("button");
		foreach (var button in pathButton) {
			if (Convert.ToInt32(button.Value) >= 1) {
		var button1 = doc.Descendants("game").Descendants(pathName).Descendants("b1");
			foreach (var b1 in button1) {
				Update_ButtonText (b1.Value,1);
			}
				if (Convert.ToInt32(button.Value) >= 2) {
				var button2 = doc.Descendants("game").Descendants(pathName).Descendants("b2");
					foreach (var b2 in button2) {
					Update_ButtonText (b2.Value,2);
				}
					if (Convert.ToInt32(button.Value) == 3) {
					var button3 = doc.Descendants("game").Descendants(pathName).Descendants("b3");
						foreach (var b3 in button3) {
							Update_ButtonText (b3.Value,3);
					}
				}
			}
		}
	}
}

public void Update_Desc(string s)
{
		GameObject description_text = GameObject.FindGameObjectWithTag("Desc_Text");
		if (description_text != null)
		{
			Text desc_text = description_text.GetComponent<Text>();
			//desc_text.text = Update_Text();
			desc_text.text = s;
		}
		else
		{
			Debug.Log("Couldnt find it");
		}
	}


public void Update_ButtonText (string s, int i) {
	string tag = "b" + i.ToString();
		GameObject button_text = GameObject.FindGameObjectWithTag(tag);
	if (button_text != null){
		Text b_text = button_text.GetComponent<Text>();
		b_text.text= s;
		}

	else
		{
			Debug.Log("Couldn't find it");
		}
	}
}		