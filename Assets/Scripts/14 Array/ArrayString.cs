using UnityEngine;

// string : 문자열 데이터 -> 문자의 배열
public class ArrayString : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // 문자열 변수 선언하고 초기화
        string arr = "C#8";

        Debug.Log(arr[0]);
        Debug.Log(arr[1]);
        Debug.Log(arr[2]);

        // 문자열 길이
        Debug.Log($"문자열 길이 : {arr.Length}");
    }
}
