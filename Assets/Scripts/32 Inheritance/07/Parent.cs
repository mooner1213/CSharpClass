using UnityEngine;

namespace Abstract
{
    //부모 클래스, 추상 클래스
    public abstract class Parent
    {
        public int Id { get; set; }
        public bool Active { get; set; }
    }

    //자식 클래스
    public class Child : Parent
    {
        public string Name { get; set; }
    }
}