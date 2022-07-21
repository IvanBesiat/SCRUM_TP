using Microsoft.VisualBasic.FileIO;
using System;

namespace Scrum_TP
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Boisson> stockActuel = new List<Boisson>();

            using (TextFieldParser textFieldParser = new TextFieldParser(@"liste_boissons.csv"))
            {
                textFieldParser.TextFieldType = FieldType.Delimited;
                textFieldParser.SetDelimiters(";");
                while (!textFieldParser.EndOfData)
                {
                    string[] rows = textFieldParser.ReadFields();

                    Boisson boisson = new Boisson(
                        rows[0],
                        Convert.ToDouble(rows[1]),
                        Convert.ToDouble(rows[2]),
                        Convert.ToDouble(rows[3]),
                        Convert.ToInt32(rows[4])
                        );

                stockActuel.Add(boisson);
                }
            }
        }
    }
}