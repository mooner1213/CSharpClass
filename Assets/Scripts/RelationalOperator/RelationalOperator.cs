using UnityEngine;

// RelationalOperator : 관계 연산자(비교 연산자) - <, >, <=, >=, ==, !=
// 연산 결과 : true 또는 false (논리형 데이터)
public class RelationalOperator : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int a = 3; int b = 5;

        Debug.Log(a < b); // a는 b보다 작은가? : 결과 값 - true
        Debug.Log(a <= b); // a는 b보다 작거나 같은가? : 결과 값 - true
        Debug.Log(a > b); // a는 b보다 큰가? : 결과 값 - false
        Debug.Log(a >= b); // a는 b보다 크거나 같은가? : 결과 값 - false
        Debug.Log(a == b); // a는 b와 같은가? : 결과 값 - false
        Debug.Log(a != b); // a는 b와 다른가? : 결과 값 - true

        Debug.Log("AAA" == "aaa"); // 문자열 비교 : 결과 값 - false

    }
}
