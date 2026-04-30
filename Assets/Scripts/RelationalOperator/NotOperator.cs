using UnityEngine;

// NotOperator (부정 연산자, !) 참이면 거짓이 되며, 거짓이면 참이 된다.
// 결과 : true, false
public class NotOperator : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log(!true); // false
        Debug.Log(!false); // true

        bool isOut = false;

        Debug.Log(!isOut); // true
        Debug.Log(!!isOut); // false
        Debug.Log(!!!isOut); // true

    }
}
