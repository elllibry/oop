using UnityEngine;

public class Item
{
    private string _name;
    private float _weight;
    private float _price;

    public Item(string name, float weight, float price)
    {
        _name = name;

        if (weight > 0) _weight = weight;
        if (price > 0) _price = price;
    }

    public string GetName() => _name;
    public float GetWeight() => _weight;
    public float GetPrice() => _price;

    public string GetInfo()
    {
        return $"Предмет: {_name}, Вес: {_weight}, Цена: {_price}";
    }

    public void IncreasePrice(float percent)
    {
        _price += _price * (percent / 100f);
        Debug.Log($"Цена предмета {_name} увеличена на {percent}%. Новая цена: {_price}");
    }
}

