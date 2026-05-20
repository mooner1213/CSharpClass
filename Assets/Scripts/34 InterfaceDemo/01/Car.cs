using UnityEngine;

namespace Interface
{
    // 인터페이스 ICar 를 상속받는 자동차를 관리하는 클래스
    public class Car : ICar
    {
        // 인터페이스에서 정의된 함수 구현
        public void Go()
        {
            Debug.Log("상속받은 인터페이스에서 정의된 멤버 구현");
        }
    }
}