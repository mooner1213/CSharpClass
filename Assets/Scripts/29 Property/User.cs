using UnityEngine;

namespace Property
{
    // 유저정보를 관리하는 클래스
    public class User
    {
        // 필드
        private int birthYear; // 생년

        // 자동 속성
        public string Name { get; set; }

        // 읽기 전용 속성 : 외부에서 set으로 접근 불가, 내부에선 접근 가능
        public string Messege { get; private set; } = "읽기 전용 속성";

        // 쓰기 전용 속성 : 식
        public int BirthYear
        {
            set 
            {
                // 입력값 검증식 넣기
                if (value >= 1900)
                {
                    { birthYear = value; }
                }
                else
                {
                    birthYear = 0;
                }
            }
        }

        // 나이를 반환하는 읽기 전용 속성
        public int Age
        {
            get
            {
                // 계산식 결과 반환하기
                return (System.DateTime.Now.Year - birthYear);
            }
        }

        // 생성자 - 매개변수 받아서 속성 초기화
        public User(string name)
        {
            Name = name;
        }
    }
}