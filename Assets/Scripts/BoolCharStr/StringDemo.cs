using UnityEngine;

// string : 문자열 데이터 형식
public class StringDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [1] string형 변수 선언하고 초기화하기
        string name = "홍길동";
      
        // [1-1] int 상수 선언하고 초기화하기
        const int AGE = 20;

        // [2] string형 변수에 저장된 데이터 값 사용하기
        Debug.Log("name: " + name); // 문자열 + 문자열 => 문자열 더하기 연산
        Debug.Log($"내 이름은 {name}"); // 문자열 보간법 =>  $" {변수이름} "

        // 연습하기 : 문자열 보간법으로 콘솔창에 안녕하세요 홍길동 입니다. 를 출력하기

        Debug.Log($"안녕하세요 {name}입니다.");
        
        // 연습하기 2 : 이름은 홍길동, 나이는 20살 입니다.
        Debug.Log($"이름은 {name}, 나이는 {AGE}살 입니다.");

        // 연습하기 3 : 이름은 이순신, 나이는 40살 입니다.
        name = "이순신";
        const int AGE2 = 40;
        Debug.Log($"이름은 {name}, 나이는 {AGE2}살 입니다.");
    }
}
