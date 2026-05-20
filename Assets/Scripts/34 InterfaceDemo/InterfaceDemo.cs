using UnityEngine;

namespace Interface
{
    public class InterfaceDemo : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            // Car 인스턴스 생성
            /*var car = new Car();
            car.Go();*/

            // IRepository 개체에 Repositoy 인스턴스를 생성하여 대입
            /*IRepository repository = new Repository();
            repository.Get();*/

            // Dog 클래스의 인스턴스 생성
            // Dog dog = new Dog();
            // dog.Eat();  // IAnimal 인터페이스의 기능
            // dog.Yelp(); // IDog 인터페이스의 기능

            // Pet 클래스의 인스턴스 생성
            Pet pet = new Pet();
            ((IDog)pet).Yelp();
            ((ICat)pet).Yelp();

        }
    }
}

/*
 
Interface : 특정멤버가 반드시 구현되어야 하는것을 보증한다.
: 상속받은 자식클래스가 특정멤버가 반드시 구현하도록 강제한다.
: 상속받는 자식 클래스에서 반드시 구현되어야 하는 기능에 대한 정의 목록

// 기능에 대한 정의 - 본문, 코드블록 {} 가 생략되어 있는 형태
: (반환 데이터 타입) 메서드이름();

// 인터페이스 이름 - 네이밍 방법
: 맨앞의 철자가 'I' 로 시작한다.

// 인터페이스 형태
public interface 인터페이스 이름
{
    // 반드시 구현되어야하는 기능에 대한 정의 목록..
    반환 데이터 타입 메서드이름();
}
 
 */