using UnityEngine;

// 객체(인스턴스)를 배열 사용

public class ClassArray : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [1] 객체(인스턴스) 배열 선언 및 요소수 생성
        CategoryClass[] categories = new CategoryClass[3];

        // [2] 각각의 요소에 인스턴스(실체) 생성
        categories[0] = new CategoryClass();
        categories[1] = new CategoryClass();
        categories[2] = new CategoryClass();

        // [3] 배열 사용하기
        for (int i = 0; i < categories.Length; i++)
        {
            categories[i].Print(i);
        }
    }
}
