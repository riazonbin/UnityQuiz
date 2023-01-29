using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenShopScript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject shopImage;

    public void DisplayShop()
    {
        if(shopImage.activeSelf)
        {
            shopImage.SetActive(false);
            return;
        }
        shopImage.SetActive(true);
    }
}
