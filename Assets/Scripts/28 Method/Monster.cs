using UnityEngine;

namespace Method
{
    // 몬스터를 관리하는 클래스
    public class Monster
    {
        // 필드, 멤버변수
        // 정적 멤버 변수 : 단 하나만 존재하는 값, 공공의, 공유
        // 초기화도 1번만 함.
        public static int monsterCount = 0; // 게임에서 생성된 몬스터의 수

        public int hp; // 체력
        public int atk; // 공격력

        // 생성자 - 매개변수로 들어온 값으로 hp, atk 초기화
        public Monster(int hp, int atk)
        {
            this.hp = hp;
            this.atk = atk;
        }

        // 데미지 입는 함수
        public void TakeDamage(int dmg)
        {
            hp -= dmg;
        }
    }
}