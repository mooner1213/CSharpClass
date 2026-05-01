using UnityEngine;

public class SwitchNote : MonoBehaviour
{
    public int answer = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // 1번 답을 선택했습니다., 2번 답을 선택했습니다., 3번 답을 선택했습니다., 4번 답을 선택했습니다.
        // 4개 다 아니면, 잘못 선택 하셨습니다. 출력

        switch (answer)
        {
            case 1:
                Debug.Log($"{answer}번 답을 선택했습니다.");
                break;

            case 2:
                Debug.Log($"{answer}번 답을 선택했습니다.");
                break;

            case 3:
                Debug.Log($"{answer}번 답을 선택했습니다.");
                break;

            case 4:
                Debug.Log($"{answer}번 답을 선택했습니다.");
                break;

            default:
                Debug.Log("잘못된 답을 선택했습니다. 다시 선택해 주세요.");
                break;
        }

        // 위의 switch 문을 if 문으로 구현해보기

        if (answer == 1)
        {
            Debug.Log($"{answer}번 답을 선택했습니다.");
        }
        else if (answer == 2)
        {
            Debug.Log($"{answer}번 답을 선택했습니다.");
        }
        else if (answer == 3)
        {
            Debug.Log($"{answer}번 답을 선택했습니다.");
        }
        else if (answer == 4)
        {
            Debug.Log($"{answer}번 답을 선택했습니다.");
        }
        else
        {
            Debug.Log("잘못된 답을 선택했습니다. 다시 선택해 주세요.");
        }
    }
}
