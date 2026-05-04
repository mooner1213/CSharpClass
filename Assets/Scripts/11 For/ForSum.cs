using UnityEngine;

// 1 부터 20 까지의 합을 구하는 프로그램 구현
public class ForSum : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        /*int n = 20;
        int sum = 0;
        for (int i = 1; i <= n; i++)
        {
            sum = sum + i;
        }
        Debug.Log($"1~20까지의 합은 {sum}입니다.");
        */

        // 1부터 10까지의 정수중 짝수들의 합을 구하는 프로그램 구현

        int n = 10;
        int sum = 0;

        for (int i = 1; i <= n; i++)
        {
            if (i % 2 == 0) // 짝수 판별식
            {
                sum = sum + i;
            }
        }
        Debug.Log(sum);
    }
}
