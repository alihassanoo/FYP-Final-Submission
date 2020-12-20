using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Database_register_child 
{
    /* MUSTAFA DAR
         * This class is used to store student data
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
     * This subfield will contain scores of this student 
    */
    public string quizscore;
    public Database_register_child()
    {
        password = DataBase_base.password;
        email = DataBase_base.email;
        username = DataBase_base.username;
        Debug.Log("student credentials are");
        Debug.Log(password);
        Debug.Log(email);
        Debug.Log(username);
    }
}
