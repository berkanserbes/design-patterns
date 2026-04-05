import { ChatRoom } from './ChatRoom';
import { ChatUser } from './ChatUser';

const chatRoom = new ChatRoom('Design Patterns Discussion');

console.log();

const alice = new ChatUser(chatRoom, 'Alice');
chatRoom.registerUser(alice);

const bob = new ChatUser(chatRoom, 'Bob');
chatRoom.registerUser(bob);

const charlie = new ChatUser(chatRoom, 'Charlie');
chatRoom.registerUser(charlie);

console.log('\n--- Group Messages ---\n');

alice.send('Hello everyone!');
console.log();

bob.send('Hi Alice! How are you?');
console.log();

charlie.send('Hey team!');

console.log('\n--- Private Messages ---\n');

alice.sendPrivate('Can we discuss the project later?', bob);
console.log();

bob.sendPrivate('Sure, I will be available at 3 PM.', alice);
