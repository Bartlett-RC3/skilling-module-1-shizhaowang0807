using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class firsttry : MonoBehaviour
{
    //variables

    public int myage = 24;
    public int mybearthyear = 1996;
    public float myweight = 85.5f;
    public float e = 2.71848182846f;
    public double pi = 3.14159265358789323846264338327950288419716939937510582097494459230781640628620899862803482534211d;
    //private string myname = "shizhaowang";
    //private string myaddress = "hanover house vauxhaul london"
    public bool ifliveinlondon = true;
    public bool iflivealone = false;

    //data structure
    //array
    public int[] currenttime = { 41, 14, 27, 10, 2020 };
    public float[] mymoney = { 20.5f, 67.31f };
    //list
    public List<float> mymath = new List<float>(7);
    //functions
    //private void 
 private float Calculatearea (float _R, float _PI)
    {
        float result = _R * _R * _PI;
        return result;
    }
    public float R = 22.8f;
    public float PI = 3.14159f;



    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(Calculatearea(R, PI));
        mymoney [1] = 73.2f;
        mymath.Add(3.14f);
        mymath.Add(15926f);
        mymath[0] = 3.1415926f;
        //homework dictionary
        Dictionary<string, int> openwith = new Dictionary<string, int>();
        openwith.Add("age", 24);
        openwith.Add("enrol lyear", 2020);
        openwith.Add("weight", 85);
        openwith.Add("days stay in london", 15);
        openwith["days stay in london"] = 16;
        Debug.Log(openwith["days stay in london"]);
        Dictionary<string, int>.ValueCollection valueColl = openwith.Values;//what is this line doing?
        openwith.Remove("weight");
        if (!openwith.ContainsKey("weight"))
        {
            Debug.Log("Key \"weight\" is not found."); 
        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
