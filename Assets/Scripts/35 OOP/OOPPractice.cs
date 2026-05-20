using UnityEngine;
using System.Collections.Generic;
using System.Collections;
// [1] 네임스페이스 정의 : 클래스이름 충돌 방지, 같은 성격의 클래스 묶기
namespace OOP
{
    // [2] 인터페이스 : 상속박는 클래스가 구현해야 할 기능들을 정의(설계, 표준), 다중상속 가능
    // 객체지향 프로그래밍 예제
    public interface IStandard
    {
        // 가능 정의 목록 - 본문, 코드블록 생략
        void Run();
    }

    /// <summary>
    /// [3] 클래스 : 객체의 설계도
    /// </summary>
    public class Car : IStandard
    {
        #region [4] 필드(전역변수, 멤버변수) : private, Memver Variable
        private string name;    // 이름을 저장하는 전역변수
        private string[] names;   // 배열 필드
        private readonly int LENGTH;    // 읽기전용 필드
        #endregion

        #region [5] 생성자(Constructor) : 필드 초기화
        public Car()    // 기본 생성자
        {
            this.name = "좋은 차";
        }

        public Car(string name)
        {
            this.name = name;
        }

        public Car(int length)
        {
            this.name = "좋은 차"; // 필드 초기화
            LENGTH = length;       // 읽기전용 필드는 생성자안에서 초기화 가능
            names = new string[length]; // 입력받은 길이만큼 배열 요소수 생성
        }
        #endregion

        #region [6] 메서드(Method) : 기능 / 동작, private
        public void Run() => Debug.Log($"{name} 자동차가 달린다.");
        #endregion

        #region [7] 속성(Property) : private한 필드를 public한 속성으로 외부에서 접근
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public int Length
        {
            get { return this.LENGTH; }
        }
        #endregion

        #region [8] 소멸자(Destructor) : new로 생성된 객체가 소멸될때 마지막으로 호출
        ~Car()
        {
            Debug.Log($"{this.name}가 폐차되었습니다.");
        }
        #endregion

        #region [9] 인덱서(Indexer) : 배열처럼 객체에 인덱스로 접근하는 기능
        public string this[int index]
        {
            get { return names[index]; }
            set { names[index] = value; }
        }

        #endregion

        #region [10] 이터레이터 (Iterator) : 반복기, 인덱서를 foreach문에서 사용가능
        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < LENGTH; i++)
            {
                yield return names[i];
            }
        }
        #endregion

        #region [11] 대리자(Delegate) : 다중 메서드 등록 후 호출 가능
        public delegate void EventHandler();
        #endregion
    }

    public class OOPPractice : MonoBehaviour
    {

        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            // [1] 클래스의 인스턴스 생성, 메서드 호풀
            Car CampingCar = new Car("캠핑카");
            CampingCar.Run();   // "캠핑카가 달립니다.

            // [2] 클래스의 인스턴스 생성, 속성 이용
            Car SportsCar = new Car("스포츠카");
            SportsCar.Name = "스포츠카";
            SportsCar.Run();
        }
    }
}