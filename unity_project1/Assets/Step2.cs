using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Step2 : MonoBehaviour
{
   


    // Start is called before the first frame update
    void Start()
    {
        //중괄호를 쳐야함. 괄호 단위로 인식을 함.
        //1.덧셈연산자
        {
            int a = 5;
            int b = 3;
            int result = a + b;
            Debug.Log("1.덧셈연산자: " + result); // 8
        }
        //2. 뺄셈연산자
        {
            int a = 7;
            int b = 2;
            int result = a - b;
            Debug.Log("2. 뺄셈연산자: " + result); // 5
        }
        //3. 곱셈연산자
        {
            float a = 2.5f;
            float b = 3f;
            float result = a * b;
            Debug.Log("3. 곱셈연산자: " + result); // 7.5
        }
        //4. 나눗셈 연산자
        {
            float a = 10f;
            float b = 2f;
            float result = a / b;
            Debug.Log("4. 나눗셈 연산자: " + result);

        }
        //5. 나머지 연산자
        {
            int a = 13;
            int b = 5;
            int result = a % b;
            Debug.Log("5. 나머지 연산자: " + a);
        }
        //6. 증가연산자
        {
            int a = 5;
            a++;
            Debug.Log("6. 증가연산자: " + a);
        }
        //7. 감소연산자
        {
            int a = 8;
            a--;
            Debug.Log("7. 감소연산자: " + a);
        }
        //8.부호 변경 연산자
        {
            int a = 10;
            int result = -a;
            Debug.Log("8.부호 변경 연산자: " + result);
        }
        //9. 복합 대입 연산자
        {
            int a = 5;
            int b = 3;
            a += b;
            Debug.Log("9. 복합 대입 연산자: " + a);
        }
        //10. 복합 대입 연산자
        {
            float a = 2.5f;
            float b = 3f;
            a *= b;
            Debug.Log("10. 복합 대입 연산자: " + a);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
