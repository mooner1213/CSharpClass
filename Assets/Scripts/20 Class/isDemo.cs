using UnityEngine;

public class isDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // 정수형 변수 선언하고 초기화
        int i = 1234;
        // object 형 변수 선언하고 i 값 저장
        object o = i;

        Debug.Log(o);

        // object형 변수 선언하고 5678로 초기화
        object ob = 5678;
        // 정수형 변수 선언하고 object 값 가져오기
        // 명시적 형식 변환, 캐스팅, 캐스트
        // 언박싱
        int num = (int)ob;
        //
        Debug.Log(num);
    }
}

/*
 
데이터 타입 : 변수가 값을 저장하는 방식 분류
값 형식(value type) : 객체에 값 자체를 담고 있는 구조, int, long, float, double, 구조체
참조형식(reference value) : 객체에 값을 담고 있고 또 다른 객체를 포인터로 바라보는 구조, string
 
 object : c# 에서 제공하는 모든 자료형의 부모, object 형식의 변수는 모든 형식의 값 할당이 가능
 
// 박싱(boxing) : 값 형식의 데이터를 참조형식의 데이터로 변경하는 것
// 언박싱(unboxing) : 참조 형식의 데이터를 값 형식의 데이터로 변경 - 캐스트, 캐스팅

 */