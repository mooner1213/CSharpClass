using UnityEngine;

namespace Method
{
    // [2] 참조 전달 방법 : (ref int num)
    public class ParameterRef : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            int num = 10;
            Debug.Log($"[1] : {num}");        // [1] : 10

            // 참조 전달 형식 메서드 호출
            PrintNumber(ref num);

            Debug.Log($"[3] : {num}");        // [3] : 20
        }

        // 매개변수로 참조 전달된 정수값을 출력하는 함수
        private void PrintNumber(ref int num)
        {
            num = 20;
            Debug.Log($"[2] : {num}");        // [2] : 20
        }
    }
}