using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//컬렉션(Collect): 배열처럼 관련 객체의 그룹을 만들고 관리하는 데이터 구조들을 컬랙션이라고 한다
//배열, 리스트, 딕셔너리, ...
public class ArrayDescription : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //배열 선언하고 초기화
        int[] arr = { 3, 2, 1, 4, 5 };

        //배열 사용하기
        for (int i = 0; i < arr.Length; i++)
        {
            Debug.Log(arr[i]);
        }
        Debug.Log("======================");

        //정렬(Sort) - 오름차순, 1,2,3,4,5,
        System.Array.Sort(arr);

        //배열 출력하기
        foreach (int i in arr)
        {
            Debug.Log(i);
        }
        Debug.Log("======================");

        //배열의 역순으로 만들기
        System.Array.Reverse(arr);

        //배열 출력하기
        foreach (int i in arr)
        {
            Debug.Log(i);
        }


    }
}

/*
foreach 반복문 - 컬랙션을 가져와서 컬랙션 길이만큼 반복시킨다

//컬랙션 변수의 길이 만큼 반복하면서 첫번째 방에 있는 데이터 부터 마지막 방에 있는 데이터를
// a변수라는 변수에 입력하고 반복 실행문을 돌린다
foreach ((컬랙션의 데이터타입) a변수명 in 컬랙션 변수)
{
    //반복 실행문
}

*/