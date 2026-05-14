using UnityEngine;

namespace PrivatePublic
{
    public class FieldDemo : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //Say 클래스의 인스턴스 생성
            Say say = new Say();
            say.Hi();
            say.PrintNumber();

            //접근 제한자 에러
            //Debug.Log(say.message);
            say.categoriName = "책";
            Debug.Log(say.categoriName);

            //Person 클래스의 인스턴스 생성
            Person person = new Person();
            person.ShowProfile();

        }
    }
}