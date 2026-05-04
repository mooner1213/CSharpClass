using UnityEngine;

public class incrementNumber : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [1] 정수형 변수의 값을 1씩 증가하기
        // 정수형 변수 num을 선언하고 10으로 초기화
        int num = 10;
        // num의 값을 1씩 증가시키고, 증가 후 다시 num에 저장
        num = num + 1;

        Debug.Log(num); // 11

        // [2] 정수형 변수의 값을 1씩 감소하기
        // num의 값을 1씩 감소시키고, 감소 후 다시 num에 저장
        num = num - 1;

        Debug.Log(num); // 10

        // [3] 증가식, 감소식 축약해서 사용하기 (+=, -=, *=, /=, %=)
        int x = 3;
        x = x + 2; // 2씩 증가시키는 증가식
        Debug.Log(x); // 5

        int y = 3;

        y += 2; // 축약 식
        Debug.Log(y); // 5

        // [4] 누적식 (+=, -=, *=, /=, %=)
        int a = 3;
        int b = 5;

        // 누적 : b변수에 a변수의 값을 누적
        // b = b + a;
        b += a; // 축약 식
        Debug.Log(b); // 8

        // b 변수에 a 변수의 값을 감산 누적
        // b = b - a;
        b -= a; // 축약 식
        Debug.Log(b); // 5
    }
}
