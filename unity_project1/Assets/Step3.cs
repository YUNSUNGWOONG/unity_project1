using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Step3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Func1()
    {
        int a = 5;
        int b = 5;
        bool isEqual = (a == b);
        Debug.Log("두 값이 같은가?" + isEqual);
    }
    void Func2()
    {
        int a = 5;
        int b = 3;
        bool isNotEqual = (a != b);
        Debug.Log("두 값이 다른가?" + isNotEqual);
    }
    void Start()
    {
        //Func1();
        //Func2();
        //{
        //    int a = 5;
        //    int b = 5;
        //    bool isEqual = (a == b);
        //    Debug.Log("두 값이 같은가?" + isEqual);
        //}
        //{
        //    int a = 5;
        //    int b = 3;
        //    bool isNotEqual = (a != b);
        //    Debug.Log("두 값이 다른가?" + isNotEqual);
        //}
        //{
        //    int a = 7;
        //    int b = 4;
        //    bool isGreater = (a > b);
        //    Debug.Log("a가 b보다 큰가?" + isGreater);
        //}
        //{
        //    int a = 3;
        //    int b = 6;
        //    bool isLess = (a < b);
        //    Debug.Log("a가 b보다 작은가?" + isLess);
        //}
        //{
        //    int a = 3;
        //    int b = 6;
        //    bool isLessOrEquals = (a <= b);
        //    Debug.Log("a가 b보다 작거나 같은가?" + isLessOrEquals);
        //}
        //{
        //    int a = 3;
        //    int b = 6;
        //    bool isGreaterOrEquals = (a >= b);
        //    Debug.Log("a가 b보다 크거나 같은가?" + isGreaterOrEquals);
        //}
        //{
        //    int a = 3;
        //    int b = 6;
        //    bool isGreaterOrEquals = (a >= b);
        //    if (isGreaterOrEquals)
        //    {
        //        Debug.Log("참");
        //    }
        //    else
        //    {
        //        Debug.Log("거짓");
        //    }
        //}
        //{
        //    int a = 8;
        //    if (a == 10)
        //    {
        //        Debug.Log("10임");
        //    }
        //    else if (a == 9)
        //    {
        //        Debug.Log("9임");
        //    }
        //    else if (a == 8)
        //    {
        //        Debug.Log("8임");
        //    }
        //    else
        //    {
        //        Debug.Log("암것도 아님");
        //    }
        //}
        //{
        //   for(int i=0; i<10; i++)
        //    {
        //        //실행
        //        Debug.Log(i);
        //    }
        //}
        //{
        //   for(int i = 0; i < 10; i++)
        //    {
        //        if (i >= 5)
        //        {
        //            Debug.Log(i + "는 5보다 크거나 같다");
        //        }
        //        else
        //        {
        //            Debug.Log(i + "는 5보다 작다");
        //        }
        //    }
        //}
        // 0부터 40까지 수중에 10으로 나눠서 나머지가 0인 숫자들을 출력하기
        //{
        //    for (int i = 0; i < 41; i++)
        //    {
        //        if (i % 10 == 0)
        //        {
        //            Debug.Log(i + "는 10으로 나눴을때 나머지가 0이다.");
        //        }
        //    }
        //}
        // 0부터 100까지의 수중에 홀수인 애들만 출력하기
        //{
        //    for(int i = 0; i <101; i++)
        //    {
        //        if(i % 2 == 1)
        //        {
        //            Debug.Log(i + "는 홀수이다.");
        //        }
        //    }
        //}
        // 0부터 100까지의 수중에 5의 배수인 숫자만 출력하기
        //{
        //    for (int i = 0; i < 101; i++)
        //    {
        //        if (i % 5 == 0)
        //        {
        //            Debug.Log(i + "는 5의 배수이다.");
        //        }
        //    }
        //}

        //{
        //    for (int i = 0; i < 101; i++)
        //    {

        //        Debug.Log((i > 50 && i % 5 == 0) ? $"{i}는 50보다 큰 5의 배수입니다." : "");

        //    }
        //}
        



    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
