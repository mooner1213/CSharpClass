using UnityEngine;

// 정수형 배열을 만들고, 3개의 방을 만든다.
// 1번째 방 1저장, 2번째 방은 2저장, 3번째 방은 3저장 후, 이들을 콘솔창에 출력하라.
public class ArrayPractice : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int[] nums;
        nums = new int[3];
        nums[0] = 1; 
        nums[1] = 2; 
        nums[2] = 3;

        // Debug.Log($"1번방 : {nums[0]}, 2번방 : {nums[1]}, 3번방 : {nums[2]}");
        for (int i = 0; i < 3; i++)
        {
            Debug.Log($"{i}번째 방의 값은 {nums[i]}이다.");
        }
    }
}
