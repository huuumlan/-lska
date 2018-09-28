using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sug : MonoBehaviour
{

    public bool ifbool;
    public int valeu;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                print("due e");
            }

            if (ifbool == true)
            {
                print("ja");
            }
            if (valeu == 5)

            {
                if (ifbool == true)

                { print("grattis"); }
            }
            else if (valeu == 4)
            {
                print("mada mada");
            }
            else
            {
                print("nej");
            }

        }



    }

}