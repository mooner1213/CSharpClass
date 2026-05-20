using System.Xml.Linq;
using UnityEngine;

namespace InheritanceTest
{
    //자식 클래스
    public class ChildClass : ParentClass
    {
        //생성자 - 필드 초기화
        public ChildClass() : this("홍길동")
        {
            
        }

        public ChildClass(string name) : base(name)
        {

        }
    }
}