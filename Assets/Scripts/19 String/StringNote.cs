using UnityEngine;

//string 활용
public class StringNote : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //string 변수 선언하고 초기화
        string str = "";    //빈값으로 초기화
        str = System.String.Empty;  //빈값으로 초기화
        str = " Abc Def Fed Cba ";  //앞 뒤에 공백 하나씩 주어서 값 저장

        Debug.Log(str);
        Debug.Log(str.Length);          //문자열 길이 구하기
        Debug.Log(str[5]);              //'D' 출력
        Debug.Log(str.ToUpper());       //대문자로 변환해서 출력
        Debug.Log(str.ToLower());       //소문자로 변환해서 출력

        //공백 제거
        Debug.Log(str.Trim());          //앞뒤 공백 제거
        Debug.Log(str.TrimStart());     //앞부분 공백 제거
        Debug.Log(str.TrimEnd());       //뒷부분 공백 제거

        //검색
        Debug.Log(str.IndexOf('e'));    //'e'가 위치한 인덱스(방위치) 가져오기
        Debug.Log(str.Substring(5, 3)); //5번 인덱스(방위치)부터 3글자 가져오기
        Debug.Log(str.Substring(5));    //5번 인덱스(방위치)부터 끝까지 모두 가져오기
        Debug.Log(str.Remove(5, 3));    //5번 인덱스(방위치)부터 3글자 삭제하기

        //비교
        Debug.Log(str[1] == str[15]);   //A == a        false
        Debug.Log("ABC".Equals("Abc")); //ABC == Abc    false
        Debug.Log(System.String.Compare("BAC", "Bac")); // 0(같음), 1(다름 >), -1(다름 <)

        //연결하기
        var hi1 = "안녕";
        var hi2 = "하세요";

        Debug.Log(hi1 + " " + hi2);
        Debug.Log($"{hi1} {hi2}");
        Debug.Log(System.String.Format("{0} {1}", hi1, hi2));

        Debug.Log(System.String.Format("{0:C}", 1000));      //통화량
        Debug.Log(System.String.Format("{0:#,###}", 1000000));  //세자리 콤마

        //바꾸기
        string message = "Hello World";
        Debug.Log(message.Replace("Hello", "안녕하세요").Replace("World", "세계"));   //"안녕하세요 World".Replace()

        //문자열 분리하기 : 문자열에서 특정 구분자를 사용하여 문자열 배열을 만들수 있다
        string colorStr = "Red,Green,Blue";
        string[] colors = colorStr.Split(',');
        for (int i = 0; i < colors.Length; i++)
        {
            Debug.Log(colors[i]);
        }

    }
}