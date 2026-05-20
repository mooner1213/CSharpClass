using UnityEngine;

namespace Inheritance
{
    //자식 클래스 선언
    public class SubClass : BaseClass
    {
        public void ShowMessage()
        {
            Debug.Log("자식 클래스에서 정의한 내용");

            base.PrintMessage(); //부모클래스의 protected한 메서드 호출
        }
    }
}