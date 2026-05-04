using UnityEngine;

// char : 문자형 데이터 형식
public class CharacterDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [1] char형 변수 선언하고 초기화하기
        char grade = 'A';
        char kor = '한';

        Debug.Log("grade: " + grade);
        Debug.Log("kor: " + kor);
    }
}
