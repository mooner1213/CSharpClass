using UnityEngine;

using Koera.Suwon;  //Koera.Suwon 에 있는 클래스를 바로 가져다 사용
using Su = Koera.Suwon; //Koera.Suwon를 Su 라는 별칭으로 지정

public class NameSpaceNote : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1]using을 선언해서 클래스 가져오기 - 인스턴스 생성
        Car seoul = new Car();
        seoul.Run();    //수원자동차

        //[2]using을 사용하지 않고 클래스 가져오기 - 인스턴스 생성
        //네임스페이스.클래스이름으로 가져오기
        Koera.Seoul.Car se = new Koera.Seoul.Car();
        se.Run(); //서울자동차
        Koera.Suwon.Car sw = new Koera.Suwon.Car();
        sw.Run(); //수원자동차

        //[3]별칭 사용해서 클래스 가져오기 - 인스턴스 생성
        Su.Car suwon = new Su.Car();
        suwon.Run();    //수원자동차

        //서울 트럭
        Koera.Seoul.Truck tr = new Koera.Seoul.Truck();
        tr.Run();
    }
}
