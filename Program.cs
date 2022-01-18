using Microsoft.ClearScript.V8;

using (var engine = new V8ScriptEngine())
{
    Console.WriteLine("Start script execution...");

    engine.Execute(@"var count = 0;

for (let i = 1; i < 1000000; i++) {
    count++;
}"
    );
    var count = (int)engine.Evaluate("count");

    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Number of iterations: {0}", count);
    Console.ForegroundColor = ConsoleColor.White;
}