using UnityEngine;

public class ClassTwo
{
    // [1] 정적(static) 멤버 함수
    public static void Hi()
    {
        Debug.Log("반갑습니다.");
    }

    // [2] 인스턴스(instance) 멤버 메서드 : static 키워드가 없는 함수
    public void Hello()
    {
        Debug.Log("또 만나요.");
    }

}
