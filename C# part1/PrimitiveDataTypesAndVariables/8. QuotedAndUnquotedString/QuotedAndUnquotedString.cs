using System;
class QuotedAndUnquotedString
{
    static void Main()
    {
        string quotation = "The \"use\" of quotations causes difficulties.";
        Console.WriteLine(quotation);
        string noQuotation = @"The ""use"" of quotations causes difficulties.";
        Console.WriteLine(noQuotation);
    }
}

