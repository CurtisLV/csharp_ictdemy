namespace Events;

internal class Customer
{
    private List<Order> orders = new List<Order>();

    public void AddOrder(Order order)
    {
        orders.Add(order);
        order.StateChanged += Notify;
    }

    public void Notify(object sender, EventArgs e)
    {
        Console.WriteLine($"Order state of {sender} changed to {(sender as Order).State}");
    }
}
