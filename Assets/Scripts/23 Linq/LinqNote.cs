using UnityEngine;
using System.Linq;
using System.Collections.Generic;

public class LinqNote : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // 불형 배열 변수 선언하고 초기화
        bool[] isOuts = {true, false, true, false, true};

        // 배열의 개수 구하기, 배열의 값중에 true의 개수, 또는 false의 개수
        Debug.Log(isOuts.Count());

        // true의 갯수
        Debug.Log(isOuts.Count(x => x == true));

        // false의 갯수
        Debug.Log(isOuts.Count(y => y == false));

        // 정렬
        string[] colors = { "Red", "Green", "Blue" };

        // 오름차순 정렬(사전순서)
        IEnumerable<string> sortedColors =  colors.OrderBy(s => s);
        foreach (string color in sortedColors)
        {
            Debug.Log(color);
        }

        // 내림차순 정렬(사전순서)
        IEnumerable<string> sortedColors2 = colors.OrderByDescending(s => s);
        foreach(string color in sortedColors2)
        {
            Debug.Log(color);
        }

        // 리스트 사용
        List<string> allColors = new List<string> { "Red", "Green", "Blue" };
        var sColors = allColors.OrderByDescending(s => s);
        foreach (string color in sColors)
        {
            Debug.Log(color);
        }
    }
}
