using UnityEngine;

namespace Abstract
{
    // 모든 도형을 관리하는 부모클래스
    public abstract class Shape
    {
        // 추상메서드 - 도형의 면적을 구하는 기능
        public abstract double GetArea();
    }

    // 사각형을 관리하는 클래스 - shape클래스를 상속받는다.
    public class Squre : Shape
    {
        // 필드
        private int size;

        // 생성자 - 매개변수로 사이즈를 입력받는다.
        public Squre(int _size)
        {
            this.size = _size;
        }

        // 부모클래스의 추상메서드 구현 - 필수
        public override double GetArea()
        {
            return size * size;
        }
    }

    // 원을 관리하는 클래스 - Shape 상속 받는다.
    // 생성자에서 반지름을 상속받아 필드로 저장한다.
    // 부모클래스의 추상메서드 구현 - 필수

    public class Circle : Shape
    {
        private int radius;
        public Circle(int ra)
        {
            this.radius = ra;
        } 
        public override double GetArea()
        {
            return radius * radius * System.Math.PI;
        }
    }
}