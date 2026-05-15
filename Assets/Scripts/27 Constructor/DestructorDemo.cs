using UnityEngine;

namespace Constructor
{
    public class DestructorDemo : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            // 소멸자 테스트
            // DestructorTest클래스의 인스턴스 생성

            DestructorTest destructorTest = new DestructorTest();
            // 인스턴스 사용
            destructorTest.Run();

            // 소멸자 호출 - 가비지 켈렉터(GC)가 대신 해준다.
            // ~DestructorTest();

            // Car 클래스의 인슽언스 생성
            // 하얀차, 파란차, 빨간차 만들기

            Car whiteCar = new Car();
            whiteCar.Run();

            Car blueCar = new Car("파랑");
            blueCar.Run();

            Car redCar = new Car("빨간");
            redCar.Run();

            // 폐차는 GC가 알아서 함.
        }
    }
}

/*
 
Destructor(소멸자) : 클래스가 사용된 후 가장 마지막에 호출되는 메서드
: 생성된 객체(인스턴스)가 메모리상에서 없어질 떄 호출
: 클래스에서 사용되는 메모리 해제 등

c# 메모리 해제 : 가비지 컬렉터(GC)가 알아서 함
 
 class Dog(클래스이름)
{
    // 생성자
    public Dog()
    {
        
    }

    // 소멸자
    ~Dog()
    {
        // 개체가 소멸할 때 필요한 기능 수행
    }

}
 
 */