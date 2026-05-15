    using UnityEngine;

    public class ParameterIn : MonoBehaviour
    {
        // [1] 값 전달 방법
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            int num = 10;
            Debug.Log($"[1] : {num}");  // [1] : 10

            PrintNumber(num);

            Debug.Log($"[3] : {num}");  // [3] : 10

        }

        // 매개변수로 전달된 정수 값을 출력하는 함수
        private void PrintNumber(int num)
        {
            num = 20;
            Debug.Log($"[2] : {num}");        // [2] : 20
        }

    }

    /*

    Parameter(매개변수) : 연산에 필요한 데이터를 함수 호출 시, 전달해준다.
    = 매개변수 전달 방법 분류

    [1] 값 전달 방법 : (int num)
    [2] 참조 전달 방법 : (ref int num)
    [3] 반환형 전달 방법 : (out int num)

    [4] 가변형 전달 방법 : (params int[] numbers)
 
    */