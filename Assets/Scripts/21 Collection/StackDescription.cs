using System.Collections;
using UnityEngine;

public class StackDescription : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1]Stack 인스턴스 만들기
        Stack stack = new Stack();

        //[2] 데이터 넣기
        stack.Push("대한민국");
        stack.Push("경기도");
        stack.Push("수원");

        //[3] Peek() : 제일 상단(마지막에 넣은)의 데이터를 반환
        Debug.Log($"{stack.Peek()}, {stack.Count}");

        //[4]맨위에 있는 데이터 꺼내기 - 수원 꺼내기
        stack.Pop();

        //[5] Peek() : 제일 상단(마지막에 넣은)의 데이터를 반환
        Debug.Log($"{stack.Peek()}, {stack.Count}");

        //[6]맨위에 있는 데이터 꺼내기 - 경기도
        stack.Pop();

        //[7] Peek() : 제일 상단(마지막에 넣은)의 데이터를 반환
        Debug.Log($"{stack.Peek()}, {stack.Count}");

        //[8]맨위에 있는 데이터 꺼내기 - 대한민국
        stack.Pop();

        if(stack.Count > 0)
        {
            Debug.Log($"{stack.Peek()}, {stack.Count}");
        }

        //[9] clear: 스택 비우기
        stack.Clear();
        Debug.Log($"{stack.Count}");

    }
}
