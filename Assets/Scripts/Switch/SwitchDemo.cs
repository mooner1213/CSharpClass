using UnityEngine;

//
public class SwitchDemo : MonoBehaviour
{
    public int num = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // num 이 1이면,num 은 1입니다. 라고 출력
        // num 이 2이면,num 은 2입니다. 라고 출력
        // 다른 수 이면 반응 x

        switch (num) // num data 판별
        {
            case 1:
                Debug.Log("num은 1입니다.");
                break;

            case 2:
                Debug.Log("num은 2입니다.");
                break;
        }
    }
}
/*

switch 문
조건 Data 값에 따라 명령문을 실행

switch(조건 data)
{
    case 1번 :
        // 실행문1
        break;

    case 2번 :
        // 실행문2
        break;

    case 3번 :
        // 실행문3
        break;

    default : // 모든 경우가 아니라면
        // 실행문4
        break;
}

*/