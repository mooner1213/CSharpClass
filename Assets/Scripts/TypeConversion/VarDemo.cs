using UnityEngine;

// var : 암시적으로 형식화된 로컬 변수
public class VarDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // name 변수 선언하고 "홍길동"으로 초기화하기
        var name = "홍길동"; // 초기화된 "홍길동" 값을 보고 name 변수의 타입을 string 형식으로 결정
        Debug.Log(name);
        Debug.Log("name type : " + name.GetType());
        
        // version 변수 선언하고 8.5으로 초기화하기
        var version = 8.5; // 초기화된 8.5 값을 보고 version 변수의 타입을 double 형식으로 결정
        Debug.Log(version);
        Debug.Log("version type : " + version.GetType());

        // car 변수 선언하고 100으로 초기화하기
        var car = 100; // 초기화된 100 값을 보고 car 변수의 타입을 int 형식으로 결정
        Debug.Log(car);
        Debug.Log("car type : " + car.GetType());
    }
}
