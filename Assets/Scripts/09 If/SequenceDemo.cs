using UnityEngine;

// 순차문 : 위에서 아래로 순서대로 명령문을 실행
public class SequenceDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // 국어점수와 영어점수로 총점을 구하고 평균을 구하는 프로그램

        int kor = 100;
        int eng = 90;
        
        int total = 0;
        double avg = 0.0;

        total = kor + eng;// 총점 구하기
        avg = total / 2.0;// 평균 구하기

        Debug.Log($"총점 : {total}");
        Debug.Log( $"평균 : {avg:F1}"); // 소수 첫째 자리까지 출력
    }
}

/*
= 제어문 : 프로그램의 흐름(순서)를 정하는 명령문.
    - 순차문 : 위에서 아래로 순서대로 명령문을 실행
    - 조건문 : 조건에 맞는 명령문을 실행
    - 반복문 : 정해진 숫자만큼 명령문을 반복하여 실행
    - 기타 : 기타 제어문
*/