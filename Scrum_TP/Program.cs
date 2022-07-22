using Microsoft.VisualBasic.FileIO;
using System;

namespace Scrum_TP
{
    public class Program
    {
        static void Main(string[] args)
        {
            // import CSV
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

            // export XSLX
            var workbook = new XLWorkbook();
            workbook.AddWorksheet("sheetName");
            var ws = workbook.Worksheet("sheetName");

            int row = 1;
            foreach (object item in stockActuel)
            {
                if (row == 1)
                {
                    ws.Cell("A" + row.ToString()).Value = "Nom";
                    ws.Cell("B" + row.ToString()).Value = "Prix unitaire d'achat";
                    ws.Cell("C" + row.ToString()).Value = "Prix unitaire de vente";
                    ws.Cell("D" + row.ToString()).Value = "TVA";
                    ws.Cell("E" + row.ToString()).Value = "Quantité en Stock";
                    row++;
                }
                ws.Cell("A" + row.ToString()).Value = "Nom";
                ws.Cell("B" + row.ToString()).Value = "Prix unitaire d'achat";
                ws.Cell("C" + row.ToString()).Value = "Prix unitaire de vente";
                ws.Cell("D" + row.ToString()).Value = "TVA";
                ws.Cell("E" + row.ToString()).Value = "Quantité en Stock";
                row++;
            }
            workbook.SaveAs("yourExcel.xlsx");
        }
    }
}