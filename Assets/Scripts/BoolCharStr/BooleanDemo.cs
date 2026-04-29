using UnityEngine;

public class BooleanDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [1] bool형 변수 선언하고 초기화하기
        bool bIn = true; // 참
        Debug.Log("bIn: " + bIn);

        bool isOut = false; // 거짓
        Debug.Log("isOut: " + isOut);
    }
}
