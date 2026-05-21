using UnityEngine;

namespace CustomGeneric
{
    public class GenericCup : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            // Cup클래스의 인스턴스 생성
            // Cup cup = new Cup(); <- 제네릭 클래스는 형식 매개변수 T에 데이터 형식을 지정해야 함
            // [1] T에 string을 지정하여 문자열을 저장하는 컵 만들기
            /*Cup<string> text = new Cup<string>();
            text.Content = "문자열"; */

            // [2] T에 int를 지정하여 정수를 저장하는 컵 만들기
            /*Cup<int> number = new Cup<int>();
            number.Content = 1234;

            Debug.Log($"{text.Content} - {number.Content}");

            //[3] 전용물컵 T에 water 지정
            Cup<Water> water = new Cup<Water>();
            water.Content = new Water();
            Debug.Log($"{water.Content.ToString()}");*/

            // [4] 
            Hello<string> hi = new Hello<string>();
            hi.Say("안녕하세요.");

            Hello<int> num = new Hello<int>();
            num.Say(1234);

            Hello<string> hello = new Hello<string>("반갑습니다.");
            Debug.Log(hello.GetMessage());
        }

    }
}