using UnityEngine;

public class ArrayIndex : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // 크기가 3인 정수형 배열 선언하고 1,2,3으로 초기화
        int[] numbers = new int[3] { 1, 2, 3 };
        
        // 배열의 인덱스를 관리하는 변수 선언 : 0~2, 0으로 초기화
        int index = 0;

        Debug.Log(numbers[index++]); // 1
        Debug.Log(numbers[index++]); // 2
        Debug.Log(numbers[index++]); // 3

        Debug.Log(numbers[--index]); // 3
        Debug.Log(numbers[--index]); // 2
        Debug.Log(numbers[--index]); // 1
    }
}
