using UnityEngine;

namespace Override
{
    // 부모 클래스
    public class Parent
    {
        public void Say() => Debug.Log("부모 말한다.");

        public void Run() => Debug.Log("부모 달린다.");

        public virtual void Walk() => Debug.Log("부모 걷다.");
    }
}