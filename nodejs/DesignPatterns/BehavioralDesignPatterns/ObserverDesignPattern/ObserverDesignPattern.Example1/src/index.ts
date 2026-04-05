import { Author } from './Author';
import { Follower } from './Follower';

const author = new Author('Berkan Serbes');
const follower1 = new Follower('Ali', 'ali@example.com');
const follower2 = new Follower('Ayşe', 'ayse@example.com');

author.subscribe(follower1);
author.subscribe(follower2);

author.publishArticle('Observer Pattern Nedir?', "Observer Design Pattern'ın gerçek hayat senaryosu...");

author.unsubscribe(follower1);

console.log();

author.publishArticle('Design Patterns', 'Tasarım desenleri yazılımda neden önemlidir?');
