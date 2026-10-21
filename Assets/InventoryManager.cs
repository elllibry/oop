using UnityEngine;

using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InventoryManager : MonoBehaviour
{
    [Header("UI Elements")]
    public TMP_Text outputText;
    public TMP_InputField nameInput;

    private List<Item> _items = new List<Item>();

    private void Print(string message)
    {
        Debug.Log(message);
        outputText.text += message + "\n";
    }

    public void AddItem(Item item)
    {
        _items.Add(item);
        Print($"Добавлен: {item.GetName()}");
    }

    public void ShowInventory()
    {
        outputText.text = "";
        Print("Инвентарь:");

        foreach (Item item in _items)
            Print(item.GetInfo());
    }

    public void RemoveItemUI()
    {
        string name = nameInput.text;
        RemoveItem(name);
    }

    public void RemoveItem(string name)
    {
        for (int i = 0; i < _items.Count; i++)
        {
            if (_items[i].GetName() == name)
            {
                Print($"Удалён: {name}");
                _items.RemoveAt(i);
                return;
            }
        }

        Print($"'{name}' не найден");
    }

    public void TotalWeightUI()
    {
        float sum = 0;
        foreach (Item item in _items)
            sum += item.GetWeight();

        Print($"Общий вес: {sum}");
    }

    public void TotalValueUI()
    {
        float sum = 0;
        foreach (Item item in _items)
            sum += item.GetPrice();

        Print($"Общая цена: {sum}");
    }

    public void MostExpensiveUI()
    {
        if (_items.Count == 0)
        {
            Print("Инвентарь пуст");
            return;
        }

        Item most = _items[0];

        foreach (Item item in _items)
            if (item.GetPrice() > most.GetPrice())
                most = item;

        Print("Самый дорогой:");
        Print(most.GetInfo());
    }

    public void FindByNameUI()
    {
        string name = nameInput.text;

        foreach (Item item in _items)
        {
            if (item.GetName() == name)
            {
                outputText.text = "";
                Print($"Найден предмет:");
                Print(item.GetInfo());
                return;
            }
        }

        outputText.text = "";
        Print($"Предмет '{name}' не найден");
    }


    void Start()
    {
        AddItem(new Item("Меч", 3.5f, 150));
        AddItem(new Item("Щит", 5.2f, 120));
        AddItem(new Item("Зелье", 0.5f, 40));
        AddItem(new Item("Лук", 2.1f, 90));
        AddItem(new Item("Шлем", 1.5f, 70));
    }
}


