using UnityEngine;

namespace PrivatePublic
{
    public class VariableScope : MonoBehaviour
    {
        //필드 선언부
        string globalVariable = "전역 변수"; //전역변수, 필드, 멤버변수

        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //[1] 지역 변수 선언 및 초기화
            string localVaiable = "지역 변수";
            Debug.Log(localVaiable);

            //[2]-1 전역변수 사용
            Debug.Log(globalVariable);

            //[2]-2 함수 호출
            TestPrint();
        }

        //globalVariable 출력하는 함수
        void TestPrint()
        {
            //Debug.Log(localVaiable);    //error

            //전역변수 사용
            Debug.Log(globalVariable);
        }
    }
}

/*
= 필드(Field, 전역변수, 멤버변수) : 클래스 안에서 선언된 변수
: 클래스에서 사용하는 데이터의 상태, 값을 저장해 놓는 그릇
: 필드는 필드 선언부에서 선언하고 또 초기화 한다
: 필드(멤버)는 액세스 한정자를 지정합니다 - 기본값은 private으로 설정되어 있다

= 필드 네이밍
: 기본적으로 소문자 알파벳으로 네이밍한다
: 필드의 맨 앞에 있는 문자는 소문자로 시작하고 단어 연결시 대문자로 단어를 시작한다
: m_name 멤버변수
: 상수, 읽기 전용 변수는 대문자로 네이밍한다

= 액세스 한정자(접근 제한자, 권한)
public : 접근의 제한이 없다
private : 해당(현재) 클래스안에서만 접근 가능
protected : 해당(현재) 클래스안에서만 접근 가능, 상속받은 자식 클래스에서도 접근 가능
internal : 해당 프로젝트 내에서 접근 가능
*/