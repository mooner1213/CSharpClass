using UnityEngine;

// AndOperator (And 연산자, &&) 두 개의 조건이 모두 참이면, 참을 반환한다.
// 결과 : true, false
// bool 형이 두개 합쳐서 연산할 때, 둘다 참이면 참이다. 외에는 모두 거짓.
public class AndOperator : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [1] 둘 다 참일때

        Debug.Log(true && true); // true

        // [2] 둘 중 하나라도 거짓일 때
        
        Debug.Log(true && false); // false
        Debug.Log(false && true); // false

        // [3] 둘 다 거짓일 때

        Debug.Log(false && false); // false
    }
}
