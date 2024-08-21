namespace Ucu.Poo.Restaurant;

/// <summary>
/// Representa un platillo individual en el menú del restaurante.
/// </summary>
public class Dish
{
    private string _name;
    public string Name
    {
        get { return _name; } set { _name = value; }
    }
    
    private float _price;
    public float Price
    {
        get { return _price; } set { _price = value; }
    }
    
    private bool _isVegetarian;
    public bool IsVegetarian
    {
        get { return _isVegetarian;} set { _isVegetarian = value; }
    }
    private Dish(string name, float price, bool isVegetarian)
    {
        this._name = name;
        this._price = price;
        this._isVegetarian = isVegetarian;
    }
}