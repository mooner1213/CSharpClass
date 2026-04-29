using UnityEngine;

public class DoubleDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [1] float형 변수 선언하고 초기화하기
        float f = 3.14f; // float형 변수는 숫자 뒤에 f를 붙여야한다.
        Debug.Log(f);

        // [2] double형 변수 선언하고 초기화하기
        double d = 3.141592; // double형 변수는 숫자 뒤에 아무것도 붙이지 않아도 되지만, d를 붙여도 된다.
        Debug.Log(d);

        // [3] decimal형 변수 선언하고 초기화하기
        decimal m = 3.141592m; // decimal형 변수는 숫자 뒤에 m을 붙여야한다.
        Debug.Log(m);
    }
}

/*
실수형 데이터
float : 32비트 실수형 데이터 형식
double : 64비트 실수형 데이터 형식
decimal : 128비트 실수형 데이터 형식
*/
