using UnityEngine;

namespace Constructor
{
    // 자동차를 관리하는 클래스
    public class Car
    {
        // 필드
        private string color;

        // 기본 생성자

        public Car()
        {
            color = "하양";
            Debug.Log($"자동차의 색깔 : {color}");
        }

        // 매개변수가 있는 생성자
        public Car(string color)
        {
            this.color = color;
            Debug.Log($"자동차의 색깔 : {this.color}");
        }

        // 메서드
        public void Run()
        {
            Debug.Log($"자동차의 색깔 : {this.color}");
        }

        // 소멸자

        ~Car()
        {
            Debug.Log($"{this.color}색 자동차를 폐기합니다.");
        }
    }
}