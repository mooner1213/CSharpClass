using UnityEngine;

// break : 반복문(for, while)의 {} 을 빠져나오는 명령문
//       : 반복문(for, while)을 강제 종료
public class BreakDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // for문 break
        // 안녕하세요 5번 반복 출력하기, 단i가 2일때 for문을 종료

        /*for(int i = 0; i < 5; i++)
        {
            Debug.Log("안녕하세요.");
            if (i == 2)
            {
                break;
            }
        }*/

        // 무한루프
        /*
        for(;;)
        */

        int num = 0;

        // 무한루프
        // num 이 5이상이면 while 문 종료
        
        while (true)
        {
            Debug.Log($"number : {num}");
            num++;
            if (num >= 5)
            {
                break;
            }
        }
        
    }
}
