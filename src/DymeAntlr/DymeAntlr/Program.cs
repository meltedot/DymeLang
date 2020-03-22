using System;
using System.Collections.Generic;
using System.IO;
using Antlr4.Runtime;
using Antlr4.Runtime.Tree;

namespace DymeAntlr
{
    class Program
    {
        static string FileSystemReturned = "";
        static void ParseImports(string input)
        {
            string[] imports = input.Split(';');
            foreach (var import in imports)
            {
                string[] commands = import.Split(' ');
                foreach (var command in commands)
                {
                    if (command.Contains("{") || command.Contains("}"))
                    {
                        return;
                    }
                    if (command.Contains("import"))
                    {
                        string toImport = commands[1].Split('\n')[0].Trim();
                        string dir = Environment.CurrentDirectory;
                        if (toImport.StartsWith("std"))
                            dir = @"C:\Dyme\";
                        string text = File.ReadAllText(dir + "\\" + toImport + ".dym");
                        FileSystemReturned += text;
                    }
                }
            }
        }

        static void Main(string[] args)
        {

            string input = File.ReadAllText(Environment.CurrentDirectory + "\\main.dym");
            // FILE SYSTEM
            if (input.Contains("import"))
            {
                ParseImports(input);
            }
            FileSystemReturned += File.ReadAllText(@"C:\Dyme\stdprimitives.dym");
            int i = 0;
            foreach (var chr in input)
            {
                if (chr == '{')
                {
                    input = input.Substring(i);
                    input = input.Insert(1, FileSystemReturned);
                    break;
                }
                i++;
            }
            AntlrInputStream inputStream = new AntlrInputStream(input);
            dymeLexer dymeLexer = new dymeLexer(inputStream);
            CommonTokenStream commonTokenStream = new CommonTokenStream(dymeLexer);
            dymeParser dymeParser = new dymeParser(commonTokenStream);
            dymeParser.BlockContext context = dymeParser.block();
            dymeVisitor dymeVisitor = new dymeVisitor();


            dymeVisitor.Visit(context);
        }
    }
}
