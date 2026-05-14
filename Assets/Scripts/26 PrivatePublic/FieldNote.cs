using UnityEngine;

namespace PrivatePublic
{
    public class FieldNote : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //[1] User 클래스의 인스턴스 생성
            User myUser = new User();

            //[2] User 클래스의 public 필드 접근해서 사용하기
            myUser.name = "홍길동";
            Debug.Log(myUser.name);

            //[3] User 클래스의 private한 필드 접근해서 사용하기 - 접근 불가
            //myUser.age = 21;
            //myUser.address = "서울";

            //[4] User 클래스의 public 메서드 호출하기
            myUser.Hi();

            //[4] User 클래스의 private 메서드 호출하기 - 호출 불가
            //myUser.Bye();

            //[5] User 클래스의 private한 필드 age를 수정, 사용하기
            //myUser.age = 21;
            //Debug.Log(myUser.age);
            myUser.SetAge(21);
            Debug.Log(myUser.GetAge());

        }
    }
}