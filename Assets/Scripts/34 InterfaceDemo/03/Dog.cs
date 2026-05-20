using UnityEngine;

namespace Interface
{
    // 인터페이스 '다중상속'을 이용
    public class Dog : IAnimal, IDog
    {
        public void Eat()
        {
            Debug.Log("먹다");
        }

        public void Yelp()
        {
            Debug.Log("짖다");
        }
    }
}

/*
 
복수의 인터페이스를 이용한 다중 상속 가능
복수의 클래스를 이용한 다중 상속은 불가능(C#)
클래스 + 인터페이스를 이용한 다중 상속 가능
 
 */