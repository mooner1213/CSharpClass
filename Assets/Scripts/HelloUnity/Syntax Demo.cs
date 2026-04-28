using UnityEngine;

// 문법(Syntax) : 문법은 반드시 지켜야 하는 규칙이다.
// 코딩 컨벤션(코딩 스타일) : 프로그래밍 작성 가이드, 약속이다.
public class SyntaxDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // 들여쓰기(Indentation)
        Debug.Log("들여쓰기는 공백 4칸 혹은 Tap을 사용한다.");

        // 공백 (White space) : C# 공백 무시
        Debug.Log("C#");
        Debug.Log( "C#" );
        Debug.
            Log(
            "C#"
            );
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

// 주석문(Comment) : 주석문은 컴파일, 실행에 영향을 주지 않는 코드

// : 한줄 주석

// 다중 주석문(Multi Comment)
/*
    여러 줄에 걸친 주석문
    여러 줄에 걸친 주석문
*/