using UnityEngine;

public class WhileSum : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // while 문을 이용해서 1~100까지의 합을 구하는 프로그램 구현

        int i = 1;
        int sum = 0;
        while (i <= 100)
        {
            sum = sum + i;
            i++;
        }
        Debug.Log(sum);

        // 짝수의 합만 구하기
        int j = 1;
        int sum2 = 0;

        while (j < 100)
        {
            if(j % 2 == 0)
            {
                sum2 = sum2 + j;
                j++;
            }
        }
        Debug.Log(sum2);
    }
}
