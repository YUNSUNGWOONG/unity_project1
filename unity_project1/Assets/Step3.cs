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
        Debug.Log("�� ���� ������?" + isEqual);
    }
    void Func2()
    {
        int a = 5;
        int b = 3;
        bool isNotEqual = (a != b);
        Debug.Log("�� ���� �ٸ���?" + isNotEqual);
    }
    void Start()
    {
        //Func1();
        //Func2();
        //{
        //    int a = 5;
        //    int b = 5;
        //    bool isEqual = (a == b);
        //    Debug.Log("�� ���� ������?" + isEqual);
        //}
        //{
        //    int a = 5;
        //    int b = 3;
        //    bool isNotEqual = (a != b);
        //    Debug.Log("�� ���� �ٸ���?" + isNotEqual);
        //}
        //{
        //    int a = 7;
        //    int b = 4;
        //    bool isGreater = (a > b);
        //    Debug.Log("a�� b���� ū��?" + isGreater);
        //}
        //{
        //    int a = 3;
        //    int b = 6;
        //    bool isLess = (a < b);
        //    Debug.Log("a�� b���� ������?" + isLess);
        //}
        //{
        //    int a = 3;
        //    int b = 6;
        //    bool isLessOrEquals = (a <= b);
        //    Debug.Log("a�� b���� �۰ų� ������?" + isLessOrEquals);
        //}
        //{
        //    int a = 3;
        //    int b = 6;
        //    bool isGreaterOrEquals = (a >= b);
        //    Debug.Log("a�� b���� ũ�ų� ������?" + isGreaterOrEquals);
        //}
        //{
        //    int a = 3;
        //    int b = 6;
        //    bool isGreaterOrEquals = (a >= b);
        //    if (isGreaterOrEquals)
        //    {
        //        Debug.Log("��");
        //    }
        //    else
        //    {
        //        Debug.Log("����");
        //    }
        //}
        //{
        //    int a = 8;
        //    if (a == 10)
        //    {
        //        Debug.Log("10��");
        //    }
        //    else if (a == 9)
        //    {
        //        Debug.Log("9��");
        //    }
        //    else if (a == 8)
        //    {
        //        Debug.Log("8��");
        //    }
        //    else
        //    {
        //        Debug.Log("�ϰ͵� �ƴ�");
        //    }
        //}
        //{
        //   for(int i=0; i<10; i++)
        //    {
        //        //����
        //        Debug.Log(i);
        //    }
        //}
        //{
        //   for(int i = 0; i < 10; i++)
        //    {
        //        if (i >= 5)
        //        {
        //            Debug.Log(i + "�� 5���� ũ�ų� ����");
        //        }
        //        else
        //        {
        //            Debug.Log(i + "�� 5���� �۴�");
        //        }
        //    }
        //}
        // 0���� 40���� ���߿� 10���� ������ �������� 0�� ���ڵ��� ����ϱ�
        //{
        //    for (int i = 0; i < 41; i++)
        //    {
        //        if (i % 10 == 0)
        //        {
        //            Debug.Log(i + "�� 10���� �������� �������� 0�̴�.");
        //        }
        //    }
        //}
        // 0���� 100������ ���߿� Ȧ���� �ֵ鸸 ����ϱ�
        //{
        //    for(int i = 0; i <101; i++)
        //    {
        //        if(i % 2 == 1)
        //        {
        //            Debug.Log(i + "�� Ȧ���̴�.");
        //        }
        //    }
        //}
        // 0���� 100������ ���߿� 5�� ����� ���ڸ� ����ϱ�
        //{
        //    for (int i = 0; i < 101; i++)
        //    {
        //        if (i % 5 == 0)
        //        {
        //            Debug.Log(i + "�� 5�� ����̴�.");
        //        }
        //    }
        //}

        //{
        //    for (int i = 0; i < 101; i++)
        //    {

        //        Debug.Log((i > 50 && i % 5 == 0) ? $"{i}�� 50���� ū 5�� ����Դϴ�." : "");

        //    }
        //}
        



    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
