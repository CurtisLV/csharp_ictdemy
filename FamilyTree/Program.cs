using FamilyTree;

// Homer side
Person abraham = new Person("Abraham Simpson", null, null);
Person penelope = new Person("Penelope Olsen", null, null);

//Person herb = new Person("Herb Powers", abraham, penelope);
Person homer = new Person("Homer Simpson", abraham, penelope);

// Marge's side
Person pan = new Person("Mr Bouvier", null, null);
Person jackie = new Person("Jackie Bouvier", null, null);
Person marge = new Person("Marge Simpson", pan, jackie);

// Bart
Person bart = new Person("Bart Simpson", homer, marge);

FamTree treeBart = new FamTree(bart);

treeBart.Print();

FamTree treeHomer = new FamTree(homer);

treeHomer.Print();
