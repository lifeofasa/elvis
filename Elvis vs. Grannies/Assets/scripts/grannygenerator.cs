using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class grannygenerator : MonoBehaviour {
    public GameObject granny;
    GameObject granny1;
    GameObject granny2;
    GameObject granny3;
	// Use this for initialization
	void Start () {
        Invoke("newGranny", 3);
        Invoke("newGranny", 8);
        Invoke("newGranny", 13);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void newGranny()
    {
        if (granny1 == null)
        {
            granny1 = Instantiate(granny, new Vector3(0, 0, -2), Quaternion.identity);
        } else if ( granny1 != null && granny2 == null)
        {
            granny2 = Instantiate(granny, new Vector3(0, 0, 2), Quaternion.identity);
        } else if (granny1 != null && granny2 != null)
        {
            granny3 = Instantiate(granny, new Vector3(2, 0, 0), Quaternion.identity);
        }
    }
}
