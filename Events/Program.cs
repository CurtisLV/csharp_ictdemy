using Events;

Customer customer = new Customer();
Order objNotebook = new Order("Notebook");
Order objCellPhone = new Order("Cell phone");

customer.AddOrder(objNotebook);
customer.AddOrder(objCellPhone);

objCellPhone.ChangeState(Order.EState.Confirmed);
objNotebook.ChangeState(Order.EState.Confirmed);
objCellPhone.ChangeState(Order.EState.Shipped);

Customer customer2 = new Customer();
customer2.AddOrder(objNotebook);
objNotebook.ChangeState(Order.EState.Delivered);
