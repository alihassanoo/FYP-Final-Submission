using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AdminLogout : MonoBehaviour
{
    public void logout() 
    {
        SceneManager.LoadScene("AdminPortal");
    }
}
