using UnityEngine;

namespace OOP
{
    public class OOPDemo : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            Person person = new Person();
            person.SetName("홍길동");
            Debug.Log(person.GetName());
        }
    }
    // 캡슐화 : 필드는 기본적으로 private, 외부에 노출하지 않는다.
    public class Person
    {
        // [1] 필드
        private string name;

        // [2] 메서드 : public한 메서드로 private한 필드를 외부에서 읽고 쓴다.
        public void SetName(string name) => this.name = name;
        public string GetName() => this.name;
    }
}

/*
 
클래스 : 설계도
-- 네임스페이스, 필드. 생성자, 메서드, 속성, 인덱서, 델리게이트
객체 생성 : 실체
== 객체 지향 프로그래밍 특성
: 상속
: 캡슐화
: 다형성
: 추상화

 */