using UnityEngine;

// [Q] 1부터 100까지의 합을 구하는 프로그램 구현
// 단, 1부터 100까지 중 3의 배수는 합에서 제외
public class ContinuePractice : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int sum = 0;
        for (int i = 1; i <= 100; i++)
        {
            if( i % 3 != 0)
            {
                sum += i;
            }
            else
            {
                continue;
            }
        }
        Debug.Log($"3의 배수를 제외한 100까지의 합 : {sum}");
    }
}
