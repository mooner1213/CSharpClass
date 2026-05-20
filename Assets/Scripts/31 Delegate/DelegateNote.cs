using UnityEngine;

namespace Delegate
{
    //매개변수가 있고 반환값도 있는 메서드를 대신 실행할 대리자
    public class DelegateNote : MonoBehaviour
    {
        //[1] delegate 선언 - GetArea 대신 - double형 반환, 매개변수 int
        delegate double CircleArea(int r);


        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //[2]대리자 변수 선언 및 메서드 등록
            CircleArea area = GetArea;

            //[3] 대리자 호출 2
            Debug.Log(area(10));
            Debug.Log(area.Invoke(10));

        }

        //메서드 - 매개변수로 반지름을 받아서 원의 면적을 계산하여 반환하는 함수
        private double GetArea(int r)
        {
            return 3.14 * r * r;
        }

    }
}