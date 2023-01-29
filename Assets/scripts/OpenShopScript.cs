using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenShopScript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject shopImage;



    public void DisplayShop()
    {
        shopImage.SetActive(true);
    }

    public void HideShop()
    {
        shopImage.SetActive(false);
    }
}
