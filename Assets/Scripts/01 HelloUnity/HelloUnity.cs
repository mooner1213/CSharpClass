using UnityEngine;

public class HelloUnity : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Start 함수 호출"); // 현재 이프로그램이 잘 되는지 확인하고 싶다면, 이렇게 로그를 찍어보는것이 좋은 방법이다.
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Update 함수 호출");
    }
}
