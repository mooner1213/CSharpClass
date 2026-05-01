using UnityEngine;

public class IfElseAll : MonoBehaviour
{
    public int num = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // 숫자 판별

        // 짝수 판별식 - 입력 받은 수가 짝수면 num은 짝수 출력, 아니라면 num은 홀수 출력
        /*
        if (num % 2 == 0)
        {
            Debug.Log($"입력한 정수는{num}이고, 짝수 입니다.");
        }
        else
        Debug.Log($"입력한 정수는{num}이고, 홀수 입니다.");
        */

        // 입력 받은 수를 3의 배수, 5의 배수, 7의 배수인지 판별하라.
        // num은 3의 배수, num은 5의 배수, num은 7의 배수, num은 3,5,7의 배수가 아닌 수

        if (num % 3 == 0)
        {
            Debug.Log($"{num}은 3의 배수");
        }
        else if (num % 5 == 0)
        {
            Debug.Log($"{num}은 5의 배수");
        }
        else if (num % 7 == 0)
        {
            Debug.Log($"{num}은 7의 배수");
        }
        else
        {
            Debug.Log($"{num}은 3, 5, 7의 배수가 아닌 수");
        }
    }
}
