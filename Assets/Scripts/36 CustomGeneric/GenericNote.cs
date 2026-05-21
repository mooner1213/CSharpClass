using System.Collections.Generic;
using UnityEngine;

namespace CustomGeneric
{
    // List<T> : int, string, Person 등 다양한 형식의 데이터를 저장할 수 있는 List 클래스
    public class GenericNote : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            // Person 을 저장하는 전용 List 만들기
            List<Person> people = new List<Person>()
            {
                new Person() { Name = "문재혁", Number = 1 },
                new Person() { Name = "김영빈", Number = 2 },
                new Person() { Name = "류웅수", Number = 3 },
                new Person() { Name = "전주호", Number = 4 },
                new Person() { Name = "이주석", Number = 5 },
            };
            for (int i = 0; i < people.Count; i++)
            {
                Debug.Log($"{people[i].Name} - {people[i].Number}");
            }

            Person nPerson = new Person() { Name = "민성씨", Number = 6 };
            people.Add(nPerson);

            foreach (var person in people)
            {
                Debug.Log($"{person.Name} - {person.Number}");
            }
        }
    }

    // 사람을 관리하는 클래스
    public class Person
    {
        public string Name {  get; set; }
        public int Number { get; set; }
    }

}
/*

클래스: 하나의 이름으로 서로 다른 형식의 데이터들과 함수들을 묶어 관리하는 데이터 구조
제네릭 클래스 : 형식 매개 변수 T에 지정한 데이터 형식으로 클래스에 멤버의 성질을 결정
  - Cup<T> : 컵 오브 티, 전용 컵 

 
 
 */