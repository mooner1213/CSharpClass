using UnityEngine;

namespace Constructor
{
    public class ConstructorDemo : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            // Student 클래스의(생성자를 호출하여) 객체(인스턴스)를 생성
            // Student student = new Student();

            // Dog 클래스의 객체(인스턴스)를 생성
            // 매개변수가 있는 생성자를 이용하여 객체 생성
            /* Dog happy = new Dog("해피");
             Debug.Log($"강아지 이름 : {happy.GetName()}");

             // Dog 클래스의 다른 객체(인스턴스)를 생성
             Dog worry = new Dog("워리");
             Debug.Log($"강아지 이름 : {worry.GetName()}");*/

            // User 클래스의 객체(인스턴스) 생성
            // [1] 기본생성자 호출
            User user1 = new User();
            user1.ShowUserInfo();

            // [2] 매개변수가 있는 생성자 호출
            User user2 = new User("백두산");
            user2.ShowUserInfo();

            User user3 = new User("장길산", 25);
            user3.ShowUserInfo();
        }
    }
}


/*
 
 Constructor(생성자) : 클래스가 사용될 때 제일 먼저 호출되는 메서드
: 객체를 생성할 때 호출된다.
: 클래스의 필드의 기본값을 설정하는 역할(필드 초기화), 인스턴스(객체) 초기화

Constructor(생성자) 형식 - 메서드 
- 클래스 이름과 동일한 이름으로 함수 이름을 사용
- 접근제한자는 public 을 사용한다.
- 반환값도 없으며, void 도 없다.

- 생성자를 만들지 않으면, 닷넷에서 기본 생성자를 자동으로 만들어준다.
// 기본 생성자
    public Dog()
    {
        
    }
- 모든 필드는 기본값으로 초기화 된다. : 값형 - 0(zero), 참조형 - null, 

class Dog(클래스이름)
{
    // 생성자
    public Dog()
    {
        
    }
}
 
 */