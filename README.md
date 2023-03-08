# CMP1903M-Assessment

a playing card shuffling and dealing method in C# for Assessment 1 of CMP1903.

2 classes and a testing program:

Card - creates an object with variables 'value' and 'suit' - value is the value assigned to the card; 1 = ace, 11 = jack, 12 = queen, 13 = king
ToString() override created in order to make the attributes more readable for end-user

Pack - where most code is. methods for creating deck of cards, selecting what type of shuffle to use , the 2 shuffles (fisher-yates and riffle) and card dealing to hand.

Program - creates pack object, calls shuffleCardPack method with different shuffle types, calls deal methods
