using UnityEngine;

public class DoWhileDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [1] 초기식
        int i = 0;

        do
        {
            // 반복 실행문
            Debug.Log("안녕하세요");
            // [2] 증감식
            i++;
        }
        while (i < 3);
    }
}

/*
== do while

do
{
    // 반복 실행문
}
while(조건식)

// 무조건 먼저 반복 실행문을 실행한다.
조건식이 참이면 반복문 실행, 거짓이면 while 문 종료

 */