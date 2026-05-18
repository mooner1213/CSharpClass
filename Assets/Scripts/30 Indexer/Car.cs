using UnityEngine;
using System.Collections;

namespace Indexer
{
    // 인덱서 예제
    public class Car
    {
        // 필드
        private string[] names;

        // 속성
        public int Length
        {
            get {  return names.Length; }
        }

        // 생성자 - 매개변수로 길이를 입력받아 요소수 생성
        public Car(int length)
        {
            names = new string[length];
        }

        // 인덱서
        public string this[int index]
        {
            get { return names[index]; }
            set { names[index] = value; }
        }

        // 반복기 - 인덱서를 foreach문에서 사용하기위해 정의
        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < names.Length; i++)
            {
                yield return names[i];
            }
        }
    }
}