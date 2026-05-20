using UnityEngine;

namespace Inheritance
{
    //자식클래스
    public class Child : Parent
    {
        public void Bar()
        {
            Debug.Log("자식 클래스의 멤버함수 호출");
        }
    }
}