using UnityEngine;

// 두개의 정수를 입력받아 사칙연산, + 나머지값을 구하는 프로그램 구현
// 0으로 나누는 것 제외
public class FunctionPractice : MonoBehaviour
{
    public int a, b = 1;

    int Plus(int a, int b)
    {
        return a + b;
    }

    int Minus(int a, int b)
    {
        return a - b;
    }

    int X(int a, int b)
    {
        return a * b;
    }

    int Slice(int a, int b)
    {
        return a / b;
    }

    int trash(int a, int b)
    {
        return a % b;
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int Psum = Plus(a, b); 
        int Msum = Minus(a, b);
        int Xsum = X(a, b);
        int Ssum = Slice(a, b);
        int Tsum = trash(a, b);

        Debug.Log($"두 수의 더한 값은 {Psum}, 뺀 값은 {Msum}, 곱한 값은 {Xsum}, 나눈 값은 {Ssum}, 나눈값의 나머지는 {Tsum} 입니다.");
    }
}