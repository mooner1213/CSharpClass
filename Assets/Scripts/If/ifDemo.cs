using UnityEngine;

// 조건문 : 조건에 맞는 명령문을 실행
// if, switch
public class ifDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // 만약 점수가 60점 이상이면 합격, 그렇지 않으면 불합격
        /*
        int score = 60;

        if (score >= 60) // 조건식
        {
            Debug.Log("합격"); // 실행문
        }
           Debug.Log("불합격");
        */

        /*
        만약 실행문이 하나라면 {} 생략 가능 
        
        if(score >= 60) // 조건식
            Debug.Log("합격"); // 실행문
        */

        // 중첩 if문 : if문 안에 if문이 있는 형태
        string name = "홍길동";
        int age = 20;

        // 만약 이름이 "홍길동"이라면, 실행문 실행
        if (name == "홍길동")
        {
            // 실행문 : 만약 나이가 20살이라면, 실행문 실행
            if (age == 20)
            {
                Debug.Log($"이름은 {name}, 나이는 {age}");
            }
        }
    }
}

/*
if문

조건식이 참일때 실행문을 실행
조건식이 거짓이면 실행문을 실행하지 않음

만약 조건식이 참이면 {} 안에 있는 실행문을 실행하라.
if(조건식)
{
    // 실행문1
    // 실행문2
    //......
}

else문 : if문과 함께 사용
- 만약 조건식이 참이라면 실행문1만 실행, else문의 실행문2는 실행하지 않음
- 만약 조건식이 거짓이라면 실행문2만 실행, if문의 실행문1은 실행하지 않음

if()
{
    // 실행문1
}
else
{
    // 실행문2
}
// 실행문3

1. 조건식이 참
실행문1 -> 실행문3 실행

2. 조건식이 거짓
실행문2 -> 실행문3 실행



else if 문 : if 문과 같이 사용

if(조건식)
{
    // 실행문1
}
else if(조건식)
{
    // 실행문2
}
else
{
    // 실행문3
}

// 실행문4

[1] 조건식 1이 참이면
실행문1 -> 실행문4

[2] 조건식1이 거짓이고, 조건식2가 참이면
실행문2 -> 실행문4

[3] 조건식1과 조건식2가 거짓이면
실행문3 -> 실행문4

[4] 조건식1이 참이고 조건식2가 참이면?
실행문1 -> 실행문4

no 의미

*/