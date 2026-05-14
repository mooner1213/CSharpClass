using UnityEngine;
using Bar;
using Poo;

//NameSpace(네임스페이스)
public class NameSpaceDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Bar네임스페이스 Car 클래스의 인스턴스(객체) 생성 - 인스턴스 메서드 호출
        Bar.Car barCar = new Bar.Car();
        barCar.Go();

        //Poo네임스페이스 Car 클래스의 인스턴스(객체) 생성 - 인스턴스 메서드 호출
        Poo.Car pooCar = new Poo.Car();
        pooCar.Go();
    }
}


/*
//NameSpace(네임스페이스) : 클래스 등을 묶어서 관리하는 구조
1. 같은 이름 충돌 방지
2. 관련있는 기능끼리 모아놓기

문법
namespace 네임스페이스 이름
{
    //클래스...
}

*/