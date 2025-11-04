using ObserverDesignPattern.Example1;

var author = new Author("Berkan Serbes");
var follower1 = new Follower("Ali", "ali@example.com");
var follower2 = new Follower("Ayşe", "ayse@example.com");

// Takipçiler yazarı takip ediyor
author.Subscribe(follower1);
author.Subscribe(follower2);

// Yazar yeni makale yayımlıyor
author.PublishArticle("Observer Pattern Nedir?", "Observer Design Pattern'ın gerçek hayat senaryosu...");

// Bir takipçi takibi bırakıyor
author.Unsubscribe(follower1);

Console.WriteLine();
// Yazar yeni makale yayımlıyor
author.PublishArticle("Design Patterns", "Tasarım desenleri yazılımda neden önemlidir?");

Console.ReadLine();
