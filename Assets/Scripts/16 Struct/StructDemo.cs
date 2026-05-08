using UnityEngine;

// [1] 구조체 정의, 선언
// 명함 데이터를 관리하는 구조체
struct BusinessCard
{
    public string name;    // 이름 저장하는 변수
    public int age;        // 나이 저장하는 변수
    public string address; // 주소 저장하는 변수
    // public 키워드 : 코드블록 밖에서 사용이 가능하도록 함.
    // BusinessCard가 아닌 다른 클래서에서 사용이 가능하도록 함.
}

public class StructDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        /*
        // [2] 구조체 형식의 변수 선언
         BusinessCard MyCard;

         // [3] 구조체에 속해 있는 변수들의 초기화
         MyCard.name = "홍길동";
         MyCard.age = 20;
         MyCard.address = "서울시 강동구";

         // [4] 구조체 사용
         //Debug.Log($"이름 : {MyCard.name}, 나이 : {MyCard.age}, 주소 : {MyCard.address}");

         PrintUserInfo(MyCard.name, MyCard.age);
         PrintUserInfo(MyCard);
        */

        // [5] 구조체 형식의 배열 변수 선언, 요소수 생성

        BusinessCard[] cards = new BusinessCard[2];

        // [6] 구조체에 속해 있는 변수들 초기화
        cards[0].name = "백두산";
        cards[0].age = 25;
        cards[0].address = "인천광역시";

        cards[1].name = "임꺽정";
        cards[1].age = 35;
        cards[1].address = "경기도 수원시";

        // [7] 사용
        for (int i = 0; i < cards.Length; i++)
        {
            // PrintUserInfo(cards[i].name, cards[i].age);
            PrintUserInfo(cards[i]);
        }

    }

    // 매개변수로 이름과 나이를 입력받아 출력하는 함수
    void PrintUserInfo(string name, int age)
    {
        Debug.Log($"이름 : {name}, 나이 : {age}");
    }

    // 매개변수로 구조체(BusinessCard)를 입력 받아 이름과 나이를 출력하는 함수
    void PrintUserInfo(BusinessCard bizcard)
    {
        Debug.Log($"이름 : {bizcard.name}, 나이 : {bizcard.age}, 주소 : {bizcard.address}");
    }
}


/*
변수 : 프로그램에서 사용할 데이터를 저장해 놓는 그릇, 단일
배열 : 하나의 이름으로 같은 데이터 형식을 여러개 보관해놓는 그릇, 복수(같은 데이터 방식)
데이터 형식 : int, long, bool, float, double, string, char
변수 선언 시 : (데이터 형식) 변수 이름;

구조체(Struct) : 하나의 이름으로 서로 다른 데이터와 함수들을 묶어 관리하는 데이터 구조
사용자 정의 데이터 형식 : 개발자가 만든 데이터 형식
변수 선언 : (개발자가 만든 구조체) 변수 이름;

구조체 형식
struct (구조체 이름)
{
    서로 다른 형식의데이터들
    함수들
}
*/