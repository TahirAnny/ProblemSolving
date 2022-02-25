#### C#

    Console.WriteLine("Enter Number:");
    string number = Console.ReadLine();

    var inp = Convert.ToInt32(number);

    for(var i = 1; i <= inp; i++){
        Console.Write(i);      //print everything in a single line
        //Console.WriteLine(i);  //print everything in a new line


#### Python

    n = int(input())
    for i in range(1, n+1):
        print(i, end='')

    print(...)
    print(value, ..., sep=' ', end='\n', file=sys.stdout)

    Prints the values to a stream, or to sys.stdout by default.
    Optional keyword arguments:
    file: a file-like object (stream); defaults to the current sys.stdout.
    sep:  string inserted between values, default a space.
    end:  string appended after the last value, default a newline.

    print() Parameters:
    objects - object to the printed. * indicates that there may be more than one object
    sep - objects are separated by sep. Default value: ' '
    end - end is printed at last
    file - must be an object with write(string) method. If omitted, sys.stdout will be used which prints objects on the screen.
    flush - If True, the stream is forcibly flushed. Default value: False