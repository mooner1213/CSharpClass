using UnityEngine;

namespace Override
{
    public class OverrideDemo : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            // Child 클래스의 인스턴스 생성
            Child child = new Child();

            child.Say();    // [1] 재사용
            child.Run();    // [2] new
            child.Walk();   // [3] virtual -> override
        }
    }
}

/*
 
메서드 오버라이드(Override) 
: 상속과 관련
: 자식 클래스가 부모 클래스의 메서드를 재정의해서 사용한다.

메서드 오버로드(Overload)
: 상속과 무관
: 하나의 클래스 안에서 매개변수가 다른 같은 이름의 함수를 만드는 것
 
*/