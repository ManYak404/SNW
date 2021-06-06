using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cell : MonoBehaviour
{
    string terrain;
    bool resource;

    //Constructor
    public Cell(string t, bool r)
    {
        terrain = t;
        resource = r;
    }

    // Start is called before the first frame update
    /*void Start()
    {
        
    }*/

    // Update is called once per frame
    /*void Update()
    {
        
    }*/
}
