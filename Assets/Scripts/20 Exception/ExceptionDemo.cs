using UnityEngine;

public class ExceptionDemo : MonoBehaviour
{
    //인스펙터창에서 입력
    public int x = 0;
    public int y = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //배열 선언하고 값 저장
        /*int[] arr = new int[2];
        arr[100] = 5;
        arr[0] = 1;
        Debug.Log(arr[0]);*/

        /*try
        {
            //배열 선언하고 값 저장
            int[] arr = new int[2];
            arr[100] = 5;

            arr[0] = 1;
            Debug.Log(arr[0]);
        }
        catch (System.Exception ex)
        {
            Debug.Log("에러가 발생했습니다");
        }*/

        int result = 0;

        try //예외가 발생할 가능성이 있는 구문이 들어오는 곳
        {
            result = x / y;
            //[1]
            Debug.Log($"{x}/{y} = {result}");
        }
        catch (System.Exception ex) //try절에서 예외가 발생하면 catch절을 실행
        {
            //[2]
            Debug.Log($"{ex.Message} 에러가 발생했습니다");
        }
        finally //try절에서 예외가 발생하던 안하던 상관없이 실행
        {
            //[3]
            Debug.Log("프로그램을 계속 실행");
        }

    }
}

/*
에러, 오류
- 문법 오류
- 런타임 오류
- 알고리즘 오류

예외처리(Exception Headling)
- try-catch-finally 구문을 사용하여 예외 처리

//예외가 발생할 만한 명령문 부분을 try구문으로 묶는다
try
{
    //명령문....
}
catch
{
    //try 구문 안의 명령문중 예외가 발생하면 처리할 내용
    //예외가 발생하지 않으면 무시
    //...
}


catch(System.Exception e)
{
    //try 구문 안의 명령문중 예외가 발생하면 처리할 내용
    //예외가 발생하지 않으면 무시
    //...
}
*/