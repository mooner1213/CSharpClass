using UnityEngine;

// Opertator, 연산자 : +, -, *, /, % 등과 같은 연산을 수행하는 기호
public class OperatorDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [1] Unary Operator (단항 연산자) : +, - 
        int value = 0; // 정수형 변수 value 선언하고 0으로 초기화하기

        value = 8; // 정수형 변수 value 에 8 저장
        value = +value; // 정수형 변수 value 에 +value 값 저장하기
        Debug.Log(value); // 8

        value = -8; // 정수형 변수 value 에 -8 저장
        value = +value; // 정수형 변수 value 에 +value 값 저장하기
        Debug.Log(value); // -8

        value = 8; // 정수형 변수 value 에 8 저장
        value = -value; // 정수형 변수 value 에 -value 값 저장하기
        Debug.Log(value); // -8

        value = -8; // 정수형 변수 value 에 -8 저장
        value = -value; // 정수형 변수 value 에 -value 값 저장하기
        Debug.Log(value); // 8

        // [2] Binary Operator (이항 연산자) : +, -, *, /, %

        int i = 5;
        int j = 3;
        
        int k;

        k = i + j; // 5 + 3 = 8
        Debug.Log(k);

        k = i - j; // 5 - 3 = 2
        Debug.Log(k);

        k = i * j; // 5 * 3 = 15
        Debug.Log(k);

        k = i / j; // 5 / 3 = 1
        Debug.Log(k);

        k = i % j; // 5 % 3 = 2
        Debug.Log(k);
    }
}
