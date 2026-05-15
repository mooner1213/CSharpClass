using UnityEngine;

namespace Method
{
    // 강아지를 관리하는 클래스
    public class Dog
    {
        // [1] 필드
        public int weight = 20; // 인스턴스 멤버 변수
        public static int point = 10;   // 정적 멤버 변수

        // [2] 인스턴스 메서드 : public
        public void Eat()
        {
            Debug.Log("[1] 밥을 먹는다.");

            Digest();
        }

        // [3] 정적 메서드
        public static void Drink()
        {
            Debug.Log("[2] 물을 마신다.");
        }

        // [4] 인스턴스 메서드 : private
        private void Digest()
        {
            Debug.Log("[4] 소화 시킨다.");
        }
    }
}
