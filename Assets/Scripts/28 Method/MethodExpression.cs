using UnityEngine;

namespace Method
{
    // 매서드 축약형
    public class MethodExpression : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            Work();
            Hello();
            Debug.Log(DoubleValue(4));
            Debug.Log(Plus(5,8));
        }

        // [1] 매서드 - 기본형식
        void Work()
        {
            Debug.Log("Work 실행");
        }

        // [1] 메서드 축약형 - 실행 명령문 1줄
        void Hello() => Debug.Log("Hello");

        // 매개변수로 입력받은 정수 값을 두배로 반환하는 함수
        int DoubleValue(int value) => value * 2;

        // 매개변수로 입력받은 두 정수의 합을 반환하는 함수
        int Plus(int a, int b) => a + b;
    }
}