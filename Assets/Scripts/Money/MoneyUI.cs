using TMPro;
using UnityEngine;

public class MoneyUI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _moneyTXT;

    public void UpdateMoneyText(int currentMoney)
    {
        _moneyTXT.text = $"${currentMoney.ToString()}";
    }
}