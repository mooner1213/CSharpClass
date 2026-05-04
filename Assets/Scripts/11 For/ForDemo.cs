using UnityEngine;

public class ForDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        for (int i = 0; i < 3; i++)
        {
            Debug.Log($"{i+1}번째 인사입니다. 안녕하세요.");
        }

        // 무한루프

        for (; ; )
        {
            // 반복 실행문
            Debug.Log("무한루프");  
        }
    }
}

/*
제어문 : 순차문, 조건문(if, switch), 반복문(for, while, ...)

== for

for(초기식; 조건식; 증강식)

초기식 -> 조건식 판별(참) -> 반복 명령문 실행 -> 증감식 -> 조건식 판별(참) -> 반복 명령문 실행 -> 증감식

초기식 -> 조건식 판별(거짓) -> for문 종료

{
    // 반복 실행문
}
// 초기식 : 조건식에서 사용하는 변수의 초기값 설정(초기화)
// 조건식 : 조건식을 참, 거짓으로 판별, 참일 경우 반복문 1회 실행, 거짓일 경우 for 문 종료
// 증강식 : 조건식의 변수를 다시 연산해주는 식, 반목문을 실행할때 마다 실행한 직후 실행
*/