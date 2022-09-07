using OrderSystem;

Customer customer = new Customer(1, "Thomas", "Futile");
Address address = new Address("Evergreen", 10, 2, "Prague", "10000");

Product product = new Product("ict.social points", "Points to access premium content and achieve your dream job in IT.", 18);


Order order = new Order(1, product, customer, address, address);
