using Proyecto26;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;
using TMPro;
using System.Linq;

public class deleteStudent : MonoBehaviour
{
    public GameObject input_field;
    string username;
    public void DeleteUser()
    {
        username = input_field.GetComponent<InputField>().text;
        // Debug.Log(name);

        //  Debug.Log("hello");
        if (input_field.GetComponent<InputField>().text != "" || input_field.GetComponent<InputField>().text != null)
        {


            RestClient.Get<adminData>(url: "https://fypdb-62d0f-default-rtdb.firebaseio.com/" + databaseadmin.loggedInAdmin.username +"/students/"+ username
                + ".json").Then(onResolved: response =>
                {
                    if (response.username == name)
                    {
                        
                    }
                    else
                    {
                        Debug.Log("No user exists");
                    }
                });
        }
    }
}
