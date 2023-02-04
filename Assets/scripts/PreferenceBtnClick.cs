using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PreferenceBtnClick : MonoBehaviour
{
    public GameObject prefLine;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClick()
    {
        prefLine.SetActive(!prefLine.activeSelf);
    }
}
