using UnityEngine;
using System.Collections.Generic;

public class DictionaryDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [1] Dictionary 제네릭 클래스
        // dictionary<TKey, Tvalue> 인스턴스 생성 : IDictionary(인터페이스) 로 생성
        IDictionary<string, string> data = new Dictionary<string, string>();

        // [2] 데이터 입력 : 키, 값을 매칭하여 입력
        data.Add("도", "경기도");
        data.Add("시", "수원시");

        // [3] 데이터 삭제 (키만 입력해도 삭제됨)
        data.Remove("도");

        //[4] 데이터 입력 2 : 인덱서를 사용하여 입력
        data["구"] = "장안구";

        // [5] 키값이 중복 불가 : 에러가 발생
        try
        {
            data.Add("구", "수성구");
        }
        catch(System.Exception ex)
        {
            Debug.Log(ex.Message);

            // [6] dictionary 사용
            foreach(KeyValuePair<string, string> item in data)
            {
                Debug.Log($"{item.Key}, {item.Value}");
            }
        }

        // [6] dictionary 사용 2 : 인덱스

        Debug.Log(data["구"]);

    }
}
