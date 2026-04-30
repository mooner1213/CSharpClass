using UnityEngine;

// + 더하기 연산의 추가 기능 : 문자열 더하기
public class OperatorNote : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Hello" + "World"); // HelloWorld
        Debug.Log("Hi" + " " + "EveryOne"); // Hi EveryOne

        Debug.Log("123" + "456"); // 문자열 + 문자열 = 문자열 취급
        Debug.Log("123" + 456); // 문자열 + 숫자 = 문자열 취급
        Debug.Log(123 + "456" + 789 + 890); // 숫자 + 문자열 + 숫자 + 숫자
        Debug.Log(123 + 456); // 숫자 + 숫자 = 산술 연산

        Debug.Log("123" + true); // 문자열 + bool 형식 = 문자열 취급

        // Debug.Log("123" - 456); // 오류 발생 : 문자열과 숫자 사이의 뺄셈은 불가능
    }
}
