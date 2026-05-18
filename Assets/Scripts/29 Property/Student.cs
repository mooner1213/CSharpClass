using UnityEngine;

namespace Property
{
    // 학생 정보를 관리하는 클래스
    public class Student
    {
        // 필드
        private string name;
        private string address;

        // 속성
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        // 자동 속성
        public int Age { get; set; }
        public int Number {  get; set; } = 1;

        // 함수
        public string GetAddress()
        {
            return address;
        }
        public void SetAddress(string value)
        {
            address = value;
        }
    }
}