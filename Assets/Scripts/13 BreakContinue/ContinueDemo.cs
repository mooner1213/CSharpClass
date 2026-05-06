using UnityEngine;

// continue문 : 반복 실행문에서 continue가 있는 라인의 아래 실행문을 실행하지않고,
// 다음 반복문의 조건을 체크한 뒤, 다음 다음반복문 실행
public class ContinueDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // 1부터 10까지 홀수만 출력하는 프로그램 구현
        /*for (int i = 1; i <= 10; i++)
        {
            if ( i % 2 != 0)
            {
                Debug.Log($"i : {i}");
            }
        }*/

        // 짝수는 출력 x
        for (int i = 0; i <= 10; i++)
        {
            if (i % 2 == 0)
            {
                continue;
            }
            Debug.Log($"i : {i}");
        }
    }
}
