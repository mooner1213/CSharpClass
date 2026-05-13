using UnityEngine;
using System.Collections.Generic;

// 제네릭 리스트
public class ListOfint : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [1] 배열 - 정수형 배열 변수 선언하고 요소수(크기) 생성
        int[] arrNumbers = new int[3];
        
        // 배열 초기화
        arrNumbers[0] = 10;
        arrNumbers[1] = 20;
        arrNumbers[2] = 30;

        // 배열 사용
        for (int i = 0; i < arrNumbers.Length; i++)
        {
            Debug.Log(arrNumbers[i]);
        }

        Debug.Log("======================");

        // 제네릭 리스트 사용 : int 전용 <int>
        // List<T> 의 인스턴스를 int 전용으로 생성하고 리스트에 40, 50, 60 을 저장하라

        List<int> ListNumber = new List<int>();

        // 리스트에 값 넣기
        ListNumber.Add(40);
        ListNumber.Add(50);
        ListNumber.Add(60);

        // 리스트 사용
        for (int i = 0; i < ListNumber.Count; i++)
        {
            Debug.Log(ListNumber[i]);
        }

        Debug.Log("======================");

        ListNumber.Add(80);

        // 리스트 사용
        for (int i = 0; i < ListNumber.Count; i++)
        {
            Debug.Log(ListNumber[i]);
        }

        // [3] 제네릭 리스트 클래스 (List<T>) : List<int>, List<String>, ...
        // <String> 전용 리스트 인스턴스 생성
        List<string> ListStr = new List<string>();
        // 리스트에 데이터 넣기
        ListStr.Add("R");
        ListStr.Add("G");
        ListStr.Add("B");

        // 리스트 사용
        foreach (var c in ListStr)
        {
            Debug.Log(c);
        }

        for (int i = 0;i < ListStr.Count;i++)
        {
            Debug.Log(ListStr[i]);
        }
    }
}
