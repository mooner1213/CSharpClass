using UnityEngine;

// 변수 (Variable) : 프로그램에서 사용할 데이터를 저장할 수 있는 공간, 혹은 그릇
// 변수 선언 : 데이터 타입 + 변수 이름

public class VariableNote : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [1] 변수 만들기(선언)
        int i; // i 라는 이름으로 정수형 변수를 만든다. (정수형 : 소수점이 없는 숫자, 양수, 음수 모두 가능)

        // [2] 변수에 값 저장하기(대입, 할당, 초기화)
        i = 1234; // i 라는 변수에 1234 라는 값을 저장한다.

        // [3] 변수에 저장된 값 사용하기(참조)
        Debug.Log(i); // i 라는 변수에 저장된 값을 콘솔창에 출력한다.
    }
}