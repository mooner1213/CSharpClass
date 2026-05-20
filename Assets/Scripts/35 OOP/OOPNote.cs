using UnityEngine;

namespace OOP
{
    public class OOPNote : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            // 자식 클래스의 인스턴스 생성
            Dog dog = new Dog();
            Debug.Log(dog.Cry());

            Cat cat = new Cat();
            Debug.Log(cat.Cry());

            Debug.Log ("======================================");

            // [2] 부모클래스의 개체에 자식클래스 인스턴스 생성 저장 - 업캐스팅
            Animal myDog = new Dog();
            Debug.Log(myDog.Cry());

            Animal myCat = new Cat();
            Debug.Log(myCat.Cry());

            Debug.Log("======================================");

            // [3] 함수를 재정의하여 사용 : 트레이너가 훈련
            Trainer trainer = new Trainer();
            trainer.DoCry(new Dog());
            trainer.DoCry(new Cat());

            Debug.Log("======================================");
        }
    }

    // 다형성
    // [1] 추상 클래스
    public abstract class Animal
    {
        // 추상 메서드
        public abstract string Cry();

        public void Eat()
        {
            Debug.Log("먹다");
        }
    }

    // [2] Dog 클래스
    public class Dog : Animal
    {
        public override string Cry() => "멍멍";
    }

    // [3] Cat 클래스
    public class Cat : Animal
    {
        public override string Cry() => "야옹";
    }

    // [4] 동물 조련사 클래스
    public class Trainer
    {
        // 매개변수로 들어온 훈련 함수 구현

        public void DoCry(Animal animal)
        {
            Debug.Log(animal.Cry());
        }

        /*public void DoCry(Dog dog)
        {
            Debug.Log(dog.Cry());
        }
        public void DoCry(Cat cat)
        {
            Debug.Log(cat.Cry());
        }
        public void DoCry(Cow cow)
        {
            Debug.Log(cow.Cry());
        }*/
    }
}

/*

// 다형성 : 상속 (부모 - 자식)
: 객체를 여러 형식으로 읽어올 수 있다. - 형변환
: 형식 변환
: 업캐스팅 - 자식 클래스의 인스턴스를 부모 클래스의 형식으로 읽는 것
: 다운캐스팅 - 부모 클래스의 인스턴스를 자식 클래스의 형식으로 읽는 것
 
 */