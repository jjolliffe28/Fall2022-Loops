// Loops allow us to to repeat code 
// Loop types: For Loop, While loop, and Foreach loop, Do While Loop (exists but not very practical)
// Foreach and Do While loop are variants of our two main types of loops: For Loop & While Loop

// For Loop! - the most common type of loop
// A For loop is a block of code that runs a certain number of times. Or, a block of code that repeats for some range of numbers.
// for () {}
// for ( initializer ; condition ; incrament ) has three statements in ()
// Initializer -> statement that runs before the for loop starts
// Condition -> condition we check after  we check after each loop to see if we should keep running
// Incrament -> statement we run after each loop ends

// Let's say we want to print out every number 0 to 100.

// FOR:

for (var i = 0; i <= 100; i++) 
{
    Console.WriteLine(i);
}

// If we wanted only even numbers you can change it to i += 2


// While Loop!
// Simplest loop.
// Runs WHILE a condiiton is true

// SYNTAX for While Loop
// while(Condition){
// Code to run
// need to include a change to the condition or a break statement - or itll run infinitely 
// }

var j = 0;
while(j <= 100) 
{
    Console.WriteLine(j);
    j++;
 }

// For Each loop!
// Specific version of the for loop that repeats FOR EACH item in some collection
// For each loop on a bag of 5 things will run 5 times. Add something to the bag, it would run 6 times

// Do While Loop!
// A do while loop is just a while loop that is guranteed to run once. 

var k = 0;

do
{
    k++;
    Console.WriteLine(k + " do while loop");
}
while (k <= 100) ;