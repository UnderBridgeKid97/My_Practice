using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace MyDefence
{
    // 플레이어의 속성을 관리하는 클래스 
    public class PlayerStats : MonoBehaviour
    {
        #region Variable

        private static int money;

        // 소지금 읽기전용 속성
        public static int Money
        {
            get { return money; }
        }
        // 게임시작시 지급하는 초기 소지금 400g
        [SerializeField] private int StartMoney = 400;

        // 라이프
        private static int lives;
        // 라이프 읽기 전용 속성
        public static int Lives => lives;

        // 게임 시작시 지급하는 초기 생명값 
        private int startLives = 10;


        #endregion

        private void Start()
        {
            // 초기화 
            money = StartMoney;
            // Debug.Log($"소지금{money}를 지급했습니다");
            lives = startLives;


        }
        // 돈을 번다 : 사냥, 퀘스트 클리어, 캐쉬 구매
        public static void AddMoney(int amount)
        {
            money += amount;
        }

        // 돈을 쓴다 : 아이템 구매, @@ 사용료....
        public static bool UseMoney(int amount)
        {
            // 사용전에 소지금 확인
            if (!HasMoney(amount))
            {
                Debug.Log("소지금이 부족합니다");
                return false;
            }

            money -= amount;
            return true;
        }

        // 소지금 잔금 확인
        public static bool HasMoney(int amount)
        {
            return money >= amount;
        }

        // 라이프 추가
        public static void AddLives(int amount)
        {
            lives += amount;
        }
        // 라이프 사용
        public static void UseLives(int amount)
        {
            lives -= amount;

            if (lives <= 0)
            {
                lives = 0; // 0미만 안내려가게
            }

        }
    }
}