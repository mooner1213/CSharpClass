using UnityEngine;

// 두 수 (a, b)를 입력받아 두수중 작은 수, 큰 수를 찾는 프로그램 구현
public class FunctionMinMax : MonoBehaviour
{
    public int a = 0;
    public int b = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        /* int result = Min(-4, 2);
         Debug.Log(result);

         Debug.Log(Max(5, 3));*/

        // a,b 의 작은 값,큰 값 구하기

        int MinValue = Min(a, b);
        int MaxValue = Max(a, b);
        Debug.Log($"작은 값은 {MinValue}, 큰 값은 {MaxValue}");

        // int absValue = Abs( a );           // 사용자 함수
        int absValue = Mathf.Abs( MinValue ); // 내장 함수
        Debug.Log($"절댓값은 {absValue}");
    }

    // 매개변수로 입력받은 두 수중 작은 수를 반환하는 함수

    int Min(int x, int y)
    {
        if (x < y)
        {
            return x;
        }
        else
        {
            return y;
        }

    }

    // 매개변수로 입력받은 두 수중 큰 수를 반환하는 함수

    int Max(int x, int y)
    {
        /*int MaxValue = 0;
        if (x > y)
        {
            MaxValue = x;
        }
        else
        {
            MaxValue = y;
        }*/

     /*   // 3항 연산자
        // (조건식) ? 참일때 반환 값 : 거짓일때 반환 값
        int MaxValue = (x > y) ? x : y;*/

        return (x > y ? x : y);
    }

    // 매개변수로 입력받은 정수의 절대값을 반환하는 함수
    // 절댓값 : -5 -> 5, 4 -> 4, 즉 음수가 양수로 변환되어 나온다.
    int Abs(int number)
    {
        /*if (number < 0)
        {
            return -number;
        }
        else
        {
            return number;
        }*/

        return (number < 0) ? -number : number;
    }

}