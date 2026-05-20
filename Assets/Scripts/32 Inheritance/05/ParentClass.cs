using UnityEngine;

namespace InheritanceTest
{
    //부모 클래스
    public class ParentClass
    {
        //필드
        private string name;

        //생성자 - 매개변수를 통해 name 초기화
        public ParentClass(string name)
        {
            this.name = name;
        }

        //메서드
        public void Run() => Debug.Log($"이름은 {name}");

    }
}