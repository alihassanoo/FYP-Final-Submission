
using System;
using UnityEngine;

public class adminData
{
    /* MUSTAFA & ALI 
     * This class is used to store admin data
     * All these variables are being put in the database under the folder ra.username - username of the admin
     * This is the format
     * admin_username
     *          username
     *          email
     *          password
     *          students
    */
    public string password;
    public string email;
    public string username;
    /*
     * This subfield will contain students of this admin 
    */
    //public static List<Database_register_child> students = new List<Database_register_child>();
    public adminData() 
    {
        password = databaseadmin.password;
        email = databaseadmin.email;
        username = databaseadmin.username;
        Debug.Log("admin credentials are");
        Debug.Log(password);
        Debug.Log(email);
        Debug.Log(username);
    }
 
  
}