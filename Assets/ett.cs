using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ett : MonoBehaviour
{

    public int vänster = 1;
    public int höger = 1;
    public int upp = 2;



    public int a;
    public int b;
    public int poäng;
    public int drake;
    public int drakeld;
    public int drakemaxhp;
    public int riddaremax;
    public int riddaremin;
    public int riddarecrit;

    public int riddare;

    // Use this for initialization
    void Start()
    {
        poäng = 10;
        riddare = 100;
        drake = Random.Range(100, 151);
        drakemaxhp = Random.Range(1, 11);
        if (drakemaxhp == 1)
        {
            drake = drake * 2;
        }

        riddaremax = Random.Range(15, 20);
        riddaremin = Random.Range(1, 8);
        
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            drakeld = Random.Range(1, 3);
            if (drakeld == 1)
            {
                print(riddare - Random.Range(10, 21));


            }
            

            drake = drake - Random.Range(riddaremin, riddaremax);
            riddarecrit = Random.Range(1, 21);
           if(riddarecrit == 1)
            {
                drake = 0;
            }
            if (drake <= 0)
            {
                print("draken stendog");
            }
           
            if(riddare <= 0)
            {
                print("riddaren stendog");
            }

           

            /* if (Input.GetKeyDown(KeyCode.LeftArrow))
             {

                 {
                     print(vänster += 2);
                 }


             }

             if (Input.GetKeyDown(KeyCode.RightArrow))
             {
                 print(höger /= 2);

             }
             // if (Input.GetKeyDown(KeyCode.UpArrow))
             //  {
             // print(upp = )
             //  }

             if (Input.GetKeyDown(KeyCode.R))
             {
                 a = Random.Range(1, 7);


                 b = Random.Range(1, 7);

                 poäng = poäng + a - b;


                 print(poäng);

                 if (poäng >= 20)
                 {
                     print("grattis");

                 }

                 if (poäng <= 0)
                 {
                     print("sorry men du förlora");


                 }*/
        }
    }
}

