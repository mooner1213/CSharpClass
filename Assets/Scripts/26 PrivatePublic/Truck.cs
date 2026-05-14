using UnityEngine;

namespace PrivatePublic
{
    //트럭을 관리하는 클래스
    public class Truck
    {
        //필드 선언부
        //스태틱 필드 - 문자열 (정적) 멤버 변수 선언하고 초기화 
        public static string name = "트럭";
        //인스턴스 필드
        private int age;

        //이름을 반환하는 정적 함수 구현
        public static string GetName()
        {
            return name;
        }

        //나이를 저장하는 인스턴스 함수
        public void SetAge(int value)
        {
            age = value;
        }

        //나이를 반환하는 인스턴스 함수
        public int GetAge()
        {
            return age;
        }

    }
}