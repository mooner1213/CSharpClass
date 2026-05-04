using UnityEngine;

// 증가 연산자 (++) : 정수형 변수의 값을 1씩 증가
public class IncrementOperator : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [1] 증가 연산자
        int num = 100;

        // 1씩 증가
        // num = num + 1;
        // num += 1;
        ++num; // 전위 증가 연산자

        Debug.Log($"num : {num}"); // 101

        // [2] 감소 연산자
        --num; // 전위 감소 연산자
        Debug.Log($"num : {num}"); // 100
    }
}
