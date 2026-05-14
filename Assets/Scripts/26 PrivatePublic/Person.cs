using UnityEngine;

namespace PrivatePublic
{
    //유저를 (속성, 상태, 기능) 관리하는 클래스
    public class Person
    {
        //필드 선언부 - 필드의 종류
        //[1]변수 형식의 필드
        string name = "홍길동";
        //[2]상수 형식의 필드
        const int AGE = 20;
        //[3]읽기전용 형식의 필드
        readonly string NICKNAME = "도깨비";
        //[4]배열 형식의 필드
        string[] adress = { "서울", "부산", "인천" };
        //[5]object 형식의 필드
        object all = System.DateTime.Now.ToShortTimeString();

        //[6] 유저 정보를 출력하는 함수
        public void ShowProfile()
        {
            Debug.Log($"이름:{name}, 나이:{AGE}, 별명: {NICKNAME}");
        }

    }
}