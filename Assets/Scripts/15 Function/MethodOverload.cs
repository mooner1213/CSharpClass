using UnityEngine;

// 메서드(함수) 오버로드 : 동일한 이름의 메서드를 매개변수를 달리하여 생성
public class MethodOverload : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // 1234 출력
        PrintNumber(1234);
        PrintNumber(12.34F);
        PrintNumber(1234L);

        // 인사하기
        Hi();
        Hi("반갑습니다?");
        Hi("또 만나용", 5);
    }

    // 매개변수로 숫자(여러 타입의 정수, 실수)를 입력받아 출력하는 함수(PrintNumber)
    void PrintNumber(int number)
    {
        Debug.Log($"int32 : {number}");
    }

    void PrintNumber(float number)
    {
        Debug.Log($"실수형F : {number}");
    }
    
    void PrintNumber(long number)
    {
        Debug.Log($"int64 : {number}");
    }

    // 인사하는 함수
    void Hi()
    {
        Debug.Log("안녕하세요.");
    }

    void Hi(string message)
    {
        Debug.Log(message);
    }

    // 매개변수로 인사횟수를 입력받아 count 만큼 인사하기
    void Hi(string message, int count)
    {
        for (int i = 0; i < count; i++)
        {
            Debug.Log(message);
        }
    }
}
