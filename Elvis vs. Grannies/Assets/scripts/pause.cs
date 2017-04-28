using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pause : MonoBehaviour {


	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown("p"))
        {
            if (Time.timeScale == 0)
            {
                Time.timeScale = 1;
            }
            else
            {
                Time.timeScale = 0;
            }

        }

    }
}
