using UnityEngine;

namespace Override
{
    // Parent를 상속 받는자식 클래스
    public class Child : Parent
    {
        // public void Say() => Debug.Log("자식 안녕하세욧.");
        public new void Say() => Debug.Log("자식 안녕하세욧.");

        public new void Run() => Debug.Log("자식 달려욧.");

        public override void Walk() => Debug.Log("자식 걸어욧.");
    }
}