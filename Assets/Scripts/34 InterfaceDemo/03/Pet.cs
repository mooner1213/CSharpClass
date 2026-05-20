using UnityEngine;

namespace Interface
{
    // 펫을 관리하는 클래스
    // 강아지와 고양이의 기능 모두 갖는다.
    public class Pet : IDog, ICat
    {
        void IDog.Yelp()
        {
            Debug.Log("강아지가 짖습니다.");
        }

        void ICat.Yelp()
        {
            Debug.Log("고양이가 짖습니다.");
        }
    }
}