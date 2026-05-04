using UnityEngine;

public class WhileDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // 안녕하세요를 3번 출력하는 프로그램 구현
        int i = 0;
        while (i < 3) // 조건식
        {
            Debug.Log("안녕하세요.");
            i++;
        }
    }
}

/*
제어문: 순차문, 조건문, 반복문(for, While...)
    == while
    while(조건식)
    {
        // 반복 실행문
    }

조건식 판별(참) -> 반복문 실행 -> 조건식 판별(참) -> 반복문 실행
조건식 판별(거짓) -> while 반복문 종료


조건식이 참이면 반복문을 실행, 거짓이면 while 문 종료

 */