using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Step2 : MonoBehaviour
{
   


    // Start is called before the first frame update
    void Start()
    {
        //�߰�ȣ�� �ľ���. ��ȣ ������ �ν��� ��.
        //1.����������
        {
            int a = 5;
            int b = 3;
            int result = a + b;
            Debug.Log("1.����������: " + result); // 8
        }
        //2. ����������
        {
            int a = 7;
            int b = 2;
            int result = a - b;
            Debug.Log("2. ����������: " + result); // 5
        }
        //3. ����������
        {
            float a = 2.5f;
            float b = 3f;
            float result = a * b;
            Debug.Log("3. ����������: " + result); // 7.5
        }
        //4. ������ ������
        {
            float a = 10f;
            float b = 2f;
            float result = a / b;
            Debug.Log("4. ������ ������: " + result);

        }
        //5. ������ ������
        {
            int a = 13;
            int b = 5;
            int result = a % b;
            Debug.Log("5. ������ ������: " + a);
        }
        //6. ����������
        {
            int a = 5;
            a++;
            Debug.Log("6. ����������: " + a);
        }
        //7. ���ҿ�����
        {
            int a = 8;
            a--;
            Debug.Log("7. ���ҿ�����: " + a);
        }
        //8.��ȣ ���� ������
        {
            int a = 10;
            int result = -a;
            Debug.Log("8.��ȣ ���� ������: " + result);
        }
        //9. ���� ���� ������
        {
            int a = 5;
            int b = 3;
            a += b;
            Debug.Log("9. ���� ���� ������: " + a);
        }
        //10. ���� ���� ������
        {
            float a = 2.5f;
            float b = 3f;
            a *= b;
            Debug.Log("10. ���� ���� ������: " + a);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
