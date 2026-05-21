using UnityEngine;

namespace CustomGeneric
{
    // 제네릭 클래스 만들기 : 설계
    // 형식 : public class 클래스이름<T> {}
    public class Hello<T>
    {
        // 필드
        private T _message;

        // 생성자 : 데이터 타입의 기본값으로 초기화
        public Hello()
        {
            _message = default(T); // T의 기본값으로 초기화
        }

        // 매개변수로 들어온 값으로 초기화
        public Hello(T message)
        {
            this._message = message;
        }

        public void Say(T message) => Debug.Log(message);
        public T GetMessage() => this._message;
    }
}