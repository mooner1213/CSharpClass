using UnityEngine;

// 1부터 5까지 1씩 증가하면서 값을 출력하는 프로그램 구현

public class ForCounter : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        for (int i = 0; i < 5; i++)
        {
            Debug.Log($"Count : {i + 1}");
        }

        Debug.Log("==============================");

        for (int i = 5; i > 0; i--)
        {
            Debug.Log($"Count : {i}");
        }
    }
}
