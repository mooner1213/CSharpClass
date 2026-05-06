using UnityEngine;

// 1부터 10까지 정수의 합을 구하는 프로그램 구현
// 단 합을 구하다가 합이 22이상이되면 더이상 합을 구하지않고 합을 출력
public class BreakPractice : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int i = 1;
        int sum = 0;
        for(; ; )
        {  
        sum = sum + i;
        i++;
            if( sum >= 22)
            {
                break;
            }
        }
        Debug.Log($"sum의 합 : {sum}");
    }
}
