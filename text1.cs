using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class text1 : MonoBehaviour
{
    public float speed;
    public float power;
    public float a;
    public float size;

    public TextMesh ScriptTxt;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        speed= 10;     
        size=10;
        a=Grid.count;

        power=(a*380*size)/speed;

        string str_int = power.ToString();

        ScriptTxt.text=str_int;
    }
}
