using UnityEngine;

// 점수가 60점 이상이면 합격 출력, 아니라면 불합격 출력
public class ElseDemo : MonoBehaviour
{
    // 점수 입력
    public int score = 0; // 직접 입력 받기
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (score >= 60) // 점수가 60점 이상이면
        {
            Debug.Log("합격"); // 합격 출력

        }
        else // 아니라면
        {
            Debug.Log("불합격"); // 불합격 출력
        }
    }
}
