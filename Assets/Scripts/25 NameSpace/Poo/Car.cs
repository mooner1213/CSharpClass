//using UnityEngine;

//네임스페이스로 묶는다
namespace Poo
{
    public class Car
    {
        //인스턴스 메서드
        public void Go()
        {
            //네임스페이스.클래스.메서드()
            UnityEngine.Debug.Log("[2]Poo네임스페이스의 Car 클래스 호출");
        }
    }
}