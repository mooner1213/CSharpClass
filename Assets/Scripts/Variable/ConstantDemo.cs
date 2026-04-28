using UnityEngine;

// 상수(Constant) : 저장된 데이터 값이 변하지 않는 변수, 읽기 전용 변수
public class ConstantDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [1] 정수형 상수 만들기 : 선언과 동시에 초기화
        const int MAX = 100;

        // [2] 상수 사용하기 (참조)
        Debug.Log("MAX : " + MAX);
    }
}