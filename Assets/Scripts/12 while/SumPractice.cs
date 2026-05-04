using UnityEngine;

// 1부터 100까지의 정수 중에 3의 배수 or 4의 배수를 구해서 합하는 프로그램을 구현
// 응용함. i부터 j까지의 정수를 받겠음. x는 입력 받아야함.
public class SumPractice : MonoBehaviour
{
    public int i = 0;
    public int j = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int sum = 0;

        if (j < i)
        {
            Debug.Log("다시 숫자를 설정해주세요.");
        }
        else
        {
            int si = i;
            for (int n = i; n <= j; n++)
            {
                if (n % 3 == 0 || n % 4 == 0)
                {
                    sum = sum + n;
                }
            }
            Debug.Log($"{i}에서 {j}까지의 정수 중 3 또는 4의 배수의 합은 {sum}입니다.");
        }
    }
}
