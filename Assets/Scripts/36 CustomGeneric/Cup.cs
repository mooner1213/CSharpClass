using UnityEngine;

namespace CustomGeneric
{
    // 제네릭 클래스 : 전용 컵
    // 형식 매개변수 T에 지정한 데이터 형식으로 클래스에 멤버의 성질을 결정
    // 형식 : public class 클래스이름<T> {}
    public class Cup<T>
    {
        public T Content { get; set; }

        // 매개변수로 들어온 데이터를 출력
        /*public void PrintData(T data)
        {
            Debug.Log(data);
        }*/
    }

    public class Water { }
    public class Coffee { }
}