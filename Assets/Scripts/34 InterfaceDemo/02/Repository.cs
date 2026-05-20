using UnityEngine;

namespace Interface
{
    // IRepository 인터페이스를 상속받는 클래스
    public class Repository : IRepository
    {
        public void Get()
        {
            Debug.Log("Get() 함수를 구현해야 한다.");
        }
    }
}