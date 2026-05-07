using UnityEngine;

// 2차원 배열 : 행과 열로 이뤄진 배열
public class ArrayTwo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        /*
        // [1] 배열 선언
        int[,] IntArray;

        // [2] 배열의 요소수(크기) 생성
        IntArray = new int[2,3];

        // [3] 배열 초기화
        IntArray[0, 0] = 1;
        IntArray[0, 1] = 2;
        IntArray[0, 2] = 3;

        IntArray[1, 0] = 4;
        IntArray[1, 1] = 5;
        IntArray[1, 2] = 6;
        */

        // 배열 선언 및 크기 생성 및 초기화

        // int[,] IntArray = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };
        int[,] IntArray = new int[, ] { { 1, 2, 3 }, { 4, 5, 6 } };

        // 배열 사용하기
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Debug.Log(IntArray[i, j]);
            }
        }
    }
}
