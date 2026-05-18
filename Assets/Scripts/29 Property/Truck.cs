using UnityEngine;

namespace Property
{
    // 트럭을 관리하는 클래스
    // 이름, 색상, 번호 데이터 관리
    public class Truck
    {
        // 필드
        private string name;

        // [1] 전체 속성 : 필드를 읽고 쓰는 속성
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        // [2] 자동 속성 : 필드가 없는 속성
        public string Color { get; set; }

        // [3] 자동 속성 선언과 동시에 초기화
        public int Number { get; set; } = 1234;
    }
}