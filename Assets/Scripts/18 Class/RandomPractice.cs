using UnityEngine;
using System;

// 로또 생성기
public class RandomPractice : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int[] num = new int[6]; // 6개의 방을 만듬

        System.Random random = new System.Random();
        for (int i = 0; i < num.Length; i++) // 배열의 길이만큼 반복해라
        {
            num[i] = random.Next(1, 46); // 배열에 있는 방마다 1 ~ 45사이의 랜덤 정수를 집어 넣기
            
            for (int j = 0; j < i; j++) // 중복검사
            {
                if (num[i] == num[j]) // 만약 배열안의 값이 다른 배열 안의 값과 같다면
                {
                    i--; // 뒤로 돌아가세요
                }
            }
        }
        
        Debug.Log($"로또 번호는 : {num[0]}, {num[1]}, {num[2]}, {num[3]}, {num[4]}, {num[5]} 입니다.");

    }
}

/*

[1] 6개 번호
[2] 1 ~ 45 사이의 랜덤 번호
[3] 6개 번호끼리 중복 금지

3가지의 조건이 들어 맞는 6개의 번호를 출력하는 프로그램 구현

[1] 임의의 숫자 6개 번호 생성(1 ~ 45 사이의 랜덤 값)
[2] 임의의 숫자 6개 번호 저장
[3] 임의의 숫자가 저장된 6개 번호 출력
[4] 중복 제거 기능 추가

*/