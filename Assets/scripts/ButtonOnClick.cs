using Assets.Core;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonOnClick : MonoBehaviour
{
    public GameObject button;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Click()
    {
        if(button.GetComponent<Text>().text != "")
        {
            Transform panel = GameObject.Find("secretWordGroup").GetComponent<Transform>();
            foreach (Transform child in panel)
            {
                if (child.GetComponent<Text>().text == "")
                {
                    child.GetComponent<Text>().text = button.GetComponent<Text>().text;
                    return;
                }
            }
        }
    }
}
