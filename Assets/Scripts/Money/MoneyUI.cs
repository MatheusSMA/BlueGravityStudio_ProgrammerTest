using TMPro;
using UnityEngine;

public class MoneyUI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _moneyTXT;

    public void UpdateMoneyText()
    {
        _moneyTXT.text = $"${Player.Instance.PlayerMoney.CurrentMoney.ToString()}";
    }
}