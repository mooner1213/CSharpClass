using UnityEngine;
using System.Collections;

namespace CustomGeneric
{
    public class MyList<T>
    {
        // 필드
        private T[] values;
        private int length; // 배열의 길이

        // 속성
        public int Length   // 읽기 전용 속성
        {
            get { return length; }
        }

        // 생성자
        public MyList(int length)
        {
            this.length = length;   // 배열의 길이를 받아오고
            values = new T[length]; // 길이만큼 배열 요소수 생성
        }

        // 인덱서
        public T this [int index]
        {
            get { return values[index]; }
            set { values[index] = value; }
        }

        // 반복기
        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < this.length; i++)
            {
                yield return this[i];
            }
        }
    }
}