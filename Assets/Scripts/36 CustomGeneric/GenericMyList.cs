using UnityEngine;

namespace CustomGeneric
{
    public class GenericMyList : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            // int 를 저장하는 MyList 인스턴스 생성
            MyList<int> numbers = new MyList<int>(3);
            numbers[0] = 10;
            numbers[1] = 20;
            numbers[2] = 30;

            for (int i = 0; i < numbers.Length; i++)
            {
                Debug.Log(numbers[i]);
            }

            // string을 저장하는 MyList 인스턴스 생성
            MyList<string> names = new MyList<string>(3);
            names[0] = "문재혁";
            names[1] = "김영빈";
            names[2] = "류웅수";

            foreach (var name in names)
            {
                Debug.Log(name);
            }
        }
    }
}