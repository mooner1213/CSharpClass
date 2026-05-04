using UnityEngine;


public class SwapDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int i = 100;
        int j = 200;

        Debug.Log($"i = {i}");
        Debug.Log($"j = {j}");

        int temp = i; // 임시 변수에 i의 값을 저장
        i = j;
        j = temp;

        Debug.Log($"i = {i}");
        Debug.Log($"j = {j}");
    }
}

/*
[Q]
 +, - 다른 연산 없이 변수 i, j의 값을 서로 바꾸어서 저장하세요.
 
 [output]
처음에 저장하는 값

i = 100
j = 200

변경시 결과

i = 200
j = 100
 */