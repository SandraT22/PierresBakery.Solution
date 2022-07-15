Project:
- 2 classes: Bread & Pastry.
- Initial WriteLine: "Welcome" + Bread cost and Pastry cost. 
- readline: how many bread they want & how many pastry. 
- writeline: total cost. 
- Bread deals: buy2 get 1 free bread. 
- Bread costs: 1 = $5, 2 = $10, 3 = $10
- Pastry Deals: buy 3 for $5. buy 6 for $10
- Pastry cost: 1 = $2, 4+ = 3 for $5 + additional for $2 each (until 6).

Questions: 
- What is they want more than 6 pastries? $2 for additional past 6? 
- What if they get 6 breads? 2 free? Or is the deal only if you're buying 3? 
- Include functionality in the event that the customer doesn't want to buy anything? 
- Should the customer be able to purchase both bread and pastries in one session? 

Objectives: 
- two classes
- classes include methods to determine prices. 
- use namespaces
- works
- auto-implemented properties
- models are thoroughly tested
- polished
- prompt answered. 
- ReadMe
- commit every hour

Brainstorm: 
Test1: 
if (breadNum <= 2) {
    breadPrice = breadNum * 5;
    return breadPrice;
Test2:
else if (breadNum % 3 == 0) {
   breadPrice = dealPrice
    return breadPrice;
Test3:
else if (breadNum % 3 > 0) {
    breadPrice = dealPrice + addPrice; 
    return breadPrice;
Test4: 
else {
    return Console.WriteLine("Please enter a numerical amount.");
  }
Test5:
if (pastryNum <= 2) {
    pastryPrice = pastryNum * 2;
    return pastryPrice;
Test6:
else if (pastryNum % 3 == 0) {
   pastryPrice = pDealPrice
    return pastryPrice;
Test7:
else if (pastryNum % 3 > 0) {
    pastryPrice = pDealPrice + pAddPrice; 
    return pastryPrice;
Test8:
 else {
    return Console.WriteLine("Please enter a numerical amount.");
  }

Notes: 

- bread class -> BreadPrice Method
  > breadNum = Console.ReadLine();
  > breadPrice = 0;
  > dealPrice = 0; (breadNum/3) * 10 (use method to round down)
  > addPrice = 0; (breadNum % 3) * 5
  > if (breadNum <= 2) {
    breadPrice = breadNum * 5;
    return breadPrice;
  } else if (breadNum % 3 == 0) {
   breadPrice = dealPrice
    return breadPrice;
  } else if (breadNum % 3 > 0) {
    breadPrice = dealPrice + addPrice; 
    return breadPrice;
  } else {
    return Console.WriteLine("Please enter a numerical amount.");
  }

  - Pastry class -> PastryPrice Method: 
  > pastryNum = Console.ReadLine();
  > pastryPrice = 0;
  > pDealPrice = 0; (breadNum/3) * 5 (use method to round down)
  > pAddPrice = 0; (breadNum % 3) * 2
  if (pastryNum <= 2) {
    pastryPrice = pastryNum * 2;
    return pastryPrice;
  } else if (pastryNum % 3 == 0) {
   pastryPrice = pDealPrice
    return pastryPrice;
  } else if (pastryNum % 3 > 0) {
    pastryPrice = pDealPrice + pAddPrice; 
    return pastryPrice;
  } else {
    return Console.WriteLine("Please enter a numerical amount.");
  }