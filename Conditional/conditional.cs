// -------------------------- if-else -------------------------- //

char ch = '0';              // char must be inside '.' but a string must be inside "...."

if (char.IsUpper(ch)){
    Console.WriteLine($"An uppercase character: {ch}");
}
else if (char.IsLower(ch)){
    Console.WriteLine($"A lowercase character: {ch}");
}
else if (char.IsDigit(ch)){
    Console.WriteLine($"A digit: {ch}");
}
else{
    Console.WriteLine($"Not a character nor a digit: {ch}");
}


if (char.IsUpper(ch))
    Console.WriteLine($"An uppercase character: {ch}");
    // Console.WriteLine($"An uppercase character: {ch}");      // error (cannot have 2 statements without {})
else
    Console.WriteLine($"A lowercase character: {ch}");
    Console.WriteLine($"A lowercase character: {ch}");


// -------------------------- switch -------------------------- //
double measurement = 20;

switch (measurement){
    case < 0.0:
        Console.WriteLine($"Measured value is {measurement}, which is soooo smallll");
        break;
    case > 15.0:
        Console.WriteLine($"Measured value is {measurement}, which is high");
        break;
    case double.NaN:
        Console.WriteLine($"Failed Measurement!!");
        break;
    default:
        Console.WriteLine($"Measured value is {measurement}");
        break;
}