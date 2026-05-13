using UnityEngine;
using System.Linq;
using System.Collections.Generic;

public class LinqWhere : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // 정수형 배열 선언하고 초기화
        int[] numbers = { 1, 2, 3, 4, 5 };

        // numbers의 요소중에서 3보다 크고 짝수인 수를 구해서 리스트를 만들어 넣기
        List<int> listNumbers = numbers.Where(n => n > 3 && n % 2 == 0).ToList();

        foreach(int number in listNumbers)
        {
            Debug.Log(number);
        }
    }
}