using UnityEngine;

public class ForFactorial : MonoBehaviour
{
    public int factorial = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // 4! 값을 구하는 프로그램 구현...인데 내 입맛대로 바꿈ㅋ
        // 입력받은 값의 팩토리얼 값을 출력하는 프로그램임.

        int sum = 1;
        for (int i = 1; i <= factorial; i++)
        {
            sum = sum * i;
        }
        Debug.Log($"{factorial}!의 값은 {sum}입니다.");
    }
}
