using UnityEngine;

namespace Constructor
{
    // 유저를 관리하는 클래스
    public class User
    {
        // [1] 필드
        private string name;
        private int age;

        // [2] 생성자 - 매개변수 X (기본 생성자)
        public User()
        {
            name = "홍길동";
            age = 20;
        }

        // [3-1] 생성자 - 매개변수가 있는 생성자
        /*public User(string _name)
        {
            name = _name;
            age = 20;
        }*/

        // [3-2] 생성자 - 매개변수가 있는 생성자
        public User(string name, int age = 20)
        {
            this.name = name;
            this.age = age;
        }
        
        // [4] 이름을 반환하는 함수
        public string GetName()
        {
            return name;
        }

        // [5] 유저 정보를 출력하는 함수
        public void ShowUserInfo()
        {
            Debug.Log($"이름은 {name}, 나이는 {age}");
        }
    }
}