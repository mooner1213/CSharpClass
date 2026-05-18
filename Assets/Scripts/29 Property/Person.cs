    using UnityEngine;

    namespace Property
    {
        // 사람을 관리하는 클래스
        public class Person
        {
            // 필드
            private string name;    // 사람 이름

            // 속성
            // public한 property를 이용하여 private한 name을 외부에서 읽고 쓰기 구현
            public string Name
            {
                get { return name; }
                set { name = value; }
            }

            // 메서드
            // public 한 메서드를 이용, private한 name 을 외부에서 읽고 쓰기 구현

            public string GetName()
            {
                return name;
            }

            public void SetName(string newName)
            {
                name= newName;
            }
        }
    }