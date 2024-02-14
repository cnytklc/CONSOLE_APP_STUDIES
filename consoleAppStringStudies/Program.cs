// String Studies

string? sentence = "In this study we will learn how to study with string";
// 1. What is the length of sentence?

var resultLength = sentence.Length;

// 2. Does the sentence start with "this" and end with "with"? 

var resultStartsW = sentence.StartsWith("this");
var resultEndsW = sentence.StartsWith("with");

// 3. what is the index of "start"?

var resultIndexof = sentence.IndexOf("we"); 

// 4. Write the sentence all lower

var resultLower = sentence.ToLower();

// 5. Write the sentence all upper

var resultUpper = sentence.ToUpper();

// 6. Does the sentence have C#

var resultHaving = sentence.Contains("C#");

// 7. Write "work" instead of "study"

var resultChange = sentence.Replace("study","work");

Console.WriteLine(resultLength);
Console.WriteLine(resultStartsW);
Console.WriteLine(resultEndsW);
Console.WriteLine(resultIndexof);
Console.WriteLine(resultLower);
Console.WriteLine(resultUpper);
Console.WriteLine(resultHaving);
Console.WriteLine(resultChange);



