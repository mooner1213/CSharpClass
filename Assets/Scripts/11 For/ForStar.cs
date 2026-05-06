using UnityEngine;

// 이중 for문 : for(){ for () {} }
// 삼중 for문 : for(){ for () {for () } } }

public class ForStar : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // * 로 삼각형 만들기
        for (int i = 1; i <= 5; i++)
        {
            Debug.Log($"*을 {i}개 만큼 찍는다.");
            for(int j = 0; j < i; j++)
            {
                Debug.Log("*");
            }
            Debug.Log("\n");
        }
    }
}
