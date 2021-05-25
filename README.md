_____________________________________________________________________________________________________________________________________
Operator overloading(from https://docs.microsoft.com/en-us/cpp/cpp/operator-overloading?view=msvc-160:

The operator keyword declares a function specifying what operator-symbol means when applied to instances of a class. This gives the operator more than one meaning, or "overloads" it. The compiler distinguishes between the different meanings of an operator by examining the types of its operands.
______________________________________________________________________________________________________________________________________
Syntax:

type: operator operator-symbol (parameter-list)
______________________________________________________________________________________________________________________________________
Remarks:
You can redefine the function of most built-in operators globally or on a class-by-class basis. Overloaded operators are implemented as functions.
_______________________________________________________________________________________________________________________________________

Operator	Name			       Description			  Example	
++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
  '+'	        Addition	              Adds together two values	          x + y	
  '-'	        Subtraction	              Subtracts one value from another	  x - y
_______________________________________________________________________________________________________________________________________

The name of an overloaded operator is operator x, where x is the operator as it appears in the following table. 
For example, to overload the addition operator, you define a function called operator+. 
Similarly, to overload the addition/assignment operator, +=, define a function called operator+=. 	
_______________________________________________________________________________________________________________________________________

Example of code to overload the '+operator', then use similar code to overload the '-operator':

	//As a developer, I want to be able to overload the + operator, so that I can add two instances of the custom list class 	//together.
        //- List<int> one = new List<int>() {1,3,5}; and List<int> two = new List<int>() {2,4,6};
        //- List<int> result = one + two;
        //- result has 1,3,5,2,4,6

        public static CustomList<T> operator +(CustomList<T> a, CustomList<T> b)       // overload the + operator,
        {
            for (int i = 0; i < b.Count; i++)
            {
                a.Add(b[i]);//adds all the items from b to a, return the new a as combined collection
            }
            return a;//new list, after combination a & b

        }

	//  Use similar code to overload the '-operator'
        //  As a developer, I want to be able to overload the – operator, so that I can subtract one instance of a custom list class 
	//from another instance of a custom list class.
        //- List<int> one = new List<int>() { 1, 3, 5 }; and List<int> two = new List<int>() { 2, 1, 6 };
        //- List<int> result = one - two;
        //- result has 3,5

        //using the template of the + operator above, modify to use the '-' operator, 
	//using a for loop to complete, and a return for the new a.list

        public static CustomList<T> operator -(CustomList<T> a, CustomList<T> b)       // overload the - operator,
        {
            for (int i = 0; i < b.Count; i++)
            {
                a.Remove(b[i]);//subtracts all the items from b to a, return the new a as new, smaller collection
            }
            return a;//new list, after reduction of b from a
        }
