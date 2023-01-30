using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CreateKeyboard : MonoBehaviour
{
    public GameObject preFab;
    public Transform panel;
    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < 40; i++)
        {
            var btn = Instantiate(preFab, panel);
            btn.GetComponentInChildren<Text>().text = ((char)Random.RandomRange('À', 'ß' + 1)).ToString();
            
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
