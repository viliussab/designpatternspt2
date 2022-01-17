namespace OPP
{
    public class Program
    {
        private static void Main()
        {

            ///* Template method */
            //var a = new AlgorithmImplementationA2();
            //a.TemplateMethod();

            ///* Iterator */
            //ConcreteCollectionA collection = new ConcreteCollectionA();
            //Iterator iterator = collection.CreateIterator();

            //while (!iterator.isDone())
            //{
            //    int element = (int)iterator.GetCurrentItem();
            //    Console.WriteLine($"Element: {element}");
            //    iterator.Next();
            //}

            ///* Composite */
            //Component a = new ItemLeaf(1, "piestukas");
            //Component b = new ItemLeaf(1, "tusinukas");
            //Component c = new ItemComposite(2, "penalas");
            //c.Add(a);
            //c.Add(b);

            //Component d = new ItemLeaf(4, "knyga");
            //Component e = new ItemComposite(3, "backpack");

            //e.Add(c);
            //e.Add(d);

            //Console.WriteLine($"Kuprine sveria: {e.GetWeight()}");

            ///* Flyweight */

            //Forest forest = new Forest();
            //forest.PlantTree(1, 1, "3", "3", "3");
            //forest.PlantTree(5, 5, "3", "3", "3");
            //forest.PlantTree(34, 5, "3", "3", "3");
            //forest.PlantTree(10, 10, "new", "new", "new");
            //forest.PlantTree(2, 5, "3", "3", "3");

            ///* State */

            //Player player = new Player();

            //Console.WriteLine($"Hitbox: {player.GetHitbox()}, speed: {player.GetMovementSpeed()}");

            //player.ChangeState(new RunningState(player));

            //Console.WriteLine($"Hitbox: {player.GetHitbox()}, speed: {player.GetMovementSpeed()}");

            ///* Proxy */

            //Sender sender = new Sender();

            //sender.send("localhost", "Hello world!");
            //sender.send(null, null);

            //HttpSender proxy = new SenderProxy(sender);

            //proxy.send("localhost", "Hello world!");
            //proxy.send(null, null);

            ///* Chain of responsibility */

            //ExcessiveContentHandler p1 = new EOFHandler();
            //ExcessiveContentHandler p2 = new NudesHandler();
            //ExcessiveContentHandler p3 = new SwearHandler();
            //ExcessiveContentHandler p4 = new ViolenceHandler();

            //p2.SetNext(p1);
            //p3.SetNext(p2);
            //p4.SetNext(p3);

            //Console.WriteLine($"Handle response: {p4.Handle("booba kill google images")}");
            //Console.WriteLine($"Handle response: {p4.Handle("minecraft")}");
            //Console.WriteLine($"Handle response: {p4.Handle("kill")}");

            ///* Interpreter */
            //List<Expression> additionArguments = new List<Expression>();
            //additionArguments.Add(new Number(3));
            //additionArguments.Add(new Number(5));
            //additionArguments.Add(new Number(10));

            //Expression addition = new AdditionExpression(additionArguments);

            //Console.WriteLine($"Addition results: {addition.Interpret()}");

            //List<Expression> subtractionArguments = new List<Expression>();
            //subtractionArguments.Add(addition);
            //subtractionArguments.Add(new Number(3));
            //subtractionArguments.Add(new Number(3));

            //Expression subtraction = new SubtractExpression(subtractionArguments);

            //Console.WriteLine($"Subtraction results: {subtraction.Interpret()}");

            ///* Mediator */
            //KTUMediator ktu = new KTUMediator();

            //List<Administration> list = new List<Administration>();
            //Administration jurga = new Administration("Jurga", ktu);
            //list.Add(jurga);

            //List<Student> list1 = new List<Student>();
            //Student gintas = new Student("Gintas", ktu);
            //list1.Add(gintas);

            //List<Teacher> list2 = new List<Teacher>();
            //Teacher patasius = new Teacher("Patasius", ktu);
            //list2.Add(patasius);

            //ktu.setAdmins(list);
            //ktu.setStudent(list1);
            //ktu.setTeachers(list2);

            //patasius.mediator.Notify(patasius, "kzn", "kiek 4 + 4?");

            //gintas.mediator.Notify(gintas, "Patasius", "8");

            //jurga.mediator.Notify(jurga, "Tema", "Chebra pameciau piestuka, kreiptikes i Gintauta");

            ///* Memento */
            //Game game = new Game();

            //Caretaker caretaker = new Caretaker(game);
            //caretaker.CreateSnapshot();

            //game.status = "dead";

            //caretaker.CreateSnapshot();
            //game.status = "running";

            //caretaker.RestoreToPreviousState();
            //Console.WriteLine(game.status);

            /* Visitor */

            Location city = new City();

            President obama = new President();
            PolishPerson polish = new PolishPerson();

            city.Accept(polish);
            city.Accept(obama);
        }
    }
}
