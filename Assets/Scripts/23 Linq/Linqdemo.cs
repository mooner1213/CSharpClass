using UnityEngine;
using System.Linq;

// Linq : 컬렉션 형태의 데이터를 가공할 때, 유용한 메서드를 많이 있다.
// 특정 형식에 원래 없던 기능을 덕붙이는 개념으로 제공하는 함수
public class Linqdemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [1] 정수형 배열 선언하고 초기화
        int[] numbers = { 1, 2, 4 };

        // [2] 배열 사용하기
        int count = numbers.Count();
        Debug.Log($"count: {count}");

        int sum = numbers.Sum();
        Debug.Log($"sum: {sum}");

        double avg = numbers.Average();
        Debug.Log($"avg: {avg:#.##}");

        int Max = numbers.Max();
        Debug.Log($"Max: {Max}");

        int Min = numbers.Min();
        Debug.Log($"Min: {Min}");
    }
}
