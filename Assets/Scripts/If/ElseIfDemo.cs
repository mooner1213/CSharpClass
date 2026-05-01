using UnityEngine;

// 학점을 출력하는 프로그램
// 점수가 90 이상이면 A, 80이상이면 B, 70이상이면 C, 60이상이면 D, 나머지는 F
public class ElseIfDemo : MonoBehaviour
{
    public int score = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //학점을 저장하는 변수를 선언하고 초기화
        char grade = 'A';

        if (score >= 90)
        {
            //Debug.Log($"당신의 학점은 A 입니다.");
            grade = 'A';
        }
        else if (score >= 80)
        {
            //Debug.Log($"당신의 학점은 B 입니다.");
            grade = 'B';
        }
        else if (score >= 70)
        {
            //Debug.Log($"당신의 학점은 C 입니다.");
            grade = 'C';
        }
        else if (score >= 60)
        {
            //Debug.Log($"당신의 학점은 D 입니다.");
            grade = 'D';
        }
        else
            //Debug.Log($"당신의 학점은 F 입니다.");
            grade = 'F';

        Debug.Log($"당신의 학점은 {grade} 입니다.");
    }
}
