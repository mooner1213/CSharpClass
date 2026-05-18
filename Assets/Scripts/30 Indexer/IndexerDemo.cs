using UnityEngine;

namespace Indexer
{
    public class IndexerDemo : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            /* // Catalog클래스의 인스턴스 생성
             Catalog ca = new Catalog();

             Debug.Log(ca[0]);
             Debug.Log(ca[1]);
             Debug.Log(ca[2]);
             Debug.Log(ca[3]);
             Debug.Log(ca[4]);
             Debug.Log(ca[5]);*/


            // Car 클래스의 인스턴스 생성
            Car cars = new Car(3);

            cars[0] = "아반떼";
            cars[1] = "그랜져";
            cars[2] = "소나타";

            /*// 인덱서 사용
            for (int i = 0; i < cars.Length; i++)
            {
                Debug.Log(cars[i]);
            }*/
            foreach (var car in cars)
            {
                Debug.Log(car);
            }
        }
    }
}

/*
 
Indexer(인덱서) : 클래스의 인스턴스(객체)를 배열처럼 []을 사용할 수 있도록 해주는 구문
인스턴스[0], 인스턴스[1], 인스턴스[2]
클래스에 있는 필드(배열, 컬렉션)의 값을 인덱서를 이용하여 사용(쓰기, 읽기)이 가능하게 해주는 구문

인덱서 형식

Class Car
Car cars = new Car(3);
cars[0] = "a";
cars[1] = "b";
cars[2] = "c";
 
*/