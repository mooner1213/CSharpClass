using UnityEngine;

// 기본 클래스
public class ClassMember
{
    // [1] 정적(static) 메서드
    public static void StaticMethod()
    {
        Debug.Log("[1] 정적메서드");
    }

    // [2] 인스턴스 메서드
    public void InstanceMethod()
    {
        Debug.Log("[2] 인스턴스 메서드");
    }
}
