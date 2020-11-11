using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class item_click : MonoBehaviour
{
    public static string name_of_obj;
    public GameObject obj_name_text;

    private void OnMouseDown()
    {
        name_of_obj = gameObject.name;
        //Debug.Log(name_of_obj);
        Destroy(gameObject);
        Destroy(obj_name_text);
    }

}