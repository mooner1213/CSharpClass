using UnityEngine;

namespace Property
{
    public class PropertyDemo : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            /*// person 클래스의 인스턴스 생성
            Person person = new Person();

            // 메서드 사용
            person.SetName("홍길동");
            Debug.Log($"이름은 {person.GetName()}");

            // property (속성) 사용 - 사용 시 변수와 동일한 방법으로 사용
            person.Name = "백두산";
            Debug.Log($"이름은 {person.Name}");*/

            /* Truck truck1 = new Truck();
             truck1.Name = "덤프트럭";
             Debug.Log(truck1.Name);

             Truck truck2 = new Truck();
             truck2.Name = "카고트럭";
             truck2.Color = "Red";
             truck2.Number = 9876;
             Debug.Log($"이름 : {truck2.Name}, 색 : {truck2.Color}, 번호 : {truck2.Number}");*/

            /*// User 클래스의 인스턴스 생성
            User user = new User("홍길동");
            user.BirthYear = 2000;
            Debug.Log($"이름 : {user.Name}, 나이 : {user.Age} ");*/

            // 속성 초기화
            // Student 클래스의 인스턴스 생성
            Student s1 = new Student();
            s1.Name = "홍길동";
            s1.Age = 20;
            Debug.Log($"이름 : {s1.Name}, 나이 : {s1.Age}, 번호 : {s1.Number}");

            // 개체 이니셜 라이져를 사용하여 개체 초기화
            Student s2 = new Student() { Name = "백두산", Age = 25, Number = 2 };
            // 주소는 함수를 이용하여 쓴다.
            s2.SetAddress("서울시");
            Debug.Log($"이름 : {s2.Name}, 나이 : {s2.Age}, 번호 : {s2.Number}, 주소 : {s2.GetAddress()}");
        }
    }
}

/*
 
Property(속성) : 필드의 값을 읽거나 쓰거나 연산하는 방법을 제공하는 클래스 멤버
: 필드는 기본적으로 private (외부에서 접근 제한)
: 속성은 제한된 외부에서 읽거나 쓰기가 가능하도록 해줌.
: 변수와 동일한 방법으로 사용

네이밍 : 속성이름은 첫 문자를 대문자로 쓺.

Property 형식
public [반환 타입] 속성이름
{
    get;
    get;
}
 
ex)
        public string Name
        {
            get { return name; } : 필드값 반환

            person.Name = "백두산";
            set { name = value; } : value 값을 필드에 저장
        }

*/