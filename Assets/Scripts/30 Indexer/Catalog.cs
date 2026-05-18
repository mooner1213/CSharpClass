using UnityEngine;

namespace Indexer
{
    // 인덱서 예제
    public class Catalog
    {
        // 인덱스 값을 입력받아 짝수, 홀수 판별하여 리턴해주는 인덱서

        public string this[int index]
        {
            get
            {
                return (index % 2 == 0) ? $"{index}는 짝수" : $"{index}는 홀수";
            }
        }
    }
}
