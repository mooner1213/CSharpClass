using UnityEngine;

// 1부터 5까지 1씩 증가하면서 값을 출력하는 프로그램 구현 / 반대의 경우도 ㄱㄱ
public class WhileCounter : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int i = 1;

        while (i <= 5)
        {
            Debug.Log($"카운트 다운! {i}");
            i++;
        }

        Debug.Log("==================================");

        i = 5;

        while (i > 0)
        {
            Debug.Log($"카운트 다운! {i}");
            i--;
        }
    }
}
