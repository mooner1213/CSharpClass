using UnityEngine;

namespace Constructor
{
    // 강아지를 관리하는 클래스
    public class Dog
    {
        // [1] 필드
        private string name;    // 이름

        // [2] 생성자 - 필드 초기값 설정
        // 매개변수로 문자열을 받아서 name 값에 대입
        // 생성자 호출 시 강아지 이름을 만들어 준다.
        public Dog(string str)
        {
            name = str;
        }

        // [3] 메서드 - 강아지 이름을 반환하는 함수
        public string GetName()
        {
            return name;
        }
    }
}