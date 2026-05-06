using UnityEngine;

// array (배열) : 하나의 이름으로 같은 데이터 형식을 여러개 보관해놓는 그릇
// 선언 : 데이터 타입[] + 변수 이름
public class ArrayDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [1] 배열선언, 배열 만들기
        int[] numbers;

        // [2] 배열의 요소수 생성, 배열 크기(길이) 결정 - 그릇(방)의 개수 n개 지정
        numbers = new int[10]; // 배열의 방 번호 0 ~ n-1(0번부터 n개를 만든다는 뜻)

        // [3] 배열 초기화 - 배열 변수에 값 저장
        numbers[0] = 3480;
        numbers[1] = 2160;

        // [4] 배열 사용
        Debug.Log($"{numbers[0]} * {numbers[1]} * {numbers[2]} = {numbers[0] * numbers[1] * numbers[2]}");
    }
}
