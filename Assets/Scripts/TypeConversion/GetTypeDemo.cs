using UnityEngine;

public class GetTypeDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // 변수의 타입 알아보기
        int i = 1234;
        string s = "안녕하세요";
        char c = 'a';
        double d = 3.14;

        Debug.Log(i.GetType()); // i 변수의 타입을 콘솔창에 출력
        Debug.Log(s.GetType()); // s 변수의 타입을 콘솔창에 출력
        Debug.Log(c.GetType()); // c 변수의 타입을 콘솔창에 출력
        Debug.Log(d.GetType()); // d 변수의 타입을 콘솔창에 출력
    }
}
