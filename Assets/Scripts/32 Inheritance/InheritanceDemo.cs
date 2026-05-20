using UnityEngine;

namespace Inheritance
{
    public class InheritanceDemo : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            /*//Child클래스의 인스턴스 생성
            Child child = new Child();
            child.Poo();    //부모 클래스의 메서드 호출
            child.Bar();    //자식 클래스의 메서드 호출*/

            //정적(static) 메서드 호출: 클래스이름.메서드이름
            //ChlidClass.Hi();        //부모 클래스의 정적 메서드 호출
            //ChlidClass.Hello();     //자식 클래스의 정적 메서드 호출

            //protected 메서드 사용
            //[1] Base클래스의 인스턴스 생성
            BaseClass parent = new BaseClass();
            //parent.PrintMessage();    // protected 는 외부에서 접근불가
            Debug.Log(parent.ToString());

            //[2]Child 클래스의 인스턴스 생성
            SubClass child = new SubClass();
            child.ShowMessage();


        }
    }
}

/*
Inheritance(상속) : 부모클래스가 자신의 기능을 자식클래스에게 물려주어서 사용할도록 해준다
부모클래스(Base클래스, 슈퍼클래스, 기본클래스) - 자식 클래스를 여러개 가질수 있다
자식클래스(Sub클래스)
손자클래스: 자식클래스의 자식 클래스, 부모클래스와 자식클래스의 기능을 물려받는다

== 부모가 허락한 것만 접근해서 사용 가능하다
== public, private, protected
protected(접근 제한자) : private와 동일, 단 상속받은 자식 클래스는 접근 가능하다

=부모클래스와 자식 클래스 성립
:자식클래스에서 부모클래스를 지정한다
public class 자식클래스이름 : 부모클래스 이름
{
}


*/