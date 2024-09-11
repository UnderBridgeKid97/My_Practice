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

        #endregion

        private void Start ()
        {
            // �ʱ�ȭ 
            money = StartMoney;
            Debug.Log($"������{money}�� �����߽��ϴ�");
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
        


    }
}