using UnityEngine;

namespace Delegate
{
    //대리자 선언 - 반환값없고 매개변수 없다
    //public delegate void GoHome();

    public class DelegatePractice : MonoBehaviour
    {
        //대리자 선언 - 반환값없고 매개변수 없다
        delegate void GoHome();
        GoHome goHome;              //대리자 변수, 대리운전자

        //대리지 선언
        delegate void Say();

        //C#에서 제공해주는 델리게이트 함수
        System.Action driver;

        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //직접 운전
            CarDriver.GoForward();
            CarDriver.GoRight();
            CarDriver.GoForward();
            CarDriver.GoLeft();

            Debug.Log("=====================");
            //대리 운전
            goHome = new GoHome(CarDriver.GoForward);
            goHome += new GoHome(CarDriver.GoRight);
            goHome += new GoHome(CarDriver.GoForward);
            goHome += new GoHome(CarDriver.GoLeft);
            goHome += new GoHome(CarDriver.GoForward);  //메서드 등록
            goHome -= new GoHome(CarDriver.GoForward);  //메서드 취소

            //대리자 실행
            goHome();

            Debug.Log("=====================");
            //델리게이트 변수 선언 및 메서드 등록
            Say say = new Say(Hi);
            say += Hello;

            Insa insa = new Insa();
            say += insa.Bye;

            //대리자 호출
            say.Invoke();

            Debug.Log("=====================");
            //System Action 함수
            driver = CarDriver.GoForward;
            driver += CarDriver.GoRight;
            driver += CarDriver.GoForward;
            driver += CarDriver.GoLeft;
            driver.Invoke();
        }


        //메서드
        void Hi()
        {
            Debug.Log("안녕하세요");
        }

        void Hello() => Debug.Log("반갑습니다");

    }
}