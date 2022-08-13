using Friends;

Person first = new Person();
Person second = new Person();

first.name = "Charles New";
first.age = 33;

second.name = "John Awesome";
second.age = 27;

first.friend = second;
second.friend = first;

first.Introduce();
second.Introduce();
