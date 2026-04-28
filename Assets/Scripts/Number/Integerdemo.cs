using UnityEngine;

// 숫자 데이터 형식 사용하기 : 정수형, 실수형
// 정수형(Integer) : 소수점이 없는 숫자 데이터 형식, 양수와 음수 모두 표현 가능

public class IntegerDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // SignedInteger : 부호가 있는 정수형 데이터 형식
        sbyte isbyte = 127;
        short iInt16 = 32767;
        int iInt32 = 2147483647;
        long iInt64 = long.MaxValue;

        Debug.Log("sbyte : " + isbyte);
        Debug.Log("short : " + iInt16);
        Debug.Log("int : " + iInt32);
        Debug.Log("long : " + iInt64);

        // UnsignedInteger : 부호가 없는 정수형 데이터 형식
    }
}


/*
1 byte = 8 bit
1 bit : 0 또는 1 데이터를 저장하는 단위

8 bit
-> -128

0000 0000 -> 0
0000 0001 -> 1
0000 0010 -> 2
0000 0011 -> 3
.
.
.
1111 1111 -> 255

-> 127

* 왜 -128 이고 양수는 127일까? = - 부호를 표현하는 앞자리 0중에서도 정수 '0'을 포함하기 때문

sbyte : -128 ~ 127
byte : 0 ~ 255
*/