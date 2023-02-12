using Assets;
using Assets.Core.Models;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserScript : MonoBehaviour
{
    public User currentUser;
    // Start is called before the first frame update
    void Awake()
    {
        var connection = new MongoConnection();
        currentUser = connection.GetUserFromDataBase();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
