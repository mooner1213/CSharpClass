using UnityEngine;

// OrOperator (Or 연산자, ||) 두 개의 조건 중 하나라도 참이면, 참을 반환한다.
// 결과 : true, false
// bool 형이 두개 합쳐서 연산할 때, 둘 중 하나라도 참이면 참. 둘 다 거짓일 때만 거짓이다.
public class OrOperator : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
        // [1] 둘 다 참일 때
        
        Debug.Log(true || true); // true
        
        // [2] 둘 중 하나라도 참일 때
        
        Debug.Log(true || false); // true
        Debug.Log(false || true); // true
        
        // [3] 둘 다 거짓일 때
        
        Debug.Log(false || false); // false
    }
}
