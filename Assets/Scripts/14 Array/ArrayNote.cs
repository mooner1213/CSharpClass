using UnityEngine;

public class ArrayNote : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [1] 배열 선언 및 요소수(개수) 생성, 초기화
        // int[] intArray = new int[3] { 1, 2, 3 };

        // [1-1] 배열 선언 및 요소수(개수) 생성 생략, 초기화
        //int[] intArray = new int[] { 1, 2, 3 };

        // [1-2] 배열 선언과 동시에 값 초기화
        int[] intArray = { 1, 2, 3, 4 };

        // [2] 배열 사용
        for (int i = 0; i < 3; i++)
        {
            Debug.Log($"intArray [{i}] : {intArray[i]}");
        }
    }
}
