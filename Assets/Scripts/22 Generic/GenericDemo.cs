using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenericDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [1] Stack<T> 클래스 인스턴스 생성 : 문자열 전용
        Stack<string> stack = new Stack<string>();

        // [2] 데이터 넣기
        stack.Push("Ten");
        stack.Push("10");

        // [3] 데이터 꺼내기

        Debug.Log(stack.Pop());
        Debug.Log(stack.Pop());

        // [1] 컬렉션
        Stack st1 = new Stack();
        st1.Push(1234);
        int number1 = (int)st1.Pop();
        Debug.Log(number1);

        // [2] 제네릭 사용 : int 전용
        Stack<int> st2 = new Stack<int>();
        st2.Push(4567);
        int number2 = st2.Pop();
        Debug.Log(number2);

        // [3] 제네릭 클래스의 장점
        // 1. 형식의 안정성
        Stack o = new Stack();
        o.Push(9871);
        o.Push("Hello");
        Debug.Log(o.Pop());
        Debug.Log(o.Pop());

        // 2. 성능, 최적화
        o.Push(1234);   // 1234(값형) -> object형식에 저장 : boxing(박싱)
        int nunber3 = (int)o.Pop(); // object형 -> number3 (값형) : unboxing(언박싱)
        Debug.Log(nunber3);

        Stack<int> i = new Stack<int>();
        i.Push(1);
        // i.Push("Hi");    // 에러
        Debug.Log(i.Pop());

        
    }
}

/*
 
클래스 : 하나의 이름으로 서로 다른 형식의 데이터들과 함수들을 묶어 관리하는 데이터 구조
제네릭 클래스 : 형식 매개 변수 T에 지정한 데이터 형식으로 클래스에 멤버의 성질을 결정
  - Cup<T> : 컵 오브 티, 전용 컵 
 
 */