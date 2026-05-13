using System.Collections;
using UnityEngine;

public class ArrayListDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //ArrayList 클래스 인스턴스(객체) 생성
        ArrayList list = new ArrayList();

        //ArrayList 데이터 넣기: Add()
        list.Add("서울시");
        list.Add("강동구");
        list.Add("천호동");

        //ArrayList 데이터 사용
        /*for (int i = 0; i < list.Count; i++)
        {
            Debug.Log(list[i].ToString());
        }*/

        foreach(var o in list)
        {
            Debug.Log(o.ToString());
        }


    }
}
