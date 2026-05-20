using UnityEngine;

namespace Abstract
{
    public class AbstractDemo : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //부모(추상) 클래스 인스턴스 생성
            //Parent parent = new Parent(); //추상클래스는 인스턴스를 만들지 못한다

            /*//자식 클래스
            var child = new Child() {Id = 1, Active = true, Name = "홍길동" };
            if(child.Active == true)
            {
                Debug.Log($"{child.Id} - {child.Name}");
            }*/

            //Person클래스의 인스턴스 생성
            //Person person = new Person();
            //person.SayTalk();

            // 사각형, 원 면적 구하기

            Squre squre = new Squre(10);
            Debug.Log($"사각형의 면적은 {squre.GetArea()}");

            Circle ra = new Circle(10);
            Debug.Log($"원의 면적은 {ra.GetArea()}");

        }
    }
}

/*
Abstract Class(추상 클래스) : 자신을 상속 받는 클래스에서 강제로 기능을 추가하도록 한다
: 추상클래스가 지정한 기능을 자식클래스가 구현하도록 강제한다
: 추상클래스는 인스턴스(객체)를 만들수 없습니다.  new Class이름 (x)
: 추상클래스는 다른 클래스의 부모 클래스로만 사용이 가능

추상 클래스 형태
public abstract class (추상클래스 이름)
{

}
*/