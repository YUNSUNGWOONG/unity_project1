using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button1 : MonoBehaviour
{
    public int a = 10;
    public bool isPlus = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnClickButton1()
    {
        if (isPlus)
        {
            a += 1;
        }
        else
        {
            a -= 1;
        }
        
        Debug.Log(a);
    }
    public void OnClickButton2()
    {
        if (isPlus)
        {
            a += 2;
        }
        else
        {
            a -= 2;
        }
        Debug.Log(a);
    }
    public void OnClickButton3()
    {
        if (isPlus)
        {
            a += 3;
        }
        else
        {
            a -= 3;
        }
        Debug.Log(a);
    }
    public void OnClickButton4()
    {
        if (isPlus)
        {
            a += 4;
        }
        else
        {
            a -= 4;
        }
        Debug.Log(a);
    }
    public void OnClickButton5()
    {
        if (isPlus)
        {
            a += 5;
        }
        else
        {
            a -= 5;
        }
        Debug.Log(a);
    }
    public void OnClickButton6()
    {
        if (isPlus)
        {
            a += 6;
        }
        else
        {
            a -= 6;
        }
        Debug.Log(a);
    }
    public void OnClickButton7()
    {
        if (isPlus)
        {
            a += 7;
        }
        else
        {
            a -= 7;
        }
        Debug.Log(a);
    }
    public void OnClickButton8()
    {
        if (isPlus)
        {
            a += 8;
        }
        else
        {
            a -= 8;
        }
        Debug.Log(a);
    }
    public void OnClickButton9()
    {
        if (isPlus)
        {
            a += 9;
        }
        else
        {
            a -= 9;
        }
        Debug.Log(a);
    }
    public void PlusClick()
    {
        isPlus = true;
    }
    public void MinusClick()
    {
        isPlus = false;
    }
}
