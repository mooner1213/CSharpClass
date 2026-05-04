using UnityEngine;

// 데이터 값 (Literal) : 변수에 저장할 데이터 값의 종류
public class VariableLiteral : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [1] 변수 만들기(선언)
        int num; // 정수형 변수(-1, 0, 1)
        double su; // 실수형 변수(3.141592)
        bool flag; // 부울형 변수(논리형 변수 / 참, 거짓 판별)
        string str; // 문자열 변수("Hello")
        char c; // 문자형 변수('A', '문')

        // [2] 변수에 데이터 값 저장하기
        num = 1234;
        su = 3.141592;
        flag = true;
        str = "반갑습네다.";
        c = 'B';

        // [3] 변수에 저장된 데이터 값 사용하기
        Debug.Log("num:" + num);
        Debug.Log("su:" + su);
        Debug.Log("flag:" + flag);
        Debug.Log("str:" + str);
        Debug.Log("c:" + c);
    }
}
