using UnityEngine;

namespace Method
{
    public class MethodDemo : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            // Dog 클래스의 인스턴스 생성
            Dog dog = new Dog();

            dog.Eat();          // public 인스턴스 메서드
            // dog.Digest();    // error, private 인스턴스 메서드

            // dog.Drink();     // error, 정적 메서드, 인스턴스 이름으로 호출 불가
            Dog.Drink();        // 클래스 이름.메서드() 호출
        }
    }
}

/*
 
method(메서드, 함수, function)
: 클래스가 수행하는 기능을 하나의 이름으로 묶어서 관리하는 코드블록
: 클래스의 기능 구현

= 메서드 네이밍
: 동사 + 명사
: GetName, SetName, GetHp

[1] 메서드 구성요소

public(private) static(x) void(반환값, int, string, bool, object) 메서드 이름(매개변수
{
    // 실행 명령문들
}

 */