using UnityEngine;

namespace Method
{
    // 몬스터 전투를 관리하는 클래스
    public class ParameterNote : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            // 몬스터 생성
            Monster monster1 = new Monster(100, 10);
            Monster.monsterCount++;
            Monster monster2 = new Monster(200, 20);
            Monster.monsterCount++;

            // 생성된 몬스터 숫자
            Debug.Log($"몬스터 수 : {Monster.monsterCount}");

            // 전투
            // 몬스터 1 - atk -> 몬스터 2
            //monster2.TakeDamage(monster1.atk);
            MonsterBattle(monster1 , monster2);

            // 몬스터 2 - atk -> 몬스터 1
            //monster1.TakeDamage(monster2.atk);
            MonsterBattle(monster2 , monster1);

            Debug.Log($"현재 몬스터 1의 체력 : {monster1.hp}, 공격력 : {monster1.atk}");
            Debug.Log($"현재 몬스터 2의 체력 : {monster2.hp}, 공격력 : {monster2.atk}");
        }

        // 몬스터 전투 구현
        // 공격하는 몬스터, 방어하는 몬스터를 매개변수로 입력받아 공방식 적용

        public void MonsterBattle(Monster atkMonster, Monster defMonster)
        {
            defMonster.hp -= atkMonster.atk;
        }
    }
}