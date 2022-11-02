using System;

public class PizzasModel
{
    public string ImageTitle { get; set; }
    public string PizzaName { get; set; }
    public float BasePrice { get; set; } = 2;
    public bool TomatoSauce { get; set; }
    public bool Cheese { get; set; }
    public bool Pepperoni { get; set; }
    public bool Chicken { get; set; }
}
