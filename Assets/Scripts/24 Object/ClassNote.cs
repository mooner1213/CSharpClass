using UnityEngine;

public class ClassNote : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // 다른 클래스의 멤버 호출
        // [1] 정적(static) 멤버 함수 호출 : 클래스 이름.메서드 이름()

        classOne.Hi(); // 안녕하세요 출력

        ClassTwo.Hi(); // 반갑습니다 출력

        // [2] 인스턴스(instance) 멤버 호출
        // 멤버가 속한 클래스의 인스턴스(객체) 생성 : 인스턴스 이름. 메서드 이름()

        ClassTwo ct = new ClassTwo();
        ct.Hello();
    }
}
