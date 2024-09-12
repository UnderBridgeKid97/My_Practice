using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace MyDefence
{
    // �÷��̾��� �Ӽ��� �����ϴ� Ŭ���� 
    public class PlayerStats : MonoBehaviour
    {
        #region Variable

        private static int money;

        // ������ �б����� �Ӽ�
        public static int Money
        {
            get { return money; }
        }
        // ���ӽ��۽� �����ϴ� �ʱ� ������ 400g
        [SerializeField] private int StartMoney = 400;

        // ������
        private static int lives;
        // ������ �б� ���� �Ӽ�
        public static int Lives => lives;

        // ���� ���۽� �����ϴ� �ʱ� ���� 
        private int startLives = 10;


        #endregion

        private void Start()
        {
            // �ʱ�ȭ 
            money = StartMoney;
            // Debug.Log($"������{money}�� �����߽��ϴ�");
            lives = startLives;


        }
        // ���� ���� : ���, ����Ʈ Ŭ����, ĳ�� ����
        public static void AddMoney(int amount)
        {
            money += amount;
        }

        // ���� ���� : ������ ����, @@ ����....
        public static bool UseMoney(int amount)
        {
            // ������� ������ Ȯ��
            if (!HasMoney(amount))
            {
                Debug.Log("�������� �����մϴ�");
                return false;
            }

            money -= amount;
            return true;
        }

        // ������ �ܱ� Ȯ��
        public static bool HasMoney(int amount)
        {
            return money >= amount;
        }

        // ������ �߰�
        public static void AddLives(int amount)
        {
            lives += amount;
        }
        // ������ ���
        public static void UseLives(int amount)
        {
            lives -= amount;

            if (lives <= 0)
            {
                lives = 0; // 0�̸� �ȳ�������
            }

        }
    }
}