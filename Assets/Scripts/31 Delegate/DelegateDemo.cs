using UnityEngine;

namespace Delegate
{
    //Delegate(대리자)
    public class DelegateDemo : MonoBehaviour
    {
        //[1]delegate 선언 - Hi() 메서드 대신 - 반환값없음, 매개변수 없음
        //[1]매개변수가 없고 반환값도 없는 메서드를 대신 실행할 대리자 정의
        delegate void SayDelagate();

        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //메서드 호출
            Hi();

            //[2]대리자 변수 선언 및 메서드 등록 1
            SayDelagate say = new SayDelagate(Hi);
            //대리자 호출 1
            say();

            //[2]대리자 변수 선언 및 메서드 등록 2
            SayDelagate hello = Hi;
            //대리자 호출 2
            //hello();
            hello.Invoke();

        }

        //함수
        void Hi()
        {
            Debug.Log("안녕하세요");
        }

    }
}

/*
Delegate(대리자, 대신 실행자) : 매개변수 목록 및 반환형식이 있는 메서드에 대한 참조를 나타내는 형식
: 등록(지정)한 메서드들을 대신 실행시켜주는 놈
: 하나의 대리자에 여러개의 메서드 등록 가능
: 대리자를 실행시키면 등록된 모든 함수가 동시에 실행된다

형식
//[1]매개변수가 없고 반환값도 없는 메서드를 대신 실행할 대리자 정의,선언,생성
//매개변수가 있고 반한값도 있는 메서드를 대신 실행할 대리자 정의,선언,생성
delegate void (대리자이름) ()
delegate 반환값 타입 (대리자이름) (데이터 타입 변수명, ...)

//[2]변수 선언,정의
(대리자이름) 대리자 변수명;

//[3]대리자 변수에 등록
(대리자이름) 대리자 변수명 = new 대리자이름(등록할 함수 이름)
대리자 변수명 = 등록할 함수 이름
대리자 변수명 += 등록할 함수 이름

//[4]대리자 대리 실행
대리자 변수명();
대리자 변수명.Invoke();

*/