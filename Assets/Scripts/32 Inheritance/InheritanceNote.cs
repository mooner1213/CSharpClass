using UnityEngine;

namespace InheritanceTest
{
    public class InheritanceNote : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            /*//Child 클래스의 인스턴스 생성
            Child child = new Child();
            child.Do(); //부모클래스에서 정의된(public, protected) 메서드 호출

            //Dog 클래스의 인스턴스 생성
            Dog dog = new Dog();
            //Debug.Log(dog.ToString());
            print(dog.ToString());*/


            //ChildClass의 인스턴스 생성
            ChildClass child1 = new ChildClass();
            child1.Run();

            ChildClass child2 = new ChildClass("백두산");
            child2.Run();

        }
    }
}