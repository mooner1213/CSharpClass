using UnityEngine;

// PrefixOperator : 전위연산자 - 앞에 위치하는 증감 연산자
// PostfixOperator : 후위연산자 - 뒤에 위치하는 증감 연산자
public class PrefixOperator : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [1] 전위 증가 연산자
        int i = 3;
        int j = ++i; // i가 먼저 증가한 후 j에 대입

        Debug.Log($"i : {i}"); // 4
        Debug.Log($"j : {j}"); // 4

        j = i++; // j에 먼저 i의 값이 대입된 후 i가 증가

        Debug.Log($"i : {i}"); // 5
        Debug.Log($"j : {j}"); // 4
    }
}