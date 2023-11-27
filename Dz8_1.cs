namespace Dz8_1;

class Item
{
}
class Order
{
    private List<Item> itemList;

    internal List<Item> ItemList
    {
        get { return itemList; }
        set { itemList = value; }
    }
    public void AddItem() {/*...*/}
    public void DeleteItem() {/*...*/}
    public void GetItems() {/*...*/}
}
class OrderCalculator
{
    public void CalculateTotalSum() {/*...*/}
    public void GetItemCount() {/*...*/}
}
class OrderVisualization
{
    public void PrintOrder() {/*...*/}
    public void ShowOrder() {/*...*/}
}

class Manager
{
    public void Load() {/*...*/}
    public void Save() {/*...*/}
    public void Update() {/*...*/}
    public void Delete() {/*...*/}
}
