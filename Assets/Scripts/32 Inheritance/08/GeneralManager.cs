using UnityEngine;

namespace Abstract
{
    //추상(부모) 클래스: 지정한 기능을 자식클래스가 구현하도록 강제한다    
    public abstract class GeneralManager
    {
        //추상 메서드
        public abstract void SayTalk();
    }

    //GeneralManager 추상클래스를 상속받는 자식클래스
    public class Person : GeneralManager
    {
        //상속 받은 추상클래스의 추상 메서드 구현부분
        public override void SayTalk()
        {
            Debug.Log("상속받은 추상 메서드를 구현한다");
        }
    }

}

/*
//추상 메서드: 지정한 기능
: 메서드 구현 부분(본문, 코드블록)이 생략

//추상 메서드 형식
public abstract void 추상메서드이름 ();


*/