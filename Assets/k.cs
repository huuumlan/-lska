using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class k : MonoBehaviour
{
    public float linnea;
    public float tindra;
    public float simon;
    public float andrea;
    public float number;
    public float triangleBase;

    //float angel 360f



    // Use this for initialization
    void Start()
    {
        Uppgift1();
        Uppgift2();
        Uppgift3();

    }


    public void Uppgift1()
    {
        Debug.Log(linnea * tindra - (andrea / simon));


    }
    public void Uppgift2()
    {
        Debug.Log(string.Format("hej hej på dig"));
        Debug.Log(string.Format("nämen hej på dig själv"));
        Debug.Log(string.Format("hur mår du goi"));
        Debug.Log(string.Format("jo tack det är så bra så, sj då älsk?"));
    }

    public void Uppgift3()

    {
        Debug.Log(Mathf.Pow(number, 2));
        Debug.Log(Mathf.Sqrt(number));


    }

    //public void// Uppgift4()
  // { Debug.Log(triangleBase * 8 + / 2 "m ^ 2"); }

    // Update is called once per frame
    void Update()
    {

    }
}