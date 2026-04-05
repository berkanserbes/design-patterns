import { Auctioneer } from './Auctioneer';
import { AuctionParticipant } from './AuctionParticipant';

const auctioneer = new Auctioneer('Vintage Painting', 100);

console.log();

const alice = new AuctionParticipant(auctioneer, 'Alice');
auctioneer.registerBidder(alice);

const bob = new AuctionParticipant(auctioneer, 'Bob');
auctioneer.registerBidder(bob);

const charlie = new AuctionParticipant(auctioneer, 'Charlie');
auctioneer.registerBidder(charlie);

console.log('\n--- Bidding Phase ---\n');

alice.placeBid(150);
console.log();

bob.placeBid(200);
console.log();

charlie.placeBid(180); // Rejected
console.log();

alice.placeBid(250);
console.log();

bob.placeBid(300);
console.log();

auctioneer.announceWinner();
