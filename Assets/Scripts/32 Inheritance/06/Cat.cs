using UnityEngine;

//sealde(봉인) 클래스: 상속 거부, 최종 클래스, 더이상 상속이 안되는 클래스
namespace InheritanceTest
{
    //Animal 상속 받는 고양이 클래스 - 봉인(sealed) 클래스 지정
    public sealed class Cat : Animal
    {

    }

    /*//Cat을 상속받는 내 고양이 클래스
    public class MyCat : Cat
    {
        //sealed 가 붙은 클래스는 부모로 지정이 불가능하다
    }*/
}