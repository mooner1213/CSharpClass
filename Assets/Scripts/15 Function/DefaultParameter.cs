using UnityEngine;

// 기본 매개변수 (DefaultParameter, 선택적 매개변수) : 매개변수를 선언할때 초기화 한것
public class DefaultParameter : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        PrintError("입장 실패.", 4);
        // 기본 매개변수가 있는 함수 사용
    }

    // 매개변수를 들어온 에러메세지(문자열)와 레벨(정수)을 출력하는 함수
    void PrintError(string message, int Level = 1)
    {
        if (Level < 50)
        { 
        Debug.Log($"Error : {message}, 플레이어의 레벨({Level})이 권장레벨(50)이 아닙니다.");
        }
    }
}
